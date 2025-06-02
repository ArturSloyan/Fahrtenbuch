namespace FahrtenbuchProjekt
{
    partial class LoginWindow
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
            label1 = new Label();
            label2 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            buttonLogin = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(766, 216);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(163, 72);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(503, 344);
            label2.Name = "label2";
            label2.Size = new Size(192, 37);
            label2.TabIndex = 1;
            label2.Text = "Benutzername:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 20F);
            textBoxUsername.Location = new Point(729, 342);
            textBoxUsername.Margin = new Padding(3, 2, 3, 2);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(419, 43);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 20F);
            textBoxPassword.Location = new Point(729, 403);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(419, 43);
            textBoxPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(576, 405);
            label3.Name = "label3";
            label3.Size = new Size(127, 37);
            label3.TabIndex = 3;
            label3.Text = "Passwort:";
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 20F);
            buttonLogin.Location = new Point(503, 510);
            buttonLogin.Margin = new Padding(3, 2, 3, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(644, 62);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 20F);
            buttonExit.Location = new Point(503, 587);
            buttonExit.Margin = new Padding(3, 2, 3, 2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(644, 62);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1836, 788);
            Controls.Add(buttonExit);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label3;
        private Button buttonLogin;
        private Button buttonExit;
    }
}