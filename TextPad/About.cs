using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextPad
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            try { VisitLink(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " Unable to open link that was clicked.");
            }
        }
        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Vynogradov-Mykola/TextPadRGZOPI");

        }

        private void Okey_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
