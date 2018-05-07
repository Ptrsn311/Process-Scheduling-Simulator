﻿namespace PSS
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.clearProcesses = new System.Windows.Forms.Button();
            this.buttonDeleteProcess = new System.Windows.Forms.Button();
            this.buttonEditProcess = new System.Windows.Forms.Button();
            this.buttonAddProcess = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonImportData = new System.Windows.Forms.Button();
            this.processGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IOProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IOSwiftness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processData = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.algList = new System.Windows.Forms.ComboBox();
            this.simSpeed = new System.Windows.Forms.TrackBar();
            this.labelSimSpeed = new System.Windows.Forms.Label();
            this.buttonReady = new System.Windows.Forms.Button();
            this.labelQT = new System.Windows.Forms.Label();
            this.numericQT = new System.Windows.Forms.NumericUpDown();
            this.trackBarQT = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processData)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQT)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.processGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.settingsPanel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonReady, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.clearProcesses);
            this.flowLayoutPanel1.Controls.Add(this.buttonDeleteProcess);
            this.flowLayoutPanel1.Controls.Add(this.buttonEditProcess);
            this.flowLayoutPanel1.Controls.Add(this.buttonAddProcess);
            this.flowLayoutPanel1.Controls.Add(this.buttonExport);
            this.flowLayoutPanel1.Controls.Add(this.buttonImportData);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(547, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(108, 189);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // clearProcesses
            // 
            this.clearProcesses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearProcesses.Location = new System.Drawing.Point(3, 163);
            this.clearProcesses.Name = "clearProcesses";
            this.clearProcesses.Size = new System.Drawing.Size(90, 23);
            this.clearProcesses.TabIndex = 3;
            this.clearProcesses.Text = "Clear Process List";
            this.clearProcesses.UseVisualStyleBackColor = true;
            this.clearProcesses.Click += new System.EventHandler(this.clearProcesses_Click);
            // 
            // buttonDeleteProcess
            // 
            this.buttonDeleteProcess.Location = new System.Drawing.Point(3, 134);
            this.buttonDeleteProcess.Name = "buttonDeleteProcess";
            this.buttonDeleteProcess.Size = new System.Drawing.Size(90, 23);
            this.buttonDeleteProcess.TabIndex = 2;
            this.buttonDeleteProcess.Text = "Delete Process";
            this.buttonDeleteProcess.UseVisualStyleBackColor = true;
            this.buttonDeleteProcess.Click += new System.EventHandler(this.buttonDeleteProcess_Click);
            // 
            // buttonEditProcess
            // 
            this.buttonEditProcess.Location = new System.Drawing.Point(3, 105);
            this.buttonEditProcess.Name = "buttonEditProcess";
            this.buttonEditProcess.Size = new System.Drawing.Size(90, 23);
            this.buttonEditProcess.TabIndex = 1;
            this.buttonEditProcess.Text = "Edit Process";
            this.buttonEditProcess.UseVisualStyleBackColor = true;
            this.buttonEditProcess.Click += new System.EventHandler(this.buttonEditProcess_Click);
            // 
            // buttonAddProcess
            // 
            this.buttonAddProcess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddProcess.Location = new System.Drawing.Point(3, 76);
            this.buttonAddProcess.Name = "buttonAddProcess";
            this.buttonAddProcess.Size = new System.Drawing.Size(90, 23);
            this.buttonAddProcess.TabIndex = 0;
            this.buttonAddProcess.Text = "Add Process";
            this.buttonAddProcess.UseVisualStyleBackColor = true;
            this.buttonAddProcess.Click += new System.EventHandler(this.buttonAddProcess_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExport.Location = new System.Drawing.Point(3, 47);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(90, 23);
            this.buttonExport.TabIndex = 9;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonImportData
            // 
            this.buttonImportData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonImportData.Location = new System.Drawing.Point(3, 18);
            this.buttonImportData.Name = "buttonImportData";
            this.buttonImportData.Size = new System.Drawing.Size(90, 23);
            this.buttonImportData.TabIndex = 8;
            this.buttonImportData.Text = "Import";
            this.buttonImportData.UseVisualStyleBackColor = true;
            this.buttonImportData.Click += new System.EventHandler(this.buttonImportData_Click);
            // 
            // processGridView
            // 
            this.processGridView.AllowUserToAddRows = false;
            this.processGridView.AllowUserToDeleteRows = false;
            this.processGridView.AllowUserToResizeColumns = false;
            this.processGridView.AllowUserToResizeRows = false;
            this.processGridView.AutoGenerateColumns = false;
            this.processGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.processGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.processGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.processGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.IOProbability,
            this.IOSwiftness,
            this.Length});
            this.tableLayoutPanel1.SetColumnSpan(this.processGridView, 2);
            this.processGridView.DataSource = this.processData;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.processGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.processGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processGridView.Location = new System.Drawing.Point(13, 63);
            this.processGridView.MultiSelect = false;
            this.processGridView.Name = "processGridView";
            this.processGridView.ReadOnly = true;
            this.processGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.processGridView.RowHeadersVisible = false;
            this.processGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.processGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.processGridView.Size = new System.Drawing.Size(528, 189);
            this.processGridView.TabIndex = 2;
            this.processGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.processGridView_ColumnHeaderMouseClick);
            this.processGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.MakeColumnsSortable_DataBindingComplete);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "Name";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.name.DefaultCellStyle = dataGridViewCellStyle17;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IOProbability
            // 
            this.IOProbability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IOProbability.DataPropertyName = "IOProbabilityPercent";
            this.IOProbability.HeaderText = "I/O Probability";
            this.IOProbability.Name = "IOProbability";
            this.IOProbability.ReadOnly = true;
            // 
            // IOSwiftness
            // 
            this.IOSwiftness.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IOSwiftness.DataPropertyName = "IOSwiftness";
            this.IOSwiftness.HeaderText = "I/O Swiftness";
            this.IOSwiftness.Name = "IOSwiftness";
            this.IOSwiftness.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Length.DataPropertyName = "Length";
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Process List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(211, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Settings";
            // 
            // settingsPanel
            // 
            this.settingsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsPanel.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.settingsPanel, 2);
            this.settingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingsPanel.Controls.Add(this.label4, 0, 1);
            this.settingsPanel.Controls.Add(this.label3, 0, 0);
            this.settingsPanel.Controls.Add(this.algList, 1, 0);
            this.settingsPanel.Controls.Add(this.simSpeed, 1, 1);
            this.settingsPanel.Controls.Add(this.labelSimSpeed, 1, 2);
            this.settingsPanel.Controls.Add(this.labelQT, 0, 3);
            this.settingsPanel.Controls.Add(this.numericQT, 1, 4);
            this.settingsPanel.Controls.Add(this.trackBarQT, 1, 3);
            this.settingsPanel.Location = new System.Drawing.Point(137, 360);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.RowCount = 5;
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settingsPanel.Size = new System.Drawing.Size(279, 146);
            this.settingsPanel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Simulation Speed:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Algorithm:";
            // 
            // algList
            // 
            this.algList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.algList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algList.FormattingEnabled = true;
            this.algList.Location = new System.Drawing.Point(148, 4);
            this.algList.Name = "algList";
            this.algList.Size = new System.Drawing.Size(121, 21);
            this.algList.TabIndex = 2;
            this.algList.SelectedValueChanged += new System.EventHandler(this.algList_SelectedValueChanged);
            // 
            // simSpeed
            // 
            this.simSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simSpeed.LargeChange = 100;
            this.simSpeed.Location = new System.Drawing.Point(157, 32);
            this.simSpeed.Maximum = 1000;
            this.simSpeed.Minimum = 1;
            this.simSpeed.Name = "simSpeed";
            this.simSpeed.Size = new System.Drawing.Size(104, 23);
            this.simSpeed.SmallChange = 20;
            this.simSpeed.TabIndex = 4;
            this.simSpeed.Value = 200;
            this.simSpeed.ValueChanged += new System.EventHandler(this.simSpeed_ValueChanged);
            // 
            // labelSimSpeed
            // 
            this.labelSimSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSimSpeed.AutoSize = true;
            this.labelSimSpeed.Location = new System.Drawing.Point(202, 58);
            this.labelSimSpeed.Name = "labelSimSpeed";
            this.labelSimSpeed.Size = new System.Drawing.Size(13, 13);
            this.labelSimSpeed.TabIndex = 5;
            this.labelSimSpeed.Text = "0";
            // 
            // buttonReady
            // 
            this.buttonReady.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonReady.Location = new System.Drawing.Point(563, 485);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(75, 23);
            this.buttonReady.TabIndex = 7;
            this.buttonReady.Text = "Ready";
            this.buttonReady.UseVisualStyleBackColor = true;
            this.buttonReady.Click += new System.EventHandler(this.buttonReady_Click);
            // 
            // labelQT
            // 
            this.labelQT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQT.AutoSize = true;
            this.labelQT.Location = new System.Drawing.Point(30, 95);
            this.labelQT.Name = "labelQT";
            this.labelQT.Size = new System.Drawing.Size(79, 13);
            this.labelQT.TabIndex = 6;
            this.labelQT.Text = "Quantum Time:";
            this.labelQT.Visible = false;
            // 
            // numericQT
            // 
            this.numericQT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericQT.Location = new System.Drawing.Point(189, 121);
            this.numericQT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQT.Name = "numericQT";
            this.numericQT.Size = new System.Drawing.Size(40, 20);
            this.numericQT.TabIndex = 7;
            this.numericQT.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericQT.Visible = false;
            this.numericQT.ValueChanged += new System.EventHandler(this.numericQT_ValueChanged);
            // 
            // trackBarQT
            // 
            this.trackBarQT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBarQT.Location = new System.Drawing.Point(157, 90);
            this.trackBarQT.Maximum = 100;
            this.trackBarQT.Minimum = 1;
            this.trackBarQT.Name = "trackBarQT";
            this.trackBarQT.Size = new System.Drawing.Size(104, 23);
            this.trackBarQT.TabIndex = 8;
            this.trackBarQT.Value = 10;
            this.trackBarQT.Visible = false;
            this.trackBarQT.ValueChanged += new System.EventHandler(this.trackBarQT_ValueChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Scheduling Simulator";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processData)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonAddProcess;
        private System.Windows.Forms.DataGridView processGridView;
        private System.Windows.Forms.BindingSource processData;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonDeleteProcess;
        private System.Windows.Forms.Button buttonEditProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel settingsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox algList;
        private System.Windows.Forms.TrackBar simSpeed;
        private System.Windows.Forms.Button buttonReady;
        private System.Windows.Forms.Label labelSimSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn IOProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn IOSwiftness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.Button buttonImportData;
        private System.Windows.Forms.Button clearProcesses;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label labelQT;
        private System.Windows.Forms.NumericUpDown numericQT;
        private System.Windows.Forms.TrackBar trackBarQT;
    }
}

