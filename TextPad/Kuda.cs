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
        public Kuda()
        {
            InitializeComponent();
           
        }
        public Pen pen;
        private void OK_btn_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        public int ret_H()
        {

            if (Eng_btn.Checked == true) return 0;
            if (Uk_btn.Checked == true) return 1;
            return 1;
        }
    }
}
