namespace _52
{
    partial class areg
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
            log = new TextBox();
            pas = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // log
            // 
            log.Location = new Point(358, 157);
            log.Name = "log";
            log.Size = new Size(100, 23);
            log.TabIndex = 0;
            // 
            // pas
            // 
            pas.Location = new Point(358, 202);
            pas.Name = "pas";
            pas.Size = new Size(100, 23);
            pas.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(358, 263);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 2;
            button1.Text = "Авторизация";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // areg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pas);
            Controls.Add(log);
            Name = "areg";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox log;
        private TextBox pas;
        private Button button1;
    }
}
