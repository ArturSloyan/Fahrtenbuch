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
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(876, 288);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(202, 89);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(575, 459);
            label2.Name = "label2";
            label2.Size = new Size(242, 46);
            label2.TabIndex = 1;
            label2.Text = "Benutzername:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 20F);
            textBoxUsername.Location = new Point(833, 456);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(478, 52);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 20F);
            textBoxPassword.Location = new Point(833, 537);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(478, 52);
            textBoxPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(658, 540);
            label3.Name = "label3";
            label3.Size = new Size(159, 46);
            label3.TabIndex = 3;
            label3.Text = "Passwort:";
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 20F);
            buttonLogin.Location = new Point(575, 680);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(736, 82);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 20F);
            buttonExit.Location = new Point(575, 783);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(736, 82);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(299, 456);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 7;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2098, 1050);
            Controls.Add(maskedTextBox1);
            Controls.Add(buttonExit);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private MaskedTextBox maskedTextBox1;
    }
}