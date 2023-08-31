using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace wrsrSaveDitorDecompReform
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

        private string hexYearIn;
        private int hexYearOut;
        private int hexValueYearIn;
        private int hexYearMid;
        private string hexValueYearOut;
        private int hexDayOut;
        private int hexValueDayIn;
        private string file;
        private string fileName;
        private Button openFileBtn1;
        private Button saveFileBtn1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private ComboBox comboBoxMonth;
        private Label label7;
        private Label label5;
        private TextBox textBoxMonth;
        private GroupBox groupBox2;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private ProgressBar progressBar1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private Label label18;
        private RadioButton radioButton1Reaction;
        private Panel panel2;
        private RadioButton radioButton3Reaction;
        private RadioButton radioButton2Reaction;
        private Label label16;
        private Label label15;
        private Label label17;
        private Label label14;
        private Label label13;
        private Label label10;
        private Label label12;
        private Label label3;
        private Panel panel3;
        private RadioButton radioButton3Energy;
        private RadioButton radioButton2Energy;
        private RadioButton radioButton1Energy;
        private Panel panel10;
        private RadioButton radioButtonEducation2;
        private RadioButton radioButtonEducation1;
        private Panel panel9;
        private RadioButton radioButtonVehicles2;
        private RadioButton radioButtonVehicles1;
        private Panel panel8;
        private RadioButton radioButtonPollution2;
        private RadioButton radioButtonPollution1;
        private Panel panel7;
        private RadioButton radioButtonEvents2;
        private RadioButton radioButtonEvents1;
        private Panel panel6;
        private RadioButton radioButtonFires3;
        private RadioButton radioButtonFires2;
        private RadioButton radioButtonFires1;
        private Panel panel5;
        private RadioButton radioButtonYear2;
        private RadioButton radioButtonYear1;
        private Panel panel4;
        private RadioButton radioButtonDay2;
        private RadioButton radioButtonDay1;
        private Label label19;
        private Label label20;
        private RadioButton radioButtonDay3;
        private NumericUpDown numericUpDownUSD;
        private NumericUpDown numericUpDownRUB;
        private Button button3;
        private CheckBox checkBox2;
        private GroupBox groupBox4;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileBtn1 = new System.Windows.Forms.Button();
            this.saveFileBtn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDownRUB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUSD = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.radioButtonEducation2 = new System.Windows.Forms.RadioButton();
            this.radioButtonEducation1 = new System.Windows.Forms.RadioButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.radioButtonVehicles2 = new System.Windows.Forms.RadioButton();
            this.radioButtonVehicles1 = new System.Windows.Forms.RadioButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.radioButtonPollution2 = new System.Windows.Forms.RadioButton();
            this.radioButtonPollution1 = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioButtonEvents2 = new System.Windows.Forms.RadioButton();
            this.radioButtonEvents1 = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioButtonFires3 = new System.Windows.Forms.RadioButton();
            this.radioButtonFires2 = new System.Windows.Forms.RadioButton();
            this.radioButtonFires1 = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButtonYear2 = new System.Windows.Forms.RadioButton();
            this.radioButtonYear1 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButtonDay3 = new System.Windows.Forms.RadioButton();
            this.radioButtonDay2 = new System.Windows.Forms.RadioButton();
            this.radioButtonDay1 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton3Energy = new System.Windows.Forms.RadioButton();
            this.radioButton2Energy = new System.Windows.Forms.RadioButton();
            this.radioButton1Energy = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton3Reaction = new System.Windows.Forms.RadioButton();
            this.radioButton2Reaction = new System.Windows.Forms.RadioButton();
            this.radioButton1Reaction = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRUB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUSD)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileBtn1
            // 
            this.openFileBtn1.Location = new System.Drawing.Point(10, 11);
            this.openFileBtn1.Name = "openFileBtn1";
            this.openFileBtn1.Size = new System.Drawing.Size(103, 23);
            this.openFileBtn1.TabIndex = 1;
            this.openFileBtn1.Text = "Open File";
            this.openFileBtn1.UseVisualStyleBackColor = true;
            this.openFileBtn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileBtn1
            // 
            this.saveFileBtn1.Enabled = false;
            this.saveFileBtn1.Location = new System.Drawing.Point(117, 11);
            this.saveFileBtn1.Name = "saveFileBtn1";
            this.saveFileBtn1.Size = new System.Drawing.Size(103, 23);
            this.saveFileBtn1.TabIndex = 1;
            this.saveFileBtn1.Text = "Save File";
            this.saveFileBtn1.UseVisualStyleBackColor = true;
            this.saveFileBtn1.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desired:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Open header.bin";
            // 
            // textBox2
            // 
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox2.Location = new System.Drawing.Point(60, 51);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.MaxLength = 4;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Open header.bin";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "header.bin";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(224, 16);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Reset Economy?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(176, 81);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Year";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(61, 50);
            this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(96, 21);
            this.comboBoxMonth.TabIndex = 3;
            this.comboBoxMonth.Text = "Open header.bin";
            this.comboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Desired:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Current:";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(61, 19);
            this.textBoxMonth.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.ReadOnly = true;
            this.textBoxMonth.Size = new System.Drawing.Size(96, 20);
            this.textBoxMonth.TabIndex = 3;
            this.textBoxMonth.Text = "Open header.bin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.numericUpDownRUB);
            this.groupBox2.Controls.Add(this.numericUpDownUSD);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(4, 172);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(176, 122);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Currency";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(59, 102);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Infinite Money";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 74);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Set Maximum";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDownRUB
            // 
            this.numericUpDownRUB.DecimalPlaces = 4;
            this.numericUpDownRUB.Location = new System.Drawing.Point(60, 51);
            this.numericUpDownRUB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDownRUB.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownRUB.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.numericUpDownRUB.Name = "numericUpDownRUB";
            this.numericUpDownRUB.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownRUB.TabIndex = 7;
            // 
            // numericUpDownUSD
            // 
            this.numericUpDownUSD.DecimalPlaces = 4;
            this.numericUpDownUSD.Location = new System.Drawing.Point(60, 20);
            this.numericUpDownUSD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDownUSD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownUSD.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.numericUpDownUSD.Name = "numericUpDownUSD";
            this.numericUpDownUSD.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownUSD.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "RUB:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "USD:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.saveFileBtn1);
            this.panel1.Controls.Add(this.openFileBtn1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 325);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 43);
            this.panel1.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(332, 16);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(75, 19);
            this.progressBar1.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 325);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(654, 299);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxMonth);
            this.groupBox4.Controls.Add(this.textBoxMonth);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(4, 89);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(176, 81);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Month/Day";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel10);
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Controls.Add(this.panel8);
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(185, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(464, 289);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Properties";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.radioButtonEducation2);
            this.panel10.Controls.Add(this.radioButtonEducation1);
            this.panel10.Location = new System.Drawing.Point(157, 254);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(303, 27);
            this.panel10.TabIndex = 0;
            // 
            // radioButtonEducation2
            // 
            this.radioButtonEducation2.AutoSize = true;
            this.radioButtonEducation2.Location = new System.Drawing.Point(59, 2);
            this.radioButtonEducation2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonEducation2.Name = "radioButtonEducation2";
            this.radioButtonEducation2.Size = new System.Drawing.Size(65, 17);
            this.radioButtonEducation2.TabIndex = 3;
            this.radioButtonEducation2.TabStop = true;
            this.radioButtonEducation2.Text = "Complex";
            this.radioButtonEducation2.UseVisualStyleBackColor = true;
            // 
            // radioButtonEducation1
            // 
            this.radioButtonEducation1.AutoSize = true;
            this.radioButtonEducation1.Location = new System.Drawing.Point(2, 2);
            this.radioButtonEducation1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonEducation1.Name = "radioButtonEducation1";
            this.radioButtonEducation1.Size = new System.Drawing.Size(56, 17);
            this.radioButtonEducation1.TabIndex = 3;
            this.radioButtonEducation1.TabStop = true;
            this.radioButtonEducation1.Text = "Simple";
            this.radioButtonEducation1.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.radioButtonVehicles2);
            this.panel9.Controls.Add(this.radioButtonVehicles1);
            this.panel9.Location = new System.Drawing.Point(157, 224);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(303, 27);
            this.panel9.TabIndex = 0;
            // 
            // radioButtonVehicles2
            // 
            this.radioButtonVehicles2.AutoSize = true;
            this.radioButtonVehicles2.Location = new System.Drawing.Point(59, 2);
            this.radioButtonVehicles2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonVehicles2.Name = "radioButtonVehicles2";
            this.radioButtonVehicles2.Size = new System.Drawing.Size(125, 17);
            this.radioButtonVehicles2.TabIndex = 3;
            this.radioButtonVehicles2.TabStop = true;
            this.radioButtonVehicles2.Text = "Lock According Year";
            this.radioButtonVehicles2.UseVisualStyleBackColor = true;
            // 
            // radioButtonVehicles1
            // 
            this.radioButtonVehicles1.AutoSize = true;
            this.radioButtonVehicles1.Location = new System.Drawing.Point(2, 2);
            this.radioButtonVehicles1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonVehicles1.Name = "radioButtonVehicles1";
            this.radioButtonVehicles1.Size = new System.Drawing.Size(36, 17);
            this.radioButtonVehicles1.TabIndex = 3;
            this.radioButtonVehicles1.TabStop = true;
            this.radioButtonVehicles1.Text = "All";
            this.radioButtonVehicles1.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.radioButtonPollution2);
            this.panel8.Controls.Add(this.radioButtonPollution1);
            this.panel8.Location = new System.Drawing.Point(157, 194);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(303, 27);
            this.panel8.TabIndex = 0;
            // 
            // radioButtonPollution2
            // 
            this.radioButtonPollution2.AutoSize = true;
            this.radioButtonPollution2.Location = new System.Drawing.Point(59, 2);
            this.radioButtonPollution2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonPollution2.Name = "radioButtonPollution2";
            this.radioButtonPollution2.Size = new System.Drawing.Size(58, 17);
            this.radioButtonPollution2.TabIndex = 3;
            this.radioButtonPollution2.TabStop = true;
            this.radioButtonPollution2.Text = "Enable";
            this.radioButtonPollution2.UseVisualStyleBackColor = true;
            // 
            // radioButtonPollution1
            // 
            this.radioButtonPollution1.AutoSize = true;
            this.radioButtonPollution1.Location = new System.Drawing.Point(2, 2);
            this.radioButtonPollution1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonPollution1.Name = "radioButtonPollution1";
            this.radioButtonPollution1.Size = new System.Drawing.Size(60, 17);
            this.radioButtonPollution1.TabIndex = 3;
            this.radioButtonPollution1.TabStop = true;
            this.radioButtonPollution1.Text = "Disable";
            this.radioButtonPollution1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.radioButtonEvents2);
            this.panel7.Controls.Add(this.radioButtonEvents1);
            this.panel7.Location = new System.Drawing.Point(157, 164);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(303, 27);
            this.panel7.TabIndex = 0;
            // 
            // radioButtonEvents2
            // 
            this.radioButtonEvents2.AutoSize = true;
            this.radioButtonEvents2.Location = new System.Drawing.Point(59, 2);
            this.radioButtonEvents2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonEvents2.Name = "radioButtonEvents2";
            this.radioButtonEvents2.Size = new System.Drawing.Size(58, 17);
            this.radioButtonEvents2.TabIndex = 3;
            this.radioButtonEvents2.TabStop = true;
            this.radioButtonEvents2.Text = "Enable";
            this.radioButtonEvents2.UseVisualStyleBackColor = true;
            // 
            // radioButtonEvents1
            // 
            this.radioButtonEvents1.AutoSize = true;
            this.radioButtonEvents1.Location = new System.Drawing.Point(2, 2);
            this.radioButtonEvents1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonEvents1.Name = "radioButtonEvents1";
            this.radioButtonEvents1.Size = new System.Drawing.Size(60, 17);
            this.radioButtonEvents1.TabIndex = 3;
            this.radioButtonEvents1.TabStop = true;
            this.radioButtonEvents1.Text = "Disable";
            this.radioButtonEvents1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.radioButtonFires3);
            this.panel6.Controls.Add(this.radioButtonFires2);
            this.panel6.Controls.Add(this.radioButtonFires1);
            this.panel6.Location = new System.Drawing.Point(157, 134);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(303, 27);
            this.panel6.TabIndex = 0;
            // 
            // radioButtonFires3
            // 
            this.radioButtonFires3.AutoSize = true;
            this.radioButtonFires3.Location = new System.Drawing.Point(148, 2);
            this.radioButtonFires3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonFires3.Name = "radioButtonFires3";
            this.radioButtonFires3.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFires3.TabIndex = 3;
            this.radioButtonFires3.TabStop = true;
            this.radioButtonFires3.Text = "Frequent";
            this.radioButtonFires3.UseVisualStyleBackColor = true;
            // 
            // radioButtonFires2
            // 
            this.radioButtonFires2.AutoSize = true;
            this.radioButtonFires2.Location = new System.Drawing.Point(59, 2);
            this.radioButtonFires2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonFires2.Name = "radioButtonFires2";
            this.radioButtonFires2.Size = new System.Drawing.Size(58, 17);
            this.radioButtonFires2.TabIndex = 3;
            this.radioButtonFires2.TabStop = true;
            this.radioButtonFires2.Text = "Normal";
            this.radioButtonFires2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonFires2.UseVisualStyleBackColor = true;
            // 
            // radioButtonFires1
            // 
            this.radioButtonFires1.AutoSize = true;
            this.radioButtonFires1.Location = new System.Drawing.Point(2, 2);
            this.radioButtonFires1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonFires1.Name = "radioButtonFires1";
            this.radioButtonFires1.Size = new System.Drawing.Size(60, 17);
            this.radioButtonFires1.TabIndex = 3;
            this.radioButtonFires1.TabStop = true;
            this.radioButtonFires1.Text = "Disable";
            this.radioButtonFires1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButtonYear2);
            this.panel5.Controls.Add(this.radioButtonYear1);
            this.panel5.Location = new System.Drawing.Point(157, 104);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(303, 27);
            this.panel5.TabIndex = 0;
            // 
            // radioButtonYear2
            // 
            this.radioButtonYear2.AutoSize = true;
            this.radioButtonYear2.Location = new System.Drawing.Point(59, 2);
            this.radioButtonYear2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonYear2.Name = "radioButtonYear2";
            this.radioButtonYear2.Size = new System.Drawing.Size(58, 17);
            this.radioButtonYear2.TabIndex = 3;
            this.radioButtonYear2.TabStop = true;
            this.radioButtonYear2.Text = "Enable";
            this.radioButtonYear2.UseVisualStyleBackColor = true;
            // 
            // radioButtonYear1
            // 
            this.radioButtonYear1.AutoSize = true;
            this.radioButtonYear1.Location = new System.Drawing.Point(2, 2);
            this.radioButtonYear1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonYear1.Name = "radioButtonYear1";
            this.radioButtonYear1.Size = new System.Drawing.Size(60, 17);
            this.radioButtonYear1.TabIndex = 3;
            this.radioButtonYear1.TabStop = true;
            this.radioButtonYear1.Text = "Disable";
            this.radioButtonYear1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButtonDay3);
            this.panel4.Controls.Add(this.radioButtonDay2);
            this.panel4.Controls.Add(this.radioButtonDay1);
            this.panel4.Location = new System.Drawing.Point(157, 74);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(303, 27);
            this.panel4.TabIndex = 0;
            // 
            // radioButtonDay3
            // 
            this.radioButtonDay3.AutoSize = true;
            this.radioButtonDay3.Location = new System.Drawing.Point(148, 2);
            this.radioButtonDay3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonDay3.Name = "radioButtonDay3";
            this.radioButtonDay3.Size = new System.Drawing.Size(82, 17);
            this.radioButtonDay3.TabIndex = 3;
            this.radioButtonDay3.TabStop = true;
            this.radioButtonDay3.Text = "Moving Sun";
            this.radioButtonDay3.UseVisualStyleBackColor = true;
            // 
            // radioButtonDay2
            // 
            this.radioButtonDay2.AutoSize = true;
            this.radioButtonDay2.Location = new System.Drawing.Point(59, 2);
            this.radioButtonDay2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonDay2.Name = "radioButtonDay2";
            this.radioButtonDay2.Size = new System.Drawing.Size(74, 17);
            this.radioButtonDay2.TabIndex = 3;
            this.radioButtonDay2.TabStop = true;
            this.radioButtonDay2.Text = "Static Sun";
            this.radioButtonDay2.UseVisualStyleBackColor = true;
            // 
            // radioButtonDay1
            // 
            this.radioButtonDay1.AutoSize = true;
            this.radioButtonDay1.Location = new System.Drawing.Point(2, 2);
            this.radioButtonDay1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonDay1.Name = "radioButtonDay1";
            this.radioButtonDay1.Size = new System.Drawing.Size(60, 17);
            this.radioButtonDay1.TabIndex = 3;
            this.radioButtonDay1.TabStop = true;
            this.radioButtonDay1.Text = "Disable";
            this.radioButtonDay1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton3Energy);
            this.panel3.Controls.Add(this.radioButton2Energy);
            this.panel3.Controls.Add(this.radioButton1Energy);
            this.panel3.Location = new System.Drawing.Point(157, 44);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 27);
            this.panel3.TabIndex = 0;
            // 
            // radioButton3Energy
            // 
            this.radioButton3Energy.AutoSize = true;
            this.radioButton3Energy.Location = new System.Drawing.Point(148, 2);
            this.radioButton3Energy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3Energy.Name = "radioButton3Energy";
            this.radioButton3Energy.Size = new System.Drawing.Size(119, 17);
            this.radioButton3Energy.TabIndex = 3;
            this.radioButton3Energy.TabStop = true;
            this.radioButton3Energy.Text = "Buildings + Vehicles";
            this.radioButton3Energy.UseVisualStyleBackColor = true;
            // 
            // radioButton2Energy
            // 
            this.radioButton2Energy.AutoSize = true;
            this.radioButton2Energy.Location = new System.Drawing.Point(59, 2);
            this.radioButton2Energy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2Energy.Name = "radioButton2Energy";
            this.radioButton2Energy.Size = new System.Drawing.Size(91, 17);
            this.radioButton2Energy.TabIndex = 3;
            this.radioButton2Energy.TabStop = true;
            this.radioButton2Energy.Text = "Buildings Only";
            this.radioButton2Energy.UseVisualStyleBackColor = true;
            // 
            // radioButton1Energy
            // 
            this.radioButton1Energy.AutoSize = true;
            this.radioButton1Energy.Location = new System.Drawing.Point(2, 2);
            this.radioButton1Energy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1Energy.Name = "radioButton1Energy";
            this.radioButton1Energy.Size = new System.Drawing.Size(60, 17);
            this.radioButton1Energy.TabIndex = 3;
            this.radioButton1Energy.TabStop = true;
            this.radioButton1Energy.Text = "Disable";
            this.radioButton1Energy.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton3Reaction);
            this.panel2.Controls.Add(this.radioButton2Reaction);
            this.panel2.Controls.Add(this.radioButton1Reaction);
            this.panel2.Location = new System.Drawing.Point(157, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 27);
            this.panel2.TabIndex = 0;
            // 
            // radioButton3Reaction
            // 
            this.radioButton3Reaction.AutoSize = true;
            this.radioButton3Reaction.Location = new System.Drawing.Point(148, 2);
            this.radioButton3Reaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3Reaction.Name = "radioButton3Reaction";
            this.radioButton3Reaction.Size = new System.Drawing.Size(47, 17);
            this.radioButton3Reaction.TabIndex = 3;
            this.radioButton3Reaction.TabStop = true;
            this.radioButton3Reaction.Text = "High";
            this.radioButton3Reaction.UseVisualStyleBackColor = true;
            // 
            // radioButton2Reaction
            // 
            this.radioButton2Reaction.AutoSize = true;
            this.radioButton2Reaction.Location = new System.Drawing.Point(59, 2);
            this.radioButton2Reaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2Reaction.Name = "radioButton2Reaction";
            this.radioButton2Reaction.Size = new System.Drawing.Size(62, 17);
            this.radioButton2Reaction.TabIndex = 3;
            this.radioButton2Reaction.TabStop = true;
            this.radioButton2Reaction.Text = "Medium";
            this.radioButton2Reaction.UseVisualStyleBackColor = true;
            // 
            // radioButton1Reaction
            // 
            this.radioButton1Reaction.AutoSize = true;
            this.radioButton1Reaction.Location = new System.Drawing.Point(2, 2);
            this.radioButton1Reaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1Reaction.Name = "radioButton1Reaction";
            this.radioButton1Reaction.Size = new System.Drawing.Size(45, 17);
            this.radioButton1Reaction.TabIndex = 3;
            this.radioButton1Reaction.TabStop = true;
            this.radioButton1Reaction.Text = "Low";
            this.radioButton1Reaction.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Vehicles Availability:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 258);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Education Simulation:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(76, 198);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Pollution:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Building Fires:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(65, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Year Cycle:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Global Events:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Energy Management:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Night/Day Cycle:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Citizens Reaction:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(654, 299);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Economy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(272, 142);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Coming in future versions!";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label18.Location = new System.Drawing.Point(2, 283);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(650, 14);
            this.label18.TabIndex = 0;
            this.label18.Text = "⚠️Warning - changing this values will overttire your economy and erase your stati" +
    "stics!⚠️";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 368);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "W&R:SR Save Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRUB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUSD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}