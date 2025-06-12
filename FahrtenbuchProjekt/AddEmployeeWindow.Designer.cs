namespace FahrtenbuchProjekt
{
    partial class AddEmployeeWindow
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
            label3 = new Label();
            label4 = new Label();
            textBoxFirstname = new TextBox();
            textBoxLastname = new TextBox();
            textBoxEmail = new TextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 82);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Vorname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(50, 9);
            label2.Name = "label2";
            label2.Size = new Size(207, 25);
            label2.TabIndex = 1;
            label2.Text = "Mitarbeiter hinzufügen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "Nachname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 140);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // textBoxFirstname
            // 
            textBoxFirstname.Location = new Point(86, 79);
            textBoxFirstname.Name = "textBoxFirstname";
            textBoxFirstname.Size = new Size(204, 23);
            textBoxFirstname.TabIndex = 4;
            // 
            // textBoxLastname
            // 
            textBoxLastname.Location = new Point(86, 108);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(204, 23);
            textBoxLastname.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(86, 137);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(204, 23);
            textBoxEmail.TabIndex = 4;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(12, 229);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Abbrechen";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(229, 229);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Speichern";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 169);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 3;
            label5.Text = "Passwort:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 4;
            // 
            // AddEmployeeWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 264);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(textBox1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxLastname);
            Controls.Add(label5);
            Controls.Add(textBoxFirstname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddEmployeeWindow";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxFirstname;
        private TextBox textBoxLastname;
        private TextBox textBoxEmail;
        private Button buttonCancel;
        private Button buttonSave;
        private Label label5;
        private TextBox textBox1;
    }
}