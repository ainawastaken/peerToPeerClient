using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace wrsrSaveDitorDecompReform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "|header.bin";
            saveFileDialog1.Filter = "|header.bin";
            numericUpDownUSD.Controls[0].Visible = false;
            numericUpDownRUB.Controls[0].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            this.file = this.openFileDialog1.FileName;
            this.fileName = Path.GetFileName(Path.GetDirectoryName(this.openFileDialog1.FileName)) + "/" + Path.GetFileName(this.openFileDialog1.FileName);
            try
            {
                BinaryReader binaryReader = new BinaryReader((Stream)new FileStream(this.openFileDialog1.FileName, FileMode.Open));
                binaryReader.BaseStream.Position = 412L;
                this.hexYearIn = BitConverter.ToString(binaryReader.ReadBytes(2)).Replace("-", (string)null);
                binaryReader.Close();
                this.hexValueYearIn = Convert.ToInt32(this.hexYearIn.Remove(0, 2) + this.hexYearIn.Remove(2, 2), 16);
                this.textBox1.Text = this.textBox2.Text = this.hexValueYearIn.ToString();
                this.saveFileBtn1.Enabled = true;
                this.button3.Enabled = true;
                this.groupBox1.Enabled = true;
                this.groupBox2.Enabled = true;
                this.groupBox3.Enabled = true;
                this.groupBox4.Enabled = true;
                this.checkBox1.Enabled = true;
                this.Text = "W&R:SR Save Editor: " + this.fileName;
                this.progressBar1.Value = 5;
            }
            catch
            {
                int num = (int)MessageBox.Show("Sorry the application seems to have encountered a problem at reading year stage", "Error");
            }
            try
            {
                BinaryReader binaryReader = new BinaryReader((Stream)new FileStream(this.openFileDialog1.FileName, FileMode.Open));
                binaryReader.BaseStream.Position = 408L;
                string str = BitConverter.ToString(binaryReader.ReadBytes(2)).Replace("-", (string)null);
                binaryReader.Close();
                this.hexValueDayIn = Convert.ToInt32(str.Remove(0, 2) + str.Remove(2, 2), 16);
                this.comboBoxMonth.DisplayMember = "Text";
                this.comboBoxMonth.ValueMember = "Value";
                this.comboBoxMonth.DataSource = new[] {
                    new {
                        Text = "January", Value = 0
                    },
                    new {
                        Text = "February", Value = 32
                    },
                    new {
                        Text = "March", Value = 60
                    },
                    new {
                        Text = "April", Value = 91
                    },
                    new {
                        Text = "May", Value = 121
                    },
                    new {
                        Text = "June", Value = 152
                    },
                    new {
                        Text = "July", Value = 182
                    },
                    new {
                        Text = "August", Value = 213
                    },
                    new {
                        Text = "September", Value = 244
                    },
                    new {
                        Text = "October", Value = 289
                    },
                    new {
                        Text = "November", Value = 305
                    },
                    new {
                        Text = "December", Value = 335
                    }
                };
                int hexValueDayIn1 = this.hexValueDayIn;
                if (hexValueDayIn1 >= 0 && hexValueDayIn1 <= 31)
                {
                    this.textBoxMonth.Text = "January";
                    this.comboBoxMonth.SelectedIndex = 0;
                }
                else
                {
                    int hexValueDayIn2 = this.hexValueDayIn;
                    if (hexValueDayIn2 >= 32 && hexValueDayIn2 <= 59)
                    {
                        this.textBoxMonth.Text = "February";
                        this.comboBoxMonth.SelectedIndex = 1;
                    }
                    else
                    {
                        int hexValueDayIn3 = this.hexValueDayIn;
                        if (hexValueDayIn3 >= 60 && hexValueDayIn3 <= 90)
                        {
                            this.textBoxMonth.Text = "March";
                            this.comboBoxMonth.SelectedIndex = 2;
                        }
                        else
                        {
                            int hexValueDayIn4 = this.hexValueDayIn;
                            if (hexValueDayIn4 >= 91 && hexValueDayIn4 <= 120)
                            {
                                this.textBoxMonth.Text = "April";
                                this.comboBoxMonth.SelectedIndex = 3;
                            }
                            else
                            {
                                int hexValueDayIn5 = this.hexValueDayIn;
                                if (hexValueDayIn5 >= 121 && hexValueDayIn5 <= 151)
                                {
                                    this.textBoxMonth.Text = "May";
                                    this.comboBoxMonth.SelectedIndex = 4;
                                }
                                else
                                {
                                    int hexValueDayIn6 = this.hexValueDayIn;
                                    if (hexValueDayIn6 >= 152 && hexValueDayIn6 <= 181)
                                    {
                                        this.textBoxMonth.Text = "June";
                                        this.comboBoxMonth.SelectedIndex = 5;
                                    }
                                    else
                                    {
                                        int hexValueDayIn7 = this.hexValueDayIn;
                                        if (hexValueDayIn7 >= 182 && hexValueDayIn7 <= 212)
                                        {
                                            this.textBoxMonth.Text = "July";
                                            this.comboBoxMonth.SelectedIndex = 6;
                                        }
                                        else
                                        {
                                            int hexValueDayIn8 = this.hexValueDayIn;
                                            if (hexValueDayIn8 >= 213 && hexValueDayIn8 <= 243)
                                            {
                                                this.textBoxMonth.Text = "August";
                                                this.comboBoxMonth.SelectedIndex = 7;
                                            }
                                            else
                                            {
                                                int hexValueDayIn9 = this.hexValueDayIn;
                                                if (hexValueDayIn9 >= 244 && hexValueDayIn9 <= 273)
                                                {
                                                    this.textBoxMonth.Text = "September";
                                                    this.comboBoxMonth.SelectedIndex = 8;
                                                }
                                                else
                                                {
                                                    int hexValueDayIn10 = this.hexValueDayIn;
                                                    if (hexValueDayIn10 >= 274 && hexValueDayIn10 <= 304)
                                                    {
                                                        this.textBoxMonth.Text = "October";
                                                        this.comboBoxMonth.SelectedIndex = 9;
                                                    }
                                                    else
                                                    {
                                                        int hexValueDayIn11 = this.hexValueDayIn;
                                                        if (hexValueDayIn11 >= 305 && hexValueDayIn11 <= 355)
                                                        {
                                                            this.textBoxMonth.Text = "November";
                                                            this.comboBoxMonth.SelectedIndex = 10;
                                                        }
                                                        else
                                                        {
                                                            int hexValueDayIn12 = this.hexValueDayIn;
                                                            if (hexValueDayIn12 >= 335)
                                                            {
                                                                if (hexValueDayIn12 <= 355)
                                                                {
                                                                    this.textBoxMonth.Text = "December";
                                                                    this.comboBoxMonth.SelectedIndex = 11;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                int num = (int)MessageBox.Show("Sorry the application seems to have encountered a problem at reading month stage", "Error");
            }
            try
            {
                BinaryReader binaryReader1 = new BinaryReader((Stream)new FileStream(this.openFileDialog1.FileName, FileMode.Open));
                binaryReader1.BaseStream.Position = 396L;
                string str = BitConverter.ToString(binaryReader1.ReadBytes(1)).Replace("-", (string)null);
                double num1 = (double)binaryReader1.ReadSingle();
                binaryReader1.Close();
                if (str == "01")
                {
                    this.checkBox2.Checked = true;
                    this.checkBox2.Enabled = true;
                    this.numericUpDownRUB.Enabled = false;
                    this.numericUpDownUSD.Enabled = false;
                    this.button3.Enabled = false;
                    this.numericUpDownRUB.Value = 0M;
                    this.numericUpDownUSD.Value = 0M;
                }
                else
                {
                    BinaryReader binaryReader2 = new BinaryReader((Stream)new FileStream(this.openFileDialog1.FileName, FileMode.Open));
                    binaryReader2.BaseStream.Position = 388L;
                    float num2 = binaryReader2.ReadSingle();
                    binaryReader2.Close();
                    this.numericUpDownUSD.Value = (Decimal)Convert.ToInt32(num2);
                    this.progressBar1.Value = 10;
                    BinaryReader binaryReader3 = new BinaryReader((Stream)new FileStream(this.openFileDialog1.FileName, FileMode.Open));
                    binaryReader3.BaseStream.Position = 392L;
                    float num3 = binaryReader3.ReadSingle();
                    binaryReader3.Close();
                    this.numericUpDownRUB.Value = (Decimal)Convert.ToInt32(num3);
                    this.progressBar1.Value = 15;
                }
                this.progressBar1.Value = 10;
            }
            catch
            {
                int num = (int)MessageBox.Show("Sorry the application seems to have encountered a problem at reading currency stage", "Error");
            }
            try
            {
                BinaryReader binaryReader4 = new BinaryReader((Stream)new FileStream(this.openFileDialog1.FileName, FileMode.Open));
                binaryReader4.BaseStream.Position = 404L;
                string str1 = BitConverter.ToString(binaryReader4.ReadBytes(1)).Replace("-", (string)null);
                double num4 = (double)binaryReader4.ReadSingle();
                binaryReader4.Close();
                if (str1 == "00")
                    this.radioButton1Reaction.Checked = true;
                else if (str1 == "01")
                    this.radioButton2Reaction.Checked = true;
                else if (str1 == "02")
                    this.radioButton3Reaction.Checked = true;
                this.progressBar1.Value = 20;
                BinaryReader binaryReader5 = new BinaryReader((Stream)new FileStream(this.openFileDialog1.FileName, FileMode.Open));
                binaryReader5.BaseStream.Position = 400L;
                string str2 = BitConverter.ToString(binaryReader5.ReadBytes(1)).Replace("-", (string)null);
                double num5 = (double)binaryReader5.ReadSingle();
                binaryReader5.Close();
                if (str2 == "00")
                    this.radioButton1Energy.Checked = true;
                else if (str2 == "01")
                    this.radioButton2Energy.Checked = true;
                else if (str2 == "02")
                    this.radioButton3Energy.Checked = true;
                this.progressBar1.Value = 25;
                BinaryReader binaryReader6 = new BinaryReader((Stream)new FileStream(this.openFileDialog1.FileName, FileMode.Open));
                binaryReader6.BaseStream.Position = 444L;
                string str3 = BitConverter.ToString(binaryReader6.ReadBytes(1)).Replace("-", (string)null);
                double num6 = (double)binaryReader6.ReadSingle();
                binaryReader6.Close();
                if (str3 == "00")
                    this.radioButtonDay1.Checked = true;
                else if (str3 == "01")
                    this.radioButtonDay2.Checked = true;
                else if (str3 == "02")
                    this.radioButtonDay3.Checked = true;
                this.progressBar1.Value = 35;
                BinaryReader binaryReader7 = new BinaryReader((Stream)new FileStream(this.openFileDialog1.FileName, FileMode.Open));
                binaryReader7.BaseStream.Position = 448L;
                string str4 = BitConverter.ToString(binaryReader7.ReadBytes(1)).Replace("-", (string)null);
                double num7 = (double)binaryReader7.ReadSingle();
                binaryReader7.Close();
                if (str4 == "00")
                    this.radioButtonYear1.Checked = true;
                else if (str4 == "01")
                    this.radioButtonYear2.Checked = true;
                this.progressBar1.Value = 45;
                BinaryReader binaryReader8 = new BinaryReader((Stream)new FileStream(this.openFileDialog1.FileName, FileMode.Open));
                binaryReader8.BaseStream.Position = 456L;
                string str5 = BitConverter.ToString(binaryReader8.ReadBytes(1)).Replace("-", (string)null);
                double num8 = (double)binaryReader8.ReadSingle();
                binaryReader8.Close();
                if (str5 == "00")
                    this.radioButtonFires1.Checked = true;
                else if (str5 == "01")
                    this.radioButtonFires2.Checked = true;
                else if (str5 == "02")
                    this.radioButtonFires3.Checked = true;
                this.progressBar1.Value = 60;
                BinaryReader binaryReader9 = new BinaryReader((Stream)new FileStream(this.openFileDialog1.FileName, FileMode.Open));
                binaryReader9.BaseStream.Position = 452L;
                string str6 = BitConverter.ToString(binaryReader9.ReadBytes(1)).Replace("-", (string)null);
                double num9 = (double)binaryReader9.ReadSingle();
                binaryReader9.Close();
                if (str6 == "00")
                    this.radioButtonEvents1.Checked = true;
                else if (str6 == "01")
                    this.radioButtonEvents2.Checked = true;
                this.progressBar1.Value = 70;
                BinaryReader binaryReader10 = new BinaryReader((Stream)new FileStream(this.openFileDialog1.FileName, FileMode.Open));
                binaryReader10.BaseStream.Position = 460L;
                string str7 = BitConverter.ToString(binaryReader10.ReadBytes(1)).Replace("-", (string)null);
                double num10 = (double)binaryReader10.ReadSingle();
                binaryReader10.Close();
                if (str7 == "00")
                    this.radioButtonPollution1.Checked = true;
                else if (str7 == "01")
                    this.radioButtonPollution2.Checked = true;
                this.progressBar1.Value = 80;
                BinaryReader binaryReader11 = new BinaryReader((Stream)new FileStream(this.openFileDialog1.FileName, FileMode.Open));
                binaryReader11.BaseStream.Position = 464L;
                string str8 = BitConverter.ToString(binaryReader11.ReadBytes(1)).Replace("-", (string)null);
                double num11 = (double)binaryReader11.ReadSingle();
                binaryReader11.Close();
                if (str8 == "00")
                    this.radioButtonVehicles1.Checked = true;
                else if (str8 == "01")
                    this.radioButtonVehicles2.Checked = true;
                this.progressBar1.Value = 90;
                BinaryReader binaryReader12 = new BinaryReader((Stream)new FileStream(this.openFileDialog1.FileName, FileMode.Open));
                binaryReader12.BaseStream.Position = 468L;
                string str9 = BitConverter.ToString(binaryReader12.ReadBytes(1)).Replace("-", (string)null);
                double num12 = (double)binaryReader12.ReadSingle();
                binaryReader12.Close();
                if (str9 == "01")
                    this.radioButtonEducation1.Checked = true;
                else if (str9 == "00")
                    this.radioButtonEducation2.Checked = true;
                this.progressBar1.Value = 100;
            }
            catch
            {
                int num = (int)MessageBox.Show("Sorry the application seems to have encountered a problem at reading parameters stage", "Error");
            }
        }
        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                if (MessageBox.Show("Are you sure you want to erase your statistics and reset economy?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        string sourceFileName = this.file.Substring(0, this.file.Length - 10) + "stats.ini";
                        string destFileName = Path.Combine(sourceFileName + "_backup_" + DateTime.Now.ToString("MM_dd_yyyy-hh_mm_ss"));
                        File.Move(sourceFileName, destFileName);
                    }
                    catch { }
                }
                else
                {
                    int num = (int)MessageBox.Show("Saving was canceled", "Canceled");
                    return;
                }
            }
            Path.GetFileName(this.openFileDialog1.FileName);
            File.Copy(this.openFileDialog1.FileName, Path.Combine(this.openFileDialog1.FileName + "_backup_" + DateTime.Now.ToString("MM_dd_yyyy-hh_mm_ss")), true);
            try
            {
                string sourceFileName = this.file.Substring(0, this.file.Length - 10) + "stats.ini";
                string destFileName = Path.Combine(sourceFileName + "_backup_" + DateTime.Now.ToString("MM_dd_yyyy-hh_mm_ss"));
                File.Copy(sourceFileName, destFileName, true);
            }
            catch { }
            try
            {
                if (this.textBox2.Text.Length == 4)
                {
                    this.hexYearMid = Convert.ToInt32(this.textBox2.Text);
                    this.hexValueYearOut = string.Format("{0:X4}", (object)this.hexYearMid);
                    string str = Convert.ToString(this.hexValueYearOut).Remove(0, 2);
                    this.hexYearOut = Convert.ToInt32(Convert.ToString(this.hexValueYearOut).Remove(2, 2) + str, 16);
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)new FileStream(this.file, FileMode.Open));
                    binaryWriter.BaseStream.Position = 412L;
                    binaryWriter.Write(this.hexYearOut);
                    binaryWriter.Close();
                    if (this.checkBox1.Checked)
                        File.Delete(this.file.Substring(0, this.file.Length - 10) + "stats.ini");
                }
                else
                {
                    int num = (int)MessageBox.Show("Wrong year, please try again", "Error");
                }
            }
            catch
            {
                int num = (int)MessageBox.Show("Sorry the application seems to have encountered a problem when saving year", "Error");
            }
            try
            {
                this.hexDayOut = int.Parse(this.comboBoxMonth.SelectedValue.ToString());
                BinaryWriter binaryWriter = new BinaryWriter((Stream)new FileStream(this.file, FileMode.Open));
                binaryWriter.BaseStream.Position = 408L;
                binaryWriter.Write(this.hexDayOut);
                binaryWriter.Close();
            }
            catch
            {
                int num = (int)MessageBox.Show("Sorry the application seems to have encountered a problem when saving month", "Error");
            }
            try
            {
                if (this.checkBox2.Checked)
                {
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)new FileStream(this.file, FileMode.Open));
                    binaryWriter.BaseStream.Position = 396L;
                    binaryWriter.Write(1);
                    binaryWriter.Close();
                }
                else
                {
                    float num1 = (float)this.numericUpDownUSD.Value;
                    BinaryWriter binaryWriter1 = new BinaryWriter((Stream)new FileStream(this.file, FileMode.Open));
                    binaryWriter1.BaseStream.Position = 388L;
                    binaryWriter1.Write(num1);
                    binaryWriter1.Close();
                    float num2 = (float)this.numericUpDownRUB.Value;
                    BinaryWriter binaryWriter2 = new BinaryWriter((Stream)new FileStream(this.file, FileMode.Open));
                    binaryWriter2.BaseStream.Position = 392L;
                    binaryWriter2.Write(num2);
                    binaryWriter2.Close();
                    BinaryWriter binaryWriter3 = new BinaryWriter((Stream)new FileStream(this.file, FileMode.Open));
                    binaryWriter3.BaseStream.Position = 396L;
                    binaryWriter3.Write(0);
                    binaryWriter3.Close();
                }
            }
            catch
            {
                int num = (int)MessageBox.Show("Sorry the application seems to have encountered a problem when saving currency. int32 overflow", "Error");
            }
            try
            {
                int num3 = 1;
                if (this.radioButton1Reaction.Checked)
                    num3 = 0;
                else if (this.radioButton2Reaction.Checked)
                    num3 = 1;
                else if (this.radioButton3Reaction.Checked)
                    num3 = 2;
                BinaryWriter binaryWriter4 = new BinaryWriter((Stream)new FileStream(this.file, FileMode.Open));
                binaryWriter4.BaseStream.Position = 404L;
                binaryWriter4.Write(num3);
                binaryWriter4.Close();
                int num4 = 1;
                if (this.radioButton1Energy.Checked)
                    num4 = 0;
                else if (this.radioButton2Energy.Checked)
                    num4 = 1;
                else if (this.radioButton3Energy.Checked)
                    num4 = 2;
                BinaryWriter binaryWriter5 = new BinaryWriter((Stream)new FileStream(this.file, FileMode.Open));
                binaryWriter5.BaseStream.Position = 400L;
                binaryWriter5.Write(num4);
                binaryWriter5.Close();
                int num5 = 1;
                if (this.radioButtonDay1.Checked)
                    num5 = 0;
                else if (this.radioButtonDay2.Checked)
                    num5 = 1;
                else if (this.radioButtonDay3.Checked)
                    num5 = 2;
                BinaryWriter binaryWriter6 = new BinaryWriter((Stream)new FileStream(this.file, FileMode.Open));
                binaryWriter6.BaseStream.Position = 444L;
                binaryWriter6.Write(num5);
                binaryWriter6.Close();
                int num6 = 1;
                if (this.radioButtonYear1.Checked)
                    num6 = 0;
                else if (this.radioButtonYear2.Checked)
                    num6 = 1;
                BinaryWriter binaryWriter7 = new BinaryWriter((Stream)new FileStream(this.file, FileMode.Open));
                binaryWriter7.BaseStream.Position = 448L;
                binaryWriter7.Write(num6);
                binaryWriter7.Close();
                int num7 = 1;
                if (this.radioButtonFires1.Checked)
                    num7 = 0;
                else if (this.radioButtonFires2.Checked)
                    num7 = 1;
                else if (this.radioButtonFires3.Checked)
                    num7 = 2;
                BinaryWriter binaryWriter8 = new BinaryWriter((Stream)new FileStream(this.file, FileMode.Open));
                binaryWriter8.BaseStream.Position = 456L;
                binaryWriter8.Write(num7);
                binaryWriter8.Close();
                int num8 = 1;
                if (this.radioButtonEvents1.Checked)
                    num8 = 0;
                else if (this.radioButtonEvents2.Checked)
                    num8 = 1;
                BinaryWriter binaryWriter9 = new BinaryWriter((Stream)new FileStream(this.file, FileMode.Open));
                binaryWriter9.BaseStream.Position = 452L;
                binaryWriter9.Write(num8);
                binaryWriter9.Close();
                int num9 = 1;
                if (this.radioButtonPollution1.Checked)
                    num9 = 0;
                else if (this.radioButtonPollution2.Checked)
                    num9 = 1;
                BinaryWriter binaryWriter10 = new BinaryWriter((Stream)new FileStream(this.file, FileMode.Open));
                binaryWriter10.BaseStream.Position = 460L;
                binaryWriter10.Write(num9);
                binaryWriter10.Close();
                int num10 = 1;
                if (this.radioButtonVehicles1.Checked)
                    num10 = 0;
                else if (this.radioButtonVehicles2.Checked)
                    num10 = 1;
                BinaryWriter binaryWriter11 = new BinaryWriter((Stream)new FileStream(this.file, FileMode.Open));
                binaryWriter11.BaseStream.Position = 464L;
                binaryWriter11.Write(num10);
                binaryWriter11.Close();
                int num11 = 1;
                if (this.radioButtonEducation1.Checked)
                    num11 = 1;
                else if (this.radioButtonEducation2.Checked)
                    num11 = 0;
                BinaryWriter binaryWriter12 = new BinaryWriter((Stream)new FileStream(this.file, FileMode.Open));
                binaryWriter12.BaseStream.Position = 468L;
                binaryWriter12.Write(num11);
                binaryWriter12.Close();
                int num12 = (int)MessageBox.Show("All changes saved", "Completed");
            }
            catch
            {
                int num = (int)MessageBox.Show("Sorry the application seems to have encountered a problem when saving parameters", "Error");
            }
        }
        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e) => this.groupBox4.Text = "Month/Day: " + this.comboBoxMonth.SelectedValue.ToString();
        private void button3_Click(object sender, EventArgs e)
        {
            this.numericUpDownRUB.Value = 900000000M;
            this.numericUpDownUSD.Value = 900000000M;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.numericUpDownRUB.Enabled = false;
                this.numericUpDownUSD.Enabled = false;
                this.button3.Enabled = false;
                this.numericUpDownRUB.Value = 0M;
                this.numericUpDownUSD.Value = 0M;
            }
            else
            {
                this.numericUpDownRUB.Enabled = true;
                this.numericUpDownUSD.Enabled = true;
                this.button3.Enabled = true;
            }
        }
    }
}