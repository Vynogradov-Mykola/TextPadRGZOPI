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
    public partial class TextFind : Form
    {
        public TextFind()
        {
            InitializeComponent();
        }
        public RichTextBoxFinds FindCondition
        {
            get
            {
                if (Check_Match.Checked && Check_whole.Checked)
                    return RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord;
                if (Check_Match.Checked)
                    return RichTextBoxFinds.MatchCase;
                if (Check_whole.Checked)
                    return RichTextBoxFinds.WholeWord;
                return RichTextBoxFinds.None;
            }
        }
        public string FindText
        {
            set {
                Text_To_Find.Text = value; }
            get
            {
                return Text_To_Find.Text;
            }
           
            }
            
        private void Cancel_buttn_Click(object sender, EventArgs e)
        {

        }
    }
}
