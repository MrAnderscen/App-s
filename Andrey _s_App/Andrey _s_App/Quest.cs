using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrey__s_App
{
    public class Quest
    {
        public string quest {  get; set; }
        public string answer_true { get; set; }
        public string answer_false1 { get; set; }
        public string answer_false2 { get; set; }
        public string answer_false3 { get; set; }
        public string text { get; set; }
        public Quest(string Quest, string Answer_true , string Answer_false1, string Answer_false2, string Answer_false3, string Text)
        {
            quest = Quest;
            answer_true = Answer_true;
            answer_false1 = Answer_false1;
            answer_false2 = Answer_false2;
            answer_false3 = Answer_false3;
            text = Text;
        }
    }
}
