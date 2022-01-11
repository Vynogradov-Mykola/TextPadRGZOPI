using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            saveToolStripMenuItem.Enabled = false;
        }
        private int openDocuments = 0;
      

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Save(frm.DocName);
            frm.IsSaved = true;
        }

        SaveFileDialog saveFileDialog1=new SaveFileDialog();
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = (blank)this.ActiveMdiChild;
                frm.Save(saveFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = frm.DocName;

                frm.IsSaved = true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = true;
            var openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = new blank();
                frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = openFileDialog1.FileName;
                frm.Text = frm.DocName;
               
                frm.Show();
            }


        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            Font_change.ShowColor = true;
            Font_change.Font = frm.richTextBox1.SelectionFont;
            Font_change.Color = frm.richTextBox1.SelectionColor;
            if (Font_change.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionFont = Font_change.Font;
                frm.richTextBox1.SelectionColor = Font_change.Color;
            }
            frm.Show();

        }

        private void New_File_Click(object sender, EventArgs e)
        {
            blank frm = new blank();
            frm.DocName = "Untitled" + ++openDocuments;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            
           
            frm.Show();

        }

      

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void theHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void theVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Cut();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Paste();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Delete();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            Change_color.Color = frm.richTextBox1.SelectionColor;
            if (Change_color.ShowDialog() == DialogResult.OK)
                frm.richTextBox1.SelectionColor = Change_color.Color;
            frm.Show();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Find_menu_Click(object sender, EventArgs e)
        {
            TextFind frm = new TextFind();
            if (frm.ShowDialog(this) == DialogResult.Cancel) return;
            blank form = (blank)this.ActiveMdiChild;
            form.MdiParent = this;
            int start = form.richTextBox1.SelectionStart;
            form.richTextBox1.Find(frm.FindText, start, frm.FindCondition);

        }
    }
}


