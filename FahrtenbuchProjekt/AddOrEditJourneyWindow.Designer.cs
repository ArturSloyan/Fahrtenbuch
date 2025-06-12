namespace FahrtenbuchProjekt
{
    partial class AddOrEditJourneyWindow
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
            labelTitle = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxReason = new TextBox();
            label7 = new Label();
            label8 = new Label();
            buttonCancel = new Button();
            dateTimePickerDateOfJourney = new DateTimePicker();
            buttonSave = new Button();
            label1 = new Label();
            comboBoxCompanyCar = new ComboBox();
            textBoxTravelRoute = new TextBox();
            textBoxKmDistanceDeparture = new TextBox();
            textBoxKmDistanceArrival = new TextBox();
            dateTimePickerTimeStampStart = new DateTimePicker();
            dateTimePickerTimeStampEnd = new DateTimePicker();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F);
            labelTitle.Location = new Point(162, 29);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(167, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "[Fahrt hinzufügen]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 106);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Datum:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 135);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 1;
            label3.Text = "Zeitstempel Beginn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 164);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 1;
            label4.Text = "Zeitstempel Ende:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 193);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 1;
            label5.Text = "Reiseweg:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 222);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 1;
            label6.Text = "Zweck der Fahrt:";
            // 
            // textBoxReason
            // 
            textBoxReason.Location = new Point(133, 219);
            textBoxReason.Name = "textBoxReason";
            textBoxReason.Size = new Size(308, 23);
            textBoxReason.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 251);
            label7.Name = "label7";
            label7.Size = new Size(106, 15);
            label7.TabIndex = 1;
            label7.Text = "KM-Stand Abfahrt:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 282);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 1;
            label8.Text = "KM-Stand Ankunft:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(12, 371);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Abbrechen";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // dateTimePickerDateOfJourney
            // 
            dateTimePickerDateOfJourney.Location = new Point(133, 103);
            dateTimePickerDateOfJourney.Name = "dateTimePickerDateOfJourney";
            dateTimePickerDateOfJourney.Size = new Size(308, 23);
            dateTimePickerDateOfJourney.TabIndex = 4;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(383, 371);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(92, 23);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Speichern";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 311);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Firmen-Pkw:";
            // 
            // comboBoxCompanyCar
            // 
            comboBoxCompanyCar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCompanyCar.FormattingEnabled = true;
            comboBoxCompanyCar.Location = new Point(133, 308);
            comboBoxCompanyCar.Name = "comboBoxCompanyCar";
            comboBoxCompanyCar.Size = new Size(308, 23);
            comboBoxCompanyCar.TabIndex = 6;
            // 
            // textBoxTravelRoute
            // 
            textBoxTravelRoute.Location = new Point(133, 190);
            textBoxTravelRoute.Name = "textBoxTravelRoute";
            textBoxTravelRoute.Size = new Size(308, 23);
            textBoxTravelRoute.TabIndex = 7;
            textBoxTravelRoute.KeyPress += textBoxTravelRoute_KeyPress;
            // 
            // textBoxKmDistanceDeparture
            // 
            textBoxKmDistanceDeparture.Location = new Point(133, 248);
            textBoxKmDistanceDeparture.Name = "textBoxKmDistanceDeparture";
            textBoxKmDistanceDeparture.Size = new Size(308, 23);
            textBoxKmDistanceDeparture.TabIndex = 7;
            textBoxKmDistanceDeparture.KeyPress += textBoxKmDistanceDeparture_KeyPress;
            // 
            // textBoxKmDistanceArrival
            // 
            textBoxKmDistanceArrival.Location = new Point(133, 279);
            textBoxKmDistanceArrival.Name = "textBoxKmDistanceArrival";
            textBoxKmDistanceArrival.Size = new Size(308, 23);
            textBoxKmDistanceArrival.TabIndex = 7;
            textBoxKmDistanceArrival.KeyPress += textBoxKmDistanceArrival_KeyPress;
            // 
            // dateTimePickerTimeStampStart
            // 
            dateTimePickerTimeStampStart.Location = new Point(133, 132);
            dateTimePickerTimeStampStart.Name = "dateTimePickerTimeStampStart";
            dateTimePickerTimeStampStart.Size = new Size(308, 23);
            dateTimePickerTimeStampStart.TabIndex = 8;
            // 
            // dateTimePickerTimeStampEnd
            // 
            dateTimePickerTimeStampEnd.Location = new Point(133, 161);
            dateTimePickerTimeStampEnd.Name = "dateTimePickerTimeStampEnd";
            dateTimePickerTimeStampEnd.Size = new Size(308, 23);
            dateTimePickerTimeStampEnd.TabIndex = 8;
            // 
            // AddOrEditJourneyWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 406);
            Controls.Add(dateTimePickerTimeStampEnd);
            Controls.Add(dateTimePickerTimeStampStart);
            Controls.Add(textBoxKmDistanceArrival);
            Controls.Add(textBoxKmDistanceDeparture);
            Controls.Add(textBoxTravelRoute);
            Controls.Add(comboBoxCompanyCar);
            Controls.Add(dateTimePickerDateOfJourney);
            Controls.Add(buttonSave);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxReason);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            Name = "AddOrEditJourneyWindow";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxReason;
        private Label label7;
        private Label label8;
        private Button buttonCancel;
        private DateTimePicker dateTimePickerDateOfJourney;
        private Button buttonSave;
        private Label label1;
        private ComboBox comboBoxCompanyCar;
        private TextBox textBoxTravelRoute;
        private TextBox textBoxKmDistanceDeparture;
        private TextBox textBoxKmDistanceArrival;
        private DateTimePicker dateTimePickerTimeStampStart;
        private DateTimePicker dateTimePickerTimeStampEnd;
    }
}