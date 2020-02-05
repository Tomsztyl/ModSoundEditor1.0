using ModSoundEditor.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModSoundEditor
{
    public partial class ModSoundEditor : Form
    {
        public ModSoundEditor()
        {
                                                                                                                        /*Script ©Created by Tomsztyl 2020*/
            InitializeComponent();
            //MessageBox.Show(Application.ExecutablePath);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       /* private void StartGG()
        {
            string v1 = System.Configuration.ConfigurationManager.AppSettings["k1"];
            string v2 = System.Configuration.ConfigurationManager.AppSettings["QuickBMS"];
            string v3 = System.Configuration.ConfigurationManager.AppSettings["export"];
            //MessageBox.Show("Welocme" + v1);
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            //StartGG();
            FolderBrowserDialog selectQuickBMS = new FolderBrowserDialog();
            selectQuickBMS.Description = "Select a folder from QuickBMS";
            if (selectQuickBMS.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox1.Text = selectQuickBMS.SelectedPath;
            Settings.Default["MSEQuickBMS"] = textBox1.Text;
            Settings.Default.Save();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                Process.Start(textBox1.Text + "\\quickbms.exe");
                progressBar1.Value = 0;
                progressBar1.Value = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog selectDivinitySoundConvert = new FolderBrowserDialog();
            selectDivinitySoundConvert.Description = "Select a folder from DivinitySoundConvert";
            if (selectDivinitySoundConvert.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox2.Text = selectDivinitySoundConvert.SelectedPath;
            Settings.Default["MSEDivinitySound"] = textBox2.Text;
            Settings.Default.Save();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Process.Start("cmd.exe", "/c "+textBox2.Text+"\\divinity_converter.exe");
            //Process.Start(@"D:\GOG Galaxy\Games\The Witcher 3 Wild Hunt GOTY\bin\x64\witcher3.exe");
            //Process.Start("cmd.exe", "/c D:\\GOG Galaxy\\Games\\The Witcher 3 Wild Hunt GOTY\bin\x64\\witcher3.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Wem File|*.wem|Bnk File|*bnk";
            //openFileDialog1.InitialDirectory = "C:\\Users";
            openFileDialog1.Title = "Open .wem or .bnk files";
            openFileDialog1.ShowDialog();

            textBox3.Text = openFileDialog1.FileName;
            Settings.Default["MSESelectExported"] = textBox3.Text;
            Settings.Default.Save();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c copy "+openFileDialog1.FileName+/*C:\\Przechwytywanie.png*/ " "+textBox2.Text);
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void workplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog workingDirectory = new FolderBrowserDialog();
            workingDirectory.Description = "Choose where to create a working directory:";
            if (workingDirectory.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox4.Text = workingDirectory.SelectedPath;
            Settings.Default["MSEChooseWorkingDirectory"] = textBox4.Text;
            Settings.Default.Save();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c mkdir " + textBox4.Text+ "\\WorkingDirectory");
            Process.Start("cmd.exe", "/c mkdir " + textBox4.Text + "\\WorkingDirectory\\batchesandscripts");
            Process.Start("cmd.exe", "/c mkdir " + textBox4.Text + "\\WorkingDirectory\\DivinitySoundConvert");
            Process.Start("cmd.exe", "/c mkdir " + textBox4.Text + "\\WorkingDirectory\\modded\\merged");
            Process.Start("cmd.exe", "/c mkdir " + textBox4.Text + "\\WorkingDirectory\\DoneMods\\modName\\content");
            Process.Start("cmd.exe", "/c mkdir " + textBox4.Text + "\\WorkingDirectory\\originals\\bnk");
            Process.Start("cmd.exe", "/c mkdir " + textBox4.Text + "\\WorkingDirectory\\originals\\wem");
            Process.Start("cmd.exe", "/c mkdir " + textBox4.Text + "\\WorkingDirectory\\QuickBMS");
            Process.Start("cmd.exe", "/c mkdir " + textBox4.Text + "\\WorkingDirectory\\soundeditor");
            Process.Start("cmd.exe", "/c mkdir " + textBox4.Text + "\\WorkingDirectory\\SoundModification");
            Process.Start("cmd.exe", "/c mkdir " + textBox4.Text + "\\WorkingDirectory\\wwise");
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderWizard = new FolderBrowserDialog();
            folderWizard.Description = "Set or write the folder wizard:";
            if (folderWizard.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox5.Text = folderWizard.SelectedPath;
            Settings.Default["MSESetorWriteWizard"] = textBox5.Text;
            Settings.Default.Save();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c mkdir " + textBox5.Text);
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help form2 = new Help();
            form2.Show();

        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ModSoundEditor form1 = new ModSoundEditor();
           form1.Show();
        }

        private void preparingFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreparingFile form3 = new PreparingFile();
            form3.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;
            }
            else
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
                textBox7.ReadOnly = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Move a file from";
            openFileDialog1.ShowDialog();

            textBox7.Text = openFileDialog1.FileName;
            Settings.Default["MSEMoveFile"] = textBox7.Text;
            Settings.Default.Save();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderMoveFrom = new FolderBrowserDialog();
            folderMoveFrom.Description = "Move a folder from";
            if (folderMoveFrom.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox7.Text = folderMoveFrom.SelectedPath;

            Settings.Default["MSEMoveFile"] = textBox7.Text;
            Settings.Default.Save();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderMoveTo = new FolderBrowserDialog();
            folderMoveTo.Description = "Move a folder or file to";
            if (folderMoveTo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox6.Text = folderMoveTo.SelectedPath;
            Settings.Default["MSEMoveFolder"] = textBox6.Text;
            Settings.Default.Save();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c move /Y " + textBox7.Text + " " + textBox6.Text);
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void ModSoundEditor_Load(object sender, EventArgs e)
        {
            //AllDataConfigAppLoad
            textBox1.Text = Settings.Default["MSEQuickBMS"].ToString();
            textBox2.Text = Settings.Default["MSEDivinitySound"].ToString();
            textBox3.Text = Settings.Default["MSESelectExported"].ToString();
            textBox4.Text = Settings.Default["MSEChooseWorkingDirectory"].ToString();
            textBox5.Text = Settings.Default["MSESetorWriteWizard"].ToString();
            textBox6.Text = Settings.Default["MSEMoveFolder"].ToString();
            textBox7.Text = Settings.Default["MSEMoveFile"].ToString();
        }
    }
}
