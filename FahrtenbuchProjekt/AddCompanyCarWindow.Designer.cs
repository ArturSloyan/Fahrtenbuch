namespace FahrtenbuchProjekt
{
    partial class AddCompanyCarWindow
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
            textBoxLicencePlate = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxBrand = new TextBox();
            label4 = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            comboBoxCarType = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 38);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 0;
            label1.Text = "Firmen-Pkw hinzufügen";
            // 
            // textBoxLicencePlate
            // 
            textBoxLicencePlate.Location = new Point(125, 193);
            textBoxLicencePlate.Name = "textBoxLicencePlate";
            textBoxLicencePlate.Size = new Size(214, 23);
            textBoxLicencePlate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 196);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Kennzeichnen:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 167);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Type:";
            // 
            // textBoxBrand
            // 
            textBoxBrand.Location = new Point(125, 135);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(214, 23);
            textBoxBrand.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 138);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 2;
            label4.Text = "Marke:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(12, 292);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Abbrechen";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(295, 292);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Speichern";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // comboBoxCarType
            // 
            comboBoxCarType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCarType.FormattingEnabled = true;
            comboBoxCarType.Location = new Point(125, 164);
            comboBoxCarType.Name = "comboBoxCarType";
            comboBoxCarType.Size = new Size(214, 23);
            comboBoxCarType.TabIndex = 5;
            // 
            // AddCompanyCarWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 327);
            Controls.Add(comboBoxCarType);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxBrand);
            Controls.Add(textBoxLicencePlate);
            Controls.Add(label1);
            Name = "AddCompanyCarWindow";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxLicencePlate;
        private Label label2;
        private Label label3;
        private TextBox textBoxBrand;
        private Label label4;
        private Button buttonCancel;
        private Button buttonSave;
        private ComboBox comboBoxCarType;
    }
}