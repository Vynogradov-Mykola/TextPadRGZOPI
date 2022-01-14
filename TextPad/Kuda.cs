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
    public partial class Kuda : Form
    {
        public Kuda(int Language)
        {
            InitializeComponent();
            if (Language == 1) groupBox1.Text = "Виберіть"; //Translate
            if (Language == 0) groupBox1.Text = "Select";   //Translate
        }
        public Pen pen;
        private void OK_btn_Click(object sender, EventArgs e)
        {

            this.Close();   //Close window
        }
        public int ret_Language()   //Return Language index 0-English; 1-Ukrainian
        {

            if (Eng_btn.Checked == true) return 0;
            if (Uk_btn.Checked == true) return 1;
            return 1;
        }
    }
}
