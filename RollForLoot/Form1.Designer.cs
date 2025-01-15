namespace RollForLoot
{
    partial class FormMainMneu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMneu));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOpenDatabase = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1CharacterName = new System.Windows.Forms.Label();
            this.labelTimes = new System.Windows.Forms.Label();
            this.labelRoll = new System.Windows.Forms.Label();
            this.buttonGiveLoot = new System.Windows.Forms.Button();
            this.textBoxCharacterName = new System.Windows.Forms.TextBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.listBoxLoot = new System.Windows.Forms.ListBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.numericUpDownTimes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRoll = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDatabase = new System.Windows.Forms.ComboBox();
            this.buttonSaveLoot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoll)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(43, 75);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(168, 38);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(43, 249);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(168, 38);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonOpenDatabase
            // 
            this.buttonOpenDatabase.Location = new System.Drawing.Point(43, 142);
            this.buttonOpenDatabase.Name = "buttonOpenDatabase";
            this.buttonOpenDatabase.Size = new System.Drawing.Size(168, 38);
            this.buttonOpenDatabase.TabIndex = 6;
            this.buttonOpenDatabase.Text = "Open Database";
            this.buttonOpenDatabase.UseVisualStyleBackColor = true;
            this.buttonOpenDatabase.Click += new System.EventHandler(this.buttonOpenDatabase_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(168, 328);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Visible = false;
            // 
            // label1CharacterName
            // 
            this.label1CharacterName.AutoSize = true;
            this.label1CharacterName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1CharacterName.Location = new System.Drawing.Point(388, 137);
            this.label1CharacterName.Name = "label1CharacterName";
            this.label1CharacterName.Size = new System.Drawing.Size(119, 19);
            this.label1CharacterName.TabIndex = 8;
            this.label1CharacterName.Text = "Character Name";
            this.label1CharacterName.Visible = false;
            // 
            // labelTimes
            // 
            this.labelTimes.AutoSize = true;
            this.labelTimes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelTimes.Location = new System.Drawing.Point(388, 268);
            this.labelTimes.Name = "labelTimes";
            this.labelTimes.Size = new System.Drawing.Size(106, 19);
            this.labelTimes.TabIndex = 12;
            this.labelTimes.Text = "Running times";
            this.labelTimes.Visible = false;
            // 
            // labelRoll
            // 
            this.labelRoll.AutoSize = true;
            this.labelRoll.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelRoll.Location = new System.Drawing.Point(388, 204);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.Size = new System.Drawing.Size(35, 19);
            this.labelRoll.TabIndex = 13;
            this.labelRoll.Text = "Roll";
            this.labelRoll.Visible = false;
            // 
            // buttonGiveLoot
            // 
            this.buttonGiveLoot.Location = new System.Drawing.Point(392, 339);
            this.buttonGiveLoot.Name = "buttonGiveLoot";
            this.buttonGiveLoot.Size = new System.Drawing.Size(168, 38);
            this.buttonGiveLoot.TabIndex = 15;
            this.buttonGiveLoot.Text = "Give loot";
            this.buttonGiveLoot.UseVisualStyleBackColor = true;
            this.buttonGiveLoot.Visible = false;
            this.buttonGiveLoot.Click += new System.EventHandler(this.buttonGiveLoot_Click);
            // 
            // textBoxCharacterName
            // 
            this.textBoxCharacterName.Location = new System.Drawing.Point(392, 160);
            this.textBoxCharacterName.Name = "textBoxCharacterName";
            this.textBoxCharacterName.Size = new System.Drawing.Size(205, 27);
            this.textBoxCharacterName.TabIndex = 17;
            this.textBoxCharacterName.Visible = false;
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelMode.Location = new System.Drawing.Point(388, 75);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(49, 19);
            this.labelMode.TabIndex = 20;
            this.labelMode.Text = "Mode";
            this.labelMode.Visible = false;
            // 
            // listBoxLoot
            // 
            this.listBoxLoot.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBoxLoot.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxLoot.FormattingEnabled = true;
            this.listBoxLoot.ItemHeight = 19;
            this.listBoxLoot.Location = new System.Drawing.Point(392, 406);
            this.listBoxLoot.Name = "listBoxLoot";
            this.listBoxLoot.Size = new System.Drawing.Size(663, 232);
            this.listBoxLoot.TabIndex = 21;
            this.listBoxLoot.Visible = false;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Items",
            "Currency",
            "Custom"});
            this.comboBoxMode.Location = new System.Drawing.Point(392, 98);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(205, 27);
            this.comboBoxMode.TabIndex = 22;
            this.comboBoxMode.Visible = false;
            // 
            // numericUpDownTimes
            // 
            this.numericUpDownTimes.Location = new System.Drawing.Point(392, 290);
            this.numericUpDownTimes.Name = "numericUpDownTimes";
            this.numericUpDownTimes.Size = new System.Drawing.Size(102, 27);
            this.numericUpDownTimes.TabIndex = 23;
            this.numericUpDownTimes.Visible = false;
            // 
            // numericUpDownRoll
            // 
            this.numericUpDownRoll.Location = new System.Drawing.Point(392, 223);
            this.numericUpDownRoll.Name = "numericUpDownRoll";
            this.numericUpDownRoll.Size = new System.Drawing.Size(102, 27);
            this.numericUpDownRoll.TabIndex = 24;
            this.numericUpDownRoll.Visible = false;
            // 
            // comboBoxDatabase
            // 
            this.comboBoxDatabase.FormattingEnabled = true;
            this.comboBoxDatabase.Items.AddRange(new object[] {
            "Items",
            "Currency",
            "Other database"});
            this.comboBoxDatabase.Location = new System.Drawing.Point(43, 186);
            this.comboBoxDatabase.Name = "comboBoxDatabase";
            this.comboBoxDatabase.Size = new System.Drawing.Size(168, 27);
            this.comboBoxDatabase.TabIndex = 25;
            // 
            // buttonSaveLoot
            // 
            this.buttonSaveLoot.Location = new System.Drawing.Point(566, 339);
            this.buttonSaveLoot.Name = "buttonSaveLoot";
            this.buttonSaveLoot.Size = new System.Drawing.Size(168, 38);
            this.buttonSaveLoot.TabIndex = 26;
            this.buttonSaveLoot.Text = "Save";
            this.buttonSaveLoot.UseVisualStyleBackColor = true;
            this.buttonSaveLoot.Visible = false;
            this.buttonSaveLoot.Click += new System.EventHandler(this.buttonSaveLoot_Click);
            // 
            // FormMainMneu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.buttonSaveLoot);
            this.Controls.Add(this.comboBoxDatabase);
            this.Controls.Add(this.numericUpDownRoll);
            this.Controls.Add(this.numericUpDownTimes);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.listBoxLoot);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.textBoxCharacterName);
            this.Controls.Add(this.buttonGiveLoot);
            this.Controls.Add(this.labelRoll);
            this.Controls.Add(this.labelTimes);
            this.Controls.Add(this.label1CharacterName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonOpenDatabase);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStart);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainMneu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonOpenDatabase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1CharacterName;
        private System.Windows.Forms.Label labelTimes;
        private System.Windows.Forms.Label labelRoll;
        private System.Windows.Forms.Button buttonGiveLoot;
        private System.Windows.Forms.TextBox textBoxCharacterName;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.ListBox listBoxLoot;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.NumericUpDown numericUpDownTimes;
        private System.Windows.Forms.NumericUpDown numericUpDownRoll;
        private System.Windows.Forms.ComboBox comboBoxDatabase;
        private System.Windows.Forms.Button buttonSaveLoot;
    }
}

