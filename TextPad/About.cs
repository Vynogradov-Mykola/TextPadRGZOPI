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
        public About(int Language)
        {
            InitializeComponent();
            if (Language == 0)  //Translate
            {
                this.Text = "About";
                Autor.Text = "Made by Vynogradov Mykola" + Environment.NewLine + " KNT - 110";
            }
            if (Language == 1)  //Translate
            {
                this.Text = "Про програму";
                Autor.Text = "Виконав Виноградов Микола" + Environment.NewLine + " КНТ - 110";
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)   //If no connection
        {
            try { VisitLink(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " Unable to open link that was clicked.");
            }
        }
        private void VisitLink()    //Link to GitHub
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Vynogradov-Mykola/TextPadRGZOPI");

        }

        private void Okey_btn_Click(object sender, EventArgs e) //Close
        {
            this.Close();
        }
    }
}
