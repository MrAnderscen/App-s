namespace Andrey__s_App
{
    partial class Redact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Redact));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbQuestion = new TextBox();
            tbAnswer_true1 = new TextBox();
            tbAnswer2 = new TextBox();
            tbAnswer3 = new TextBox();
            tbAnswer4 = new TextBox();
            tbExplanation = new TextBox();
            Save = new Button();
            Cancel = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Вопрос:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(617, 35);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Пояснение:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 9);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 1;
            label3.Text = "Ответы:";
            // 
            // tbQuestion
            // 
            tbQuestion.Location = new Point(12, 71);
            tbQuestion.MaxLength = 100;
            tbQuestion.Multiline = true;
            tbQuestion.Name = "tbQuestion";
            tbQuestion.ScrollBars = ScrollBars.Vertical;
            tbQuestion.Size = new Size(146, 50);
            tbQuestion.TabIndex = 2;
            // 
            // tbAnswer_true1
            // 
            tbAnswer_true1.Location = new Point(298, 71);
            tbAnswer_true1.MaxLength = 50;
            tbAnswer_true1.Multiline = true;
            tbAnswer_true1.Name = "tbAnswer_true1";
            tbAnswer_true1.ScrollBars = ScrollBars.Vertical;
            tbAnswer_true1.Size = new Size(170, 50);
            tbAnswer_true1.TabIndex = 3;
            // 
            // tbAnswer2
            // 
            tbAnswer2.Location = new Point(295, 164);
            tbAnswer2.MaxLength = 50;
            tbAnswer2.Multiline = true;
            tbAnswer2.Name = "tbAnswer2";
            tbAnswer2.ScrollBars = ScrollBars.Vertical;
            tbAnswer2.Size = new Size(170, 41);
            tbAnswer2.TabIndex = 4;
            // 
            // tbAnswer3
            // 
            tbAnswer3.Location = new Point(295, 211);
            tbAnswer3.MaxLength = 50;
            tbAnswer3.Multiline = true;
            tbAnswer3.Name = "tbAnswer3";
            tbAnswer3.ScrollBars = ScrollBars.Vertical;
            tbAnswer3.Size = new Size(170, 41);
            tbAnswer3.TabIndex = 5;
            // 
            // tbAnswer4
            // 
            tbAnswer4.Location = new Point(295, 258);
            tbAnswer4.MaxLength = 50;
            tbAnswer4.Multiline = true;
            tbAnswer4.Name = "tbAnswer4";
            tbAnswer4.ScrollBars = ScrollBars.Vertical;
            tbAnswer4.Size = new Size(170, 41);
            tbAnswer4.TabIndex = 6;
            // 
            // tbExplanation
            // 
            tbExplanation.Location = new Point(600, 71);
            tbExplanation.MaxLength = 100;
            tbExplanation.Multiline = true;
            tbExplanation.Name = "tbExplanation";
            tbExplanation.ScrollBars = ScrollBars.Vertical;
            tbExplanation.Size = new Size(170, 50);
            tbExplanation.TabIndex = 7;
            // 
            // Save
            // 
            Save.Location = new Point(39, 334);
            Save.Name = "Save";
            Save.Size = new Size(283, 29);
            Save.TabIndex = 8;
            Save.Text = "Сохранить изменения";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(558, 330);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(188, 29);
            Cancel.TabIndex = 9;
            Cancel.Text = "Отмена";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 37);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 14;
            label4.Text = "Правильный ответ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 132);
            label5.Name = "label5";
            label5.Size = new Size(170, 20);
            label5.TabIndex = 15;
            label5.Text = "Неправильные ответы:";
            // 
            // Redact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Cancel);
            Controls.Add(Save);
            Controls.Add(tbExplanation);
            Controls.Add(tbAnswer4);
            Controls.Add(tbAnswer3);
            Controls.Add(tbAnswer2);
            Controls.Add(tbAnswer_true1);
            Controls.Add(tbQuestion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Redact";
            Text = "Редактирование вопроса";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbQuestion;
        private TextBox tbAnswer_true1;
        private TextBox tbAnswer2;
        private TextBox tbAnswer3;
        private TextBox tbAnswer4;
        private TextBox tbExplanation;
        private Button Save;
        private Button Cancel;
        private Label label4;
        private Label label5;
    }
}