namespace _52
{
    partial class rereg
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
            mainpass = new TextBox();
            newpass = new TextBox();
            newnewpass = new TextBox();
            button1 = new Button();
            labelWelcome = new Label();
            SuspendLayout();
            // 
            // mainpass
            // 
            mainpass.Location = new Point(350, 150);
            mainpass.Name = "mainpass";
            mainpass.Size = new Size(100, 23);
            mainpass.TabIndex = 0;
            // 
            // newpass
            // 
            newpass.Location = new Point(350, 179);
            newpass.Name = "newpass";
            newpass.Size = new Size(100, 23);
            newpass.TabIndex = 1;
            // 
            // newnewpass
            // 
            newnewpass.Location = new Point(350, 208);
            newnewpass.Name = "newnewpass";
            newnewpass.Size = new Size(100, 23);
            newnewpass.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(326, 274);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 3;
            button1.Text = "Изменить пароль";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(104, 36);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(38, 15);
            labelWelcome.TabIndex = 4;
            labelWelcome.Text = "label1";
            // 
            // rereg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelWelcome);
            Controls.Add(button1);
            Controls.Add(newnewpass);
            Controls.Add(newpass);
            Controls.Add(mainpass);
            Name = "rereg";
            Text = "rereg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox mainpass;
        private TextBox newpass;
        private TextBox newnewpass;
        private Button button1;
        private Label labelWelcome;
    }
}