using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Andrey__s_App
{
    public partial class Redact : Form
    {
        private Quest quest;



        public Redact(Quest quest)
        {
            InitializeComponent();
            this.quest = quest;

            tbQuestion.Text = quest.quest;
            tbAnswer_true1.Text = quest.answer_true;
            tbAnswer2.Text = quest.answer_false1;
            tbAnswer3.Text = quest.answer_false2;
            tbAnswer4.Text = quest.answer_false3;
            tbExplanation.Text = quest.text;
        }
        public Quest GetQuestion()
        {
            return quest;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            quest.quest = tbQuestion.Text;
            quest.answer_true = tbAnswer_true1.Text;
            quest.answer_false1 = tbAnswer2.Text;
            quest.answer_false2 = tbAnswer3.Text;
            quest.answer_false3 = tbAnswer4.Text;
            quest.text = tbExplanation.Text;

            this.DialogResult = DialogResult.OK;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
