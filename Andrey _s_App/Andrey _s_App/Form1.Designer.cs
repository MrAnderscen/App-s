namespace Andrey__s_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            Delete = new Button();
            Save = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(276, 164);
            button1.Name = "button1";
            button1.Size = new Size(176, 29);
            button1.TabIndex = 9;
            button1.Text = "Добавить вопрос";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddQuest_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(302, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 14;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // button2
            // 
            button2.Location = new Point(247, 129);
            button2.Name = "button2";
            button2.Size = new Size(123, 29);
            button2.TabIndex = 15;
            button2.Text = "Редактировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Redact_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(376, 129);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 16;
            Delete.Text = "Удалить";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Save
            // 
            Save.Location = new Point(623, 41);
            Save.Name = "Save";
            Save.Size = new Size(165, 29);
            Save.TabIndex = 17;
            Save.Text = "Сохранить в файл";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Save);
            Controls.Add(Delete);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Содание вопросов";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button Delete;
        private Button Save;
    }
}