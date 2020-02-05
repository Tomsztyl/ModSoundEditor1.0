using ModSoundEditor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModSoundEditor
{
    public partial class PreparingFile : Form
    {
        //public static string ExecutablePath { get; }
        public PreparingFile()
        {
                                                                                                                       /*Script ©Created by Tomsztyl 2020*/
            InitializeComponent();
            //MessageBox.Show(Application.ExecutablePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Py File|*.py";
            //openFileDialog1.InitialDirectory = "C:\\Users";
            openFileDialog1.Title = "Select file compare_wem.py";
            openFileDialog1.ShowDialog();

            textBox1.Text = openFileDialog1.FileName;
            Settings.Default["PFSelectCompareWew"] = textBox1.Text;
            Settings.Default.Save();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("/c " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
            Process.Start("cmd.exe", "/c " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Wem File|*.wem|Bnk File|*bnk";
            //openFileDialog1.InitialDirectory = "C:\\Users";
            openFileDialog1.Title = "Open orginal .wem or .bnk files";
            openFileDialog1.ShowDialog();

            textBox2.Text = openFileDialog1.FileName;
            Settings.Default["PFSelectOrginal"] = textBox2.Text;
            Settings.Default.Save();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Wem File|*.wem|Bnk File|*bnk";
            //openFileDialog1.InitialDirectory = "C:\\Users";
            openFileDialog1.Title = "Open compress .wem or .bnk files";
            openFileDialog1.ShowDialog();

            textBox3.Text = openFileDialog1.FileName;
            Settings.Default["PFSelectPrepareFile"] = textBox3.Text;
            Settings.Default.Save();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Py File|*.py";
            //openFileDialog1.InitialDirectory = "C:\\Users";
            openFileDialog1.Title = "Select file prepare_wave.py";
            openFileDialog1.ShowDialog();

            textBox4.Text = openFileDialog1.FileName;
            Settings.Default["PFPrepareWave"] = textBox4.Text;
            Settings.Default["PFPrepareWaveValue"] = comboBox1.Text;
            Settings.Default.Save();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            char inverted_Commas = '"';
            Process.Start("cmd.exe", "/c " + textBox4.Text + " " + inverted_Commas + textBox5.Text + inverted_Commas+" "+comboBox1.Text);
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "WAV File|*.wav";
            //openFileDialog1.InitialDirectory = "C:\\Users";
            openFileDialog1.Title = "Select file .wav";
            openFileDialog1.ShowDialog();

            textBox5.Text = openFileDialog1.FileName;
            Settings.Default["PFSelectFileWav"] = textBox5.Text;
            Settings.Default.Save();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Py File|*.py";
            //openFileDialog1.InitialDirectory = "C:\\Users";
            openFileDialog1.Title = "Select file create_sounds_cache.py";
            openFileDialog1.ShowDialog();

            textBox6.Text = openFileDialog1.FileName;
            Settings.Default["PFSelectSoundCasche"] = textBox6.Text;
            Settings.Default.Save();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog selectCreate_a_Sound_Cache = new FolderBrowserDialog();
            selectCreate_a_Sound_Cache.Description = "Select a folder to create a sound cache";
            if (selectCreate_a_Sound_Cache.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox7.Text = selectCreate_a_Sound_Cache.SelectedPath;
            Settings.Default["PFDoneFolderCasche"] = textBox7.Text;
            Settings.Default.Save();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            char inverted_Commas = '"';
            
            Process.Start("cmd.exe", "/c"+ textBox6.Text + " " + inverted_Commas + textBox7.Text + inverted_Commas);
            //Process.Start("cmd.exe", "/c move /Y "+textBox6.Text+ "\\soundspc.cache " +textBox7.Text+ "\\soundspc.cache");
            progressBar1.Value = 0;
            progressBar1.Value = 100;
            //ModSoundEditor modSoundEditor = new ModSoundEditor();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
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

        private void PreparingFile_Load(object sender, EventArgs e)
        {
            //AllDataLoadConfigApp
            comboBox1.Text = Settings.Default["PFPrepareWaveValue"].ToString();
            textBox1.Text = Settings.Default["PFSelectCompareWew"].ToString();
            textBox2.Text = Settings.Default["PFSelectOrginal"].ToString();
            textBox3.Text = Settings.Default["PFSelectPrepareFile"].ToString();
            textBox4.Text = Settings.Default["PFPrepareWave"].ToString();
            textBox5.Text = Settings.Default["PFSelectFileWav"].ToString();
            textBox6.Text = Settings.Default["PFSelectSoundCasche"].ToString();
            textBox7.Text = Settings.Default["PFDoneFolderCasche"].ToString();
        }
    }
}
