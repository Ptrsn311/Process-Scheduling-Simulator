﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    /// <summary>
    /// Process simulation
    /// </summary>
    public class Process
    {
        /// <summary>
        /// State of a process
        /// </summary>
        public enum State {
            /// <summary>
            /// Process is running (alive and not blocked)
            /// </summary>
            RUNNING,
            /// <summary>
            /// Process is blocked (by I/O)
            /// </summary>
            BLOCKED,
            /// <summary>
            /// Process is ended
            /// </summary>
            ENDED
        };

        /// <summary>
        /// Name of the process
        /// </summary>
        private string name;
        /// <summary>
        /// Probability of an I/O request
        /// </summary>
        private double ioProbability;
        /// <summary>
        /// Speed of the most common I/O operation. 
        /// </summary>
        private IO.Speed ioSwiftness;

        /// <summary>
        /// Length of the process (tick)
        /// </summary>
        private int length;

        /// <summary>
        /// Remaining time of the process (tick)
        /// </summary>
        private int remainingTick;

        /// <summary>
        /// Current I/O Operation (nullable)
        /// </summary>
        private IO currentIO;

        /// <summary>
        /// Total time of process on CPU
        /// </summary>
        private int cpuTime;

        /// <summary>
        /// time passed since last on CPU
        /// </summary>
        private int waitTime;

        /// <summary>
        /// Total time of IO blocking
        /// </summary>
        private int ioTime;

        /// <summary>
        /// Number of IO requests
        /// </summary>
        private int ioCount;

        /// <summary>
        /// Process constructor
        /// </summary>
        /// <param name="name">Name of the process</param>
        /// <param name="ioProbability">I/O Probability of the process</param>
        /// <param name="ioSwiftness">I/O Swiftness of the process</param>
        /// <param name="length">Process length</param>
        public Process(string name, double ioProbability, IO.Speed ioSwiftness, int length)
        {
            InitializeProcess(name, ioProbability, ioSwiftness, length);
        }

        /// <summary>
        /// Process constructor
        /// </summary>
        /// <param name="name">Name of the process</param>
        /// <param name="ioProbability">I/O Probability of the process (in percent)</param>
        /// <param name="ioSwiftness">I/O Swiftness of the process</param>
        /// <param name="length">Process length</param>
        public Process(string name, int ioProbability, IO.Speed ioSwiftness, int length)
        {
            if (ioProbability < 0 || ioProbability > 100)
            {
                throw new ArgumentException("Parameter must be between 0 and 100", "I/O Probability");
            }
            InitializeProcess(name, (double)ioProbability / 100, ioSwiftness, length);
        }

        /// <summary>
        /// Initializes the process (necessary for constructor overload)
        /// </summary>
        /// <param name="name">Name of the rpocess</param>
        /// <param name="ioProbability">I/O Probability of the process</param>
        /// <param name="ioSwiftness">I/O Swiftness of the process</param>
        /// <param name="length">Length of the process</param>
        private void InitializeProcess(string name, double ioProbability, IO.Speed ioSwiftness, int length)
        {
            if (name.Length < 2 || name.Length > 15)
            {
                throw new ArgumentException("Parameter must be between 2 and 15 character", "Process Name");
            }
            if (ioProbability < 0 || ioProbability > 1)
            {
                throw new ArgumentException("Parameter must be between 0 and 1", "I/O Probability");
            }
            if (length <= 0)
            {
                throw new ArgumentException("Parameter must be greater than 0", "Process Length");
            }
            this.name = name;
            this.ioSwiftness = ioSwiftness;
            this.ioProbability = ioProbability;
            this.length = length;

            cpuTime = 0;
            waitTime = 0;
            ioTime = 0;
            ioCount = 0;

            remainingTick = length;
        }

        /// <summary>
        /// This function equals as 'do something'
        /// We only simulate the process so there is isn't any real work, only a counter
        /// </summary>
        /// <returns>Process running was useful (not blocked or dead)</returns>
        public bool Do()
        {
            //If there is no I/O request running and not done
            if (currentIO == null && remainingTick > 0)
            {
                cpuTime++;

                // Don't add IO if process gets finished
                if (--remainingTick > 0)
                {
                    AddIO();
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Simulates a wait time for an IO request.
        /// Using this instead an event for changing state.
        /// When done, sets <c>currentIO</c> to null which indicates blocked status.
        /// </summary>
        public void WaitForIO()
        {
            if (currentIO != null)
            {
                if (!currentIO.Done)
                {
                    ioTime++;
                    currentIO.GetData();
                }
                else
                {
                    currentIO = null;
                }
            }
        }
        /// <summary>
        /// This function increases actual wait time
        /// </summary>
        public void Wait()
        {
            waitTime++;
        }

        /// <summary>
        /// This function resets actual wait time
        /// </summary>
        public void ResetWait()
        {
            waitTime = 0;
        }

        /// <summary>
        /// This function starts an I/O operation.
        /// </summary>
        private void AddIO()
        {
            //There is no I/O operation
            if (currentIO == null)
            {
                //Process has a chance to get I/O operation (normal distribution, 5% deviation, Box-Muller transform)
                Random random = new Random();

                double u1 = 1.0 - random.NextDouble();
                double u2 = 1.0 - random.NextDouble();
                double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);

                double randNormal =ioProbability + 0.05 * randStdNormal;
                double rand = random.NextDouble();
                if (rand <= randNormal)
                {
                    //Our process wants I/O operation

                    ioCount++;

                    //Determine speed of operation (80% chance to get ioSwiftness speed, 10-10% the other two)
                    int randomSwiftness = random.Next(0, 9);
                    IO.Speed speed = IO.Speed.FAST;

                    if (randomSwiftness < 8)
                    {
                        speed = ioSwiftness;
                    }
                    else
                    {
                        // This is overkill
                        // Cycles between enum values
                        // -- Adds randomSwiftness - 7 to currentSwiftness
                        // -- Wraps around enum values (e.g., If enum has 3 values, then 3 + 1 == 0)
                        speed = (IO.Speed)((randomSwiftness - 7 + (int)ioSwiftness) % Enum.GetValues(typeof(IO.Speed)).Length);
                    }

                    currentIO = new IO(speed);
                }
            }
        }

        /// <summary>
        /// Resets process state
        /// </summary>
        public void Reset()
        {
            remainingTick = length;
            cpuTime = 0;
            waitTime = 0;
            ioTime = 0;
            ioCount = 0;
            currentIO = null;
        }

        /// <summary>
        /// Returns the blocked state of the process
        /// </summary>
        /// <returns>Process is blocked by an I/O operation</returns>
        public bool Blocked => (currentIO != null);

        /// <summary>
        /// Returns true if the process is done
        /// </summary>
        /// <returns>Process is done</returns>
        public bool IsDone => (remainingTick <= 0);

        /// <summary>
        /// Property of name
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 2 || value.Length > 15)
                {
                    throw new ArgumentException("Parameter must be between 2 and 15 character", "Process Name");
                }
                name = value;
            }
        }

        /// <summary>
        /// Property of I/O probability
        /// </summary>
        public double IOProbability
        {
            get { return ioProbability; }
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Parameter must be between 0 and 1", "I/O Probability");
                }
                ioProbability = value;
            }
        }

        /// <summary>
        /// Property of I/O Probability (by percent)
        /// </summary>
        public int IOProbabilityPercent
        {
            get { return (int)Math.Round(ioProbability * 100); }
        }

        /// <summary>
        /// Property of I/O swiftness
        /// </summary>
        public IO.Speed IOSwiftness
        {
            get { return ioSwiftness; }
            set { ioSwiftness = value; }
        }

        /// <summary>
        /// Property of process length
        /// </summary>
        public int Length
        {
            get { return length; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Parameter must be greater than 0", "Process Length");
                }
                length = value;
            }
        }

        /// <summary>
        /// Returns the total time of process
        /// </summary>
        public int TotalTime
        {
            get { return cpuTime + ioTime; }
        }

        /// <summary>
        /// Returns the current wait time of process
        /// </summary>
        public int WaitTime
        {
            get { return waitTime; }
        }

        /// <summary>
        /// Returns the remainingTicks
        /// </summary>
        public int RemainingTick
        {
            get { return remainingTick; }
        }

        /// <summary>
        /// Returns the total I/O time of process
        /// </summary>
        public int IOTime
        {
            get { return ioTime; }
        }

        /// <summary>
        /// Returns the average I/O time per request
        /// </summary>
        public double AverageIORequestTime
        {
            get { return (double) ioTime / (double) ioCount; }
        }

        /// <summary>
        /// Returns the ratio of I/O operation per process
        /// between 0.0 and 1.0
        /// </summary>
        public double IORatio
        {
            get { return (double) ioTime / (double) (cpuTime + ioTime); }
        }

        /// <summary>
        /// Returns the total CPU time of process
        /// </summary>
        public int CPUTime
        {
            get { return cpuTime; }
        }

        /// <summary>
        /// Returns the ratio of CPU operation per process
        /// between 0.0 and 1.0
        /// </summary>
        public double CPURatio
        {
            get { return (double)cpuTime / (double)(cpuTime + ioTime); }
        }

        /// <summary>
        /// Returns the progress of the process
        /// </summary>
        /// In real life we don't know when the process will finish
        /// We do it because the interactivity
        public int Progress
        {
            get { return length - remainingTick; }
        }

        /// <summary>
        /// Returns the current I/O operation
        /// </summary>
        public IO CurrentIO
        {
            get { return currentIO; }
        }

        /// <summary>
        /// Returns the string representation of the class
        /// </summary>
        /// <returns>Parsed string</returns>
        public override string ToString()
        {
            string ret = "";
            ret += Name + " [";
            ret += "I/O Probability: " + IOProbabilityPercent + "%, ";
            ret += "I/O Switness: " + IOSwiftness + ", ";
            ret += "Length: " + Length + "]";

            return ret;
        }
      
    }
}
