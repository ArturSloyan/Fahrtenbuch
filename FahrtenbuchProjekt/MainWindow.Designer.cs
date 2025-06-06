namespace FahrtenbuchProjekt
{
    partial class MainWindow
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
            dataGridViewJourneys = new DataGridView();
            buttonAddJourney = new Button();
            buttonEditJourney = new Button();
            buttonDeleteJourney = new Button();
            buttonAddCompanyCar = new Button();
            dataGridViewCompanyCars = new DataGridView();
            label2 = new Label();
            buttonLogout = new Button();
            menuStrip1 = new MenuStrip();
            mitarbeiterToolStripMenuItem = new ToolStripMenuItem();
            anlegenToolStripMenuItem = new ToolStripMenuItem();
            ansichtAlleAnzeigenToolStripMenuItem = new ToolStripMenuItem();
            buttonShowAllJourneys = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJourneys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompanyCars).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewJourneys
            // 
            dataGridViewJourneys.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJourneys.Location = new Point(274, 79);
            dataGridViewJourneys.MultiSelect = false;
            dataGridViewJourneys.Name = "dataGridViewJourneys";
            dataGridViewJourneys.ReadOnly = true;
            dataGridViewJourneys.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewJourneys.Size = new Size(1014, 567);
            dataGridViewJourneys.TabIndex = 1;
            // 
            // buttonAddJourney
            // 
            buttonAddJourney.Location = new Point(1203, 652);
            buttonAddJourney.Name = "buttonAddJourney";
            buttonAddJourney.Size = new Size(85, 23);
            buttonAddJourney.TabIndex = 3;
            buttonAddJourney.Text = "Hinzufügen";
            buttonAddJourney.UseVisualStyleBackColor = true;
            buttonAddJourney.Click += buttonAddJourney_Click;
            // 
            // buttonEditJourney
            // 
            buttonEditJourney.Location = new Point(1122, 652);
            buttonEditJourney.Name = "buttonEditJourney";
            buttonEditJourney.Size = new Size(75, 23);
            buttonEditJourney.TabIndex = 4;
            buttonEditJourney.Text = "Ändern";
            buttonEditJourney.UseVisualStyleBackColor = true;
            buttonEditJourney.Click += buttonEditJourney_Click;
            // 
            // buttonDeleteJourney
            // 
            buttonDeleteJourney.Location = new Point(1041, 652);
            buttonDeleteJourney.Name = "buttonDeleteJourney";
            buttonDeleteJourney.Size = new Size(75, 23);
            buttonDeleteJourney.TabIndex = 5;
            buttonDeleteJourney.Text = "Löschen";
            buttonDeleteJourney.UseVisualStyleBackColor = true;
            buttonDeleteJourney.Click += buttonDeleteJourney_Click;
            // 
            // buttonAddCompanyCar
            // 
            buttonAddCompanyCar.Location = new Point(12, 652);
            buttonAddCompanyCar.Name = "buttonAddCompanyCar";
            buttonAddCompanyCar.Size = new Size(153, 23);
            buttonAddCompanyCar.TabIndex = 6;
            buttonAddCompanyCar.Text = "Firmen-Pkw hinzufügen";
            buttonAddCompanyCar.UseVisualStyleBackColor = true;
            buttonAddCompanyCar.Click += buttonAddCompanyCar_Click;
            // 
            // dataGridViewCompanyCars
            // 
            dataGridViewCompanyCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCompanyCars.Location = new Point(12, 79);
            dataGridViewCompanyCars.MultiSelect = false;
            dataGridViewCompanyCars.Name = "dataGridViewCompanyCars";
            dataGridViewCompanyCars.ReadOnly = true;
            dataGridViewCompanyCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCompanyCars.Size = new Size(240, 567);
            dataGridViewCompanyCars.TabIndex = 7;
            dataGridViewCompanyCars.SelectionChanged += dataGridViewCompanyCars_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(174, 40);
            label2.TabIndex = 8;
            label2.Text = "Fahrtenbuch";
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(1210, 12);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(78, 23);
            buttonLogout.TabIndex = 0;
            buttonLogout.Text = "Ausloggen";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mitarbeiterToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1300, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // mitarbeiterToolStripMenuItem
            // 
            mitarbeiterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { anlegenToolStripMenuItem, ansichtAlleAnzeigenToolStripMenuItem });
            mitarbeiterToolStripMenuItem.Name = "mitarbeiterToolStripMenuItem";
            mitarbeiterToolStripMenuItem.Size = new Size(77, 20);
            mitarbeiterToolStripMenuItem.Text = "Mitarbeiter";
            // 
            // anlegenToolStripMenuItem
            // 
            anlegenToolStripMenuItem.Name = "anlegenToolStripMenuItem";
            anlegenToolStripMenuItem.Size = new Size(194, 22);
            anlegenToolStripMenuItem.Text = "Anlegen...";
            // 
            // ansichtAlleAnzeigenToolStripMenuItem
            // 
            ansichtAlleAnzeigenToolStripMenuItem.Name = "ansichtAlleAnzeigenToolStripMenuItem";
            ansichtAlleAnzeigenToolStripMenuItem.Size = new Size(194, 22);
            ansichtAlleAnzeigenToolStripMenuItem.Text = "Ansicht alle anzeigen...";
            // 
            // buttonShowAllJourneys
            // 
            buttonShowAllJourneys.Location = new Point(274, 652);
            buttonShowAllJourneys.Name = "buttonShowAllJourneys";
            buttonShowAllJourneys.Size = new Size(149, 23);
            buttonShowAllJourneys.TabIndex = 5;
            buttonShowAllJourneys.Text = "Alle Fahrten anzeigen";
            buttonShowAllJourneys.UseVisualStyleBackColor = true;
            buttonShowAllJourneys.Click += buttonShowAllJourneys_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 686);
            Controls.Add(label2);
            Controls.Add(dataGridViewCompanyCars);
            Controls.Add(buttonAddCompanyCar);
            Controls.Add(buttonShowAllJourneys);
            Controls.Add(buttonDeleteJourney);
            Controls.Add(buttonEditJourney);
            Controls.Add(buttonAddJourney);
            Controls.Add(dataGridViewJourneys);
            Controls.Add(buttonLogout);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewJourneys).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompanyCars).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewJourneys;
        private Button buttonAddJourney;
        private Button buttonEditJourney;
        private Button buttonDeleteJourney;
        private Button buttonAddCompanyCar;
        private DataGridView dataGridViewCompanyCars;
        private Label label2;
        private Button buttonLogout;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mitarbeiterToolStripMenuItem;
        private ToolStripMenuItem anlegenToolStripMenuItem;
        private ToolStripMenuItem ansichtAlleAnzeigenToolStripMenuItem;
        private Button buttonShowAllJourneys;
    }
}