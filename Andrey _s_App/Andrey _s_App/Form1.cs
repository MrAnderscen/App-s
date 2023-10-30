using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Andrey__s_App
{
    public partial class Form1 : Form
    {
        private List<Quest> quests;
        public Form1()
        {
            InitializeComponent();
            quests = new List<Quest>();
        }
        private void AddQuest_Click(object sender, EventArgs e)
        {
            Quest quest = new Quest("", "", "", "", "", "");
            Redact childForm = new Redact(quest);
            if (childForm.ShowDialog() == DialogResult.OK)
            {
                quest = childForm.GetQuestion();
                quests.Add(quest);
            }

            int selectedIndex = listBox1.Items.Count + 1;

            listBox1.Items.Add("Вопрос " + selectedIndex);
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                int selectedIndex = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(selectedIndex);
                quests.RemoveAt(selectedIndex);
            }
        }
        private void Redact_Click(object sender, EventArgs e)
        {


            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < quests.Count)
            {
                Quest selectedQuest = quests[selectedIndex];

                if (selectedQuest.quest == "" || selectedQuest.answer_true == "" && selectedQuest.answer_false1 == "" && selectedQuest.answer_false2 == "" && selectedQuest.answer_false3 == "" && selectedQuest.text == "")
                {
                    MessageBox.Show("Вопрос пустой редактировать нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Redact form = new Redact(selectedQuest);
                    form.ShowDialog();
                }
            }
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < quests.Count)
            {
                Quest selectedQuest = quests[selectedIndex];

                if (selectedQuest.quest == "" || selectedQuest.answer_true == "" && selectedQuest.answer_false1 == "" && selectedQuest.answer_false2 == "" && selectedQuest.answer_false3 == "" && selectedQuest.text == "")
                {
                    MessageBox.Show("Вопрос пустой редактировать нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Redact form = new Redact(selectedQuest);
                    form.ShowDialog();
                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.FileName = "data.json";
            saveDialog.Filter = "JSON file (*.json)|*.json";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveDialog.FileName;
                JObject jObject = new JObject();
                jObject["ok"] = true;
                jObject["questions"] = JArray.FromObject(quests);
                string json = jObject.ToString();
                File.WriteAllText(filePath, json);
                Close();
            }
        }
    }
}