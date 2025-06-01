namespace _52
{
    partial class adm
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
            dataGridViewPol = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtLogin = new TextBox();
            txtPass = new TextBox();
            txtBan = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPol).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPol
            // 
            dataGridViewPol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPol.Location = new Point(12, 12);
            dataGridViewPol.Name = "dataGridViewPol";
            dataGridViewPol.Size = new Size(776, 271);
            dataGridViewPol.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(27, 372);
            button1.Name = "button1";
            button1.Size = new Size(126, 43);
            button1.TabIndex = 1;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(159, 372);
            button2.Name = "button2";
            button2.Size = new Size(126, 43);
            button2.TabIndex = 2;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(291, 372);
            button3.Name = "button3";
            button3.Size = new Size(126, 43);
            button3.TabIndex = 3;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(150, 308);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 5;
            txtLogin.Text = "Login";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(256, 308);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 6;
            txtPass.Text = "Pass";
            // 
            // txtBan
            // 
            txtBan.Location = new Point(362, 308);
            txtBan.Name = "txtBan";
            txtBan.Size = new Size(100, 23);
            txtBan.TabIndex = 7;
            txtBan.Text = "Ban";
            // 
            // adm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBan);
            Controls.Add(txtPass);
            Controls.Add(txtLogin);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridViewPol);
            Name = "adm";
            Text = "adm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPol;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtLogin;
        private TextBox txtPass;
        private TextBox txtBan;
    }
}