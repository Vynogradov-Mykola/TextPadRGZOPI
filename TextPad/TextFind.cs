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
        public TextFind(int Language)
        {
            InitializeComponent();
            if (Language == 0)  //Translate
            {
                this.Text = "Find";
                Check_Match.Text = "Match case";
                Check_whole.Text = "Check whole" +Environment.NewLine+ "word";
            }
            if(Language ==1)    //Translate
            {
                this.Text = "Знайти";
                Check_Match.Text = "Враховувати регістр";
                Check_whole.Text = "Перевірити ціле" + Environment.NewLine + " слово";
            }
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
            set
            {
                Text_To_Find.Text = value;
            }
            get
            {
                return Text_To_Find.Text;
            }
        }
            
        private void Cancel_buttn_Click(object sender, EventArgs e)     //Close 
        {
            this.Close();
        }

       
    }
}
