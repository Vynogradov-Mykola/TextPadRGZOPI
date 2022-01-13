﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace TextPad
{
    public partial class blank : Form
    {
       
        public blank(int a)
        {
            InitializeComponent();
            Language = a;
            SetL(Language);
            Time.Text = Convert.ToString(System.DateTime.Now.ToLongTimeString());

            Time.ToolTipText = Convert.ToString(System.DateTime.Today.ToLongDateString());

        }
        public string DocName = "";
        private string BufferText = "";
        public bool IsSaved = false;
        public void Cut()
        {
            this.BufferText = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }
        public void Copy()
        {
            this.BufferText = richTextBox1.SelectedText;
        }
        public void Paste()
        {
            richTextBox1.SelectedText = this.BufferText;
        }
        public void SelectAll()
        {
            richTextBox1.SelectAll();
        }
        public void Delete()
        {
            richTextBox1.SelectedText = "";
            this.BufferText = "";
        }
        public void Open(string OpenFileName)
        {
            if (OpenFileName == "")
            {
                return;
            }
            else
            {
                StreamReader sr = new StreamReader(OpenFileName, Encoding.GetEncoding(1251));
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                DocName = OpenFileName;
            }
        }
        public void Save(string SaveFileName)
        {
            if (SaveFileName == "")
                return;
            else
            {
                StreamWriter sw = new StreamWriter(SaveFileName);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
                DocName = SaveFileName;


            }

        }


            private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void blank_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsSaved == false)
                if (MessageBox.Show("Do you want save changes in " + this.DocName + "?", "Message", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
                    this.Save(this.DocName);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            SetL(Language);
            Amount_sb.Text = "Аmount of symbols: " + richTextBox1.Text.Length.ToString();
        }
        public int Language;
        public void SetL(int a)
        {
            if(a==1)
            {
                Amount_sb.Text = "Кількість символів ";
               
                copyToolStripMenuItem.Text = "Копіювати";
                cutToolStripMenuItem.Text = "Вирізати";
                pasteToolStripMenuItem.Text = "Вставити";
                deleteToolStripMenuItem.Text = "Видалити";
                selectAllToolStripMenuItem.Text = "Вибрати все";
                Language = 1;
            }
            if (a == 0)
            {
                Amount_sb.Text = "Count ";
                copyToolStripMenuItem.Text = "Copy";
                cutToolStripMenuItem.Text = "Cut";
                pasteToolStripMenuItem.Text = "Paste";
                deleteToolStripMenuItem.Text = "Delete";
                selectAllToolStripMenuItem.Text = "Select All";
                Language = 0;
            }
        }

      
    }
}
