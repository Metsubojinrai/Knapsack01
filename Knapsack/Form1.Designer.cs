namespace Knapsack
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkSave = new System.Windows.Forms.CheckBox();
            this.btnRefresh1 = new System.Windows.Forms.Button();
            this.btnData1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItem2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnStartDP = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaxWeight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNoItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaxWeight2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoItems = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnData2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numCross = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numMutate = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numPop = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numGeneration = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.lbGeneration = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbBestSolution = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvPopulation = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGeneration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopulation)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 591);
            this.tabControl1.TabIndex = 42;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkSave);
            this.tabPage1.Controls.Add(this.btnRefresh1);
            this.tabPage1.Controls.Add(this.btnData1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.btnStartDP);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dynamic Programing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkSave
            // 
            this.chkSave.AutoSize = true;
            this.chkSave.Location = new System.Drawing.Point(29, 127);
            this.chkSave.Name = "chkSave";
            this.chkSave.Size = new System.Drawing.Size(79, 17);
            this.chkSave.TabIndex = 43;
            this.chkSave.Text = "Save to file";
            this.chkSave.UseVisualStyleBackColor = true;
            // 
            // btnRefresh1
            // 
            this.btnRefresh1.Enabled = false;
            this.btnRefresh1.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnRefresh1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh1.Location = new System.Drawing.Point(29, 268);
            this.btnRefresh1.Name = "btnRefresh1";
            this.btnRefresh1.Size = new System.Drawing.Size(107, 35);
            this.btnRefresh1.TabIndex = 42;
            this.btnRefresh1.Text = "Refresh";
            this.btnRefresh1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRefresh1.UseVisualStyleBackColor = true;
            this.btnRefresh1.Click += new System.EventHandler(this.btnRefresh1_Click);
            // 
            // btnData1
            // 
            this.btnData1.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnData1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnData1.Location = new System.Drawing.Point(29, 163);
            this.btnData1.Name = "btnData1";
            this.btnData1.Size = new System.Drawing.Size(107, 35);
            this.btnData1.TabIndex = 41;
            this.btnData1.Text = "Data";
            this.btnData1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnData1.UseVisualStyleBackColor = true;
            this.btnData1.Click += new System.EventHandler(this.btnData1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.Location = new System.Drawing.Point(206, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.Size = new System.Drawing.Size(562, 520);
            this.dataGridView1.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaxValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtItem2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 164);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(6, 133);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(163, 20);
            this.txtTime.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time ";
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(3, 85);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(163, 20);
            this.txtMaxValue.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Max value";
            // 
            // txtItem2
            // 
            this.txtItem2.Location = new System.Drawing.Point(3, 34);
            this.txtItem2.Name = "txtItem2";
            this.txtItem2.Size = new System.Drawing.Size(163, 20);
            this.txtItem2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Items";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Item set";
            // 
            // btnStartDP
            // 
            this.btnStartDP.Enabled = false;
            this.btnStartDP.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnStartDP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartDP.Location = new System.Drawing.Point(29, 217);
            this.btnStartDP.Name = "btnStartDP";
            this.btnStartDP.Size = new System.Drawing.Size(107, 35);
            this.btnStartDP.TabIndex = 29;
            this.btnStartDP.Text = "Start";
            this.btnStartDP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStartDP.UseVisualStyleBackColor = true;
            this.btnStartDP.Click += new System.EventHandler(this.btnStartDP_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMaxWeight);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtNoItem);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 115);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Knapsack";
            // 
            // txtMaxWeight
            // 
            this.txtMaxWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxWeight.Location = new System.Drawing.Point(3, 85);
            this.txtMaxWeight.Name = "txtMaxWeight";
            this.txtMaxWeight.Size = new System.Drawing.Size(163, 20);
            this.txtMaxWeight.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Max weight";
            // 
            // txtNoItem
            // 
            this.txtNoItem.Location = new System.Drawing.Point(3, 34);
            this.txtNoItem.Name = "txtNoItem";
            this.txtNoItem.Size = new System.Drawing.Size(163, 20);
            this.txtNoItem.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Item Amount";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Genetic Algorithms";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnRefresh2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnData2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.lbGeneration);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lbBestSolution);
            this.panel1.Controls.Add(this.btnFinish);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 559);
            this.panel1.TabIndex = 41;
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(424, 535);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(26, 13);
            this.lbTime.TabIndex = 44;
            this.lbTime.Text = "time";
            this.lbTime.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(380, 535);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Item set";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvPopulation);
            this.panel2.Controls.Add(this.dgvItem);
            this.panel2.Location = new System.Drawing.Point(202, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 228);
            this.panel2.TabIndex = 42;
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvItem.Location = new System.Drawing.Point(0, 0);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvItem.Size = new System.Drawing.Size(282, 228);
            this.dgvItem.TabIndex = 40;
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.Enabled = false;
            this.btnRefresh2.ForeColor = System.Drawing.Color.Blue;
            this.btnRefresh2.Location = new System.Drawing.Point(35, 424);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(109, 37);
            this.btnRefresh2.TabIndex = 41;
            this.btnRefresh2.Text = "Refresh";
            this.btnRefresh2.UseVisualStyleBackColor = true;
            this.btnRefresh2.Click += new System.EventHandler(this.btnRefresh2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaxWeight2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNoItems);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(3, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 115);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Knapsack";
            // 
            // txtMaxWeight2
            // 
            this.txtMaxWeight2.Location = new System.Drawing.Point(3, 85);
            this.txtMaxWeight2.Name = "txtMaxWeight2";
            this.txtMaxWeight2.Size = new System.Drawing.Size(163, 20);
            this.txtMaxWeight2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Max weight";
            // 
            // txtNoItems
            // 
            this.txtNoItems.Location = new System.Drawing.Point(3, 34);
            this.txtNoItems.Name = "txtNoItems";
            this.txtNoItems.Size = new System.Drawing.Size(163, 20);
            this.txtNoItems.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Item Amount";
            // 
            // btnData2
            // 
            this.btnData2.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnData2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnData2.Location = new System.Drawing.Point(36, 376);
            this.btnData2.Name = "btnData2";
            this.btnData2.Size = new System.Drawing.Size(107, 35);
            this.btnData2.TabIndex = 24;
            this.btnData2.Text = "Data";
            this.btnData2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnData2.UseVisualStyleBackColor = true;
            this.btnData2.Click += new System.EventHandler(this.btnData2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(499, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Initial population";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numCross);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.numMutate);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.numPop);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.numGeneration);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(3, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 220);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parameters";
            // 
            // numCross
            // 
            this.numCross.DecimalPlaces = 2;
            this.numCross.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numCross.Location = new System.Drawing.Point(2, 136);
            this.numCross.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCross.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            131072});
            this.numCross.Name = "numCross";
            this.numCross.Size = new System.Drawing.Size(163, 20);
            this.numCross.TabIndex = 6;
            this.numCross.Value = new decimal(new int[] {
            80,
            0,
            0,
            131072});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Crossover ";
            // 
            // numMutate
            // 
            this.numMutate.DecimalPlaces = 2;
            this.numMutate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numMutate.Location = new System.Drawing.Point(3, 184);
            this.numMutate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMutate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numMutate.Name = "numMutate";
            this.numMutate.Size = new System.Drawing.Size(163, 20);
            this.numMutate.TabIndex = 4;
            this.numMutate.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mutation  ";
            // 
            // numPop
            // 
            this.numPop.Location = new System.Drawing.Point(3, 91);
            this.numPop.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPop.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPop.Name = "numPop";
            this.numPop.Size = new System.Drawing.Size(163, 20);
            this.numPop.TabIndex = 2;
            this.numPop.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Popultion Size (>1)";
            // 
            // numGeneration
            // 
            this.numGeneration.Location = new System.Drawing.Point(3, 36);
            this.numGeneration.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numGeneration.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numGeneration.Name = "numGeneration";
            this.numGeneration.Size = new System.Drawing.Size(163, 20);
            this.numGeneration.TabIndex = 1;
            this.numGeneration.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Generations limit (>1)";
            // 
            // lbGeneration
            // 
            this.lbGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGeneration.AutoSize = true;
            this.lbGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeneration.Location = new System.Drawing.Point(607, 266);
            this.lbGeneration.Name = "lbGeneration";
            this.lbGeneration.Size = new System.Drawing.Size(14, 13);
            this.lbGeneration.TabIndex = 31;
            this.lbGeneration.Text = "0";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(504, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Current generation:";
            // 
            // lbBestSolution
            // 
            this.lbBestSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBestSolution.AutoSize = true;
            this.lbBestSolution.Location = new System.Drawing.Point(480, 511);
            this.lbBestSolution.Name = "lbBestSolution";
            this.lbBestSolution.Size = new System.Drawing.Size(66, 13);
            this.lbBestSolution.TabIndex = 37;
            this.lbBestSolution.Text = "best solution";
            this.lbBestSolution.Visible = false;
            // 
            // btnFinish
            // 
            this.btnFinish.Enabled = false;
            this.btnFinish.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnFinish.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinish.Location = new System.Drawing.Point(35, 469);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(108, 35);
            this.btnFinish.TabIndex = 33;
            this.btnFinish.Text = "Final solution";
            this.btnFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(380, 511);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Best solution:";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(321, 296);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(335, 208);
            this.chart1.TabIndex = 45;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // dgvPopulation
            // 
            this.dgvPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPopulation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopulation.Location = new System.Drawing.Point(305, 0);
            this.dgvPopulation.Name = "dgvPopulation";
            this.dgvPopulation.Size = new System.Drawing.Size(258, 228);
            this.dgvPopulation.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 591);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGeneration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopulation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkSave;
        private System.Windows.Forms.Button btnRefresh1;
        private System.Windows.Forms.Button btnData1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItem2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnStartDP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaxWeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNoItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.Button btnRefresh2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaxWeight2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnData2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numCross;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numMutate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numPop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numGeneration;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbGeneration;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbBestSolution;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dgvPopulation;
    }
}

