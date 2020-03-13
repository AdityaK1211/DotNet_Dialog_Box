using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grpup1_ALA_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "File Name: Untitled.txt";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\admin\Desktop\SCET\3rd Year\6 SEM\.NET\ALA\net ala";
            openFileDialog1.Title = "Browse Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();

            string file = openFileDialog1.FileName;
            label1.Text = label1.Text + openFileDialog1.SafeFileName;
            StreamReader sr = new StreamReader(file);
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\Users\admin\Desktop\SCET\3rd Year\6 SEM\.NET\ALA\net ala";
            saveFileDialog1.Title = "Save File";

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.ShowDialog();

            string file = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(file);
            sw.Write(textBox1.Text);
            sw.Close();

            MessageBox.Show("File saved successfully!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Orange;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Yellow;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void indigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Indigo;
        }

        private void violetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Violet;
        }

        private void moreColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            colorDialog1.AllowFullOpen = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        
    }
}
