namespace janjaninRobertGui
{
    partial class FormCreateTour
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTourName = new System.Windows.Forms.TextBox();
            this.textBoxEntryFee = new System.Windows.Forms.TextBox();
            this.comboBoxSelectTeam = new System.Windows.Forms.ComboBox();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonCreatePrize = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxTeams = new System.Windows.Forms.RichTextBox();
            this.buttonDeletePlayers = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonDeletePrizes = new System.Windows.Forms.Button();
            this.buttonCreateTour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Tournament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(51, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tournament Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(51, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entry Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(51, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select team";
            // 
            // textBoxTourName
            // 
            this.textBoxTourName.Location = new System.Drawing.Point(54, 96);
            this.textBoxTourName.Name = "textBoxTourName";
            this.textBoxTourName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTourName.TabIndex = 4;
            // 
            // textBoxEntryFee
            // 
            this.textBoxEntryFee.Location = new System.Drawing.Point(115, 140);
            this.textBoxEntryFee.Name = "textBoxEntryFee";
            this.textBoxEntryFee.Size = new System.Drawing.Size(60, 20);
            this.textBoxEntryFee.TabIndex = 5;
            // 
            // comboBoxSelectTeam
            // 
            this.comboBoxSelectTeam.FormattingEnabled = true;
            this.comboBoxSelectTeam.Location = new System.Drawing.Point(54, 213);
            this.comboBoxSelectTeam.Name = "comboBoxSelectTeam";
            this.comboBoxSelectTeam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectTeam.TabIndex = 6;
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(58, 260);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(96, 28);
            this.buttonAddTeam.TabIndex = 7;
            this.buttonAddTeam.Text = "Add Team";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            // 
            // buttonCreatePrize
            // 
            this.buttonCreatePrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonCreatePrize.Location = new System.Drawing.Point(74, 317);
            this.buttonCreatePrize.Name = "buttonCreatePrize";
            this.buttonCreatePrize.Size = new System.Drawing.Size(80, 55);
            this.buttonCreatePrize.TabIndex = 8;
            this.buttonCreatePrize.Text = "Create Prize";
            this.buttonCreatePrize.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(434, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teams/players";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(434, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prizes";
            // 
            // richTextBoxTeams
            // 
            this.richTextBoxTeams.Location = new System.Drawing.Point(437, 59);
            this.richTextBoxTeams.Name = "richTextBoxTeams";
            this.richTextBoxTeams.Size = new System.Drawing.Size(171, 94);
            this.richTextBoxTeams.TabIndex = 11;
            this.richTextBoxTeams.Text = "";
            // 
            // buttonDeletePlayers
            // 
            this.buttonDeletePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.buttonDeletePlayers.Location = new System.Drawing.Point(642, 80);
            this.buttonDeletePlayers.Name = "buttonDeletePlayers";
            this.buttonDeletePlayers.Size = new System.Drawing.Size(97, 48);
            this.buttonDeletePlayers.TabIndex = 12;
            this.buttonDeletePlayers.Text = "Delete selected";
            this.buttonDeletePlayers.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(437, 265);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(171, 116);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // buttonDeletePrizes
            // 
            this.buttonDeletePrizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.buttonDeletePrizes.Location = new System.Drawing.Point(642, 299);
            this.buttonDeletePrizes.Name = "buttonDeletePrizes";
            this.buttonDeletePrizes.Size = new System.Drawing.Size(97, 55);
            this.buttonDeletePrizes.TabIndex = 14;
            this.buttonDeletePrizes.Text = "Delete selected";
            this.buttonDeletePrizes.UseVisualStyleBackColor = true;
            // 
            // buttonCreateTour
            // 
            this.buttonCreateTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonCreateTour.Location = new System.Drawing.Point(424, 402);
            this.buttonCreateTour.Name = "buttonCreateTour";
            this.buttonCreateTour.Size = new System.Drawing.Size(215, 36);
            this.buttonCreateTour.TabIndex = 15;
            this.buttonCreateTour.Text = "Create Tournament";
            this.buttonCreateTour.UseVisualStyleBackColor = true;
            // 
            // FormCreateTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateTour);
            this.Controls.Add(this.buttonDeletePrizes);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonDeletePlayers);
            this.Controls.Add(this.richTextBoxTeams);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCreatePrize);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.comboBoxSelectTeam);
            this.Controls.Add(this.textBoxEntryFee);
            this.Controls.Add(this.textBoxTourName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateTour";
            this.Text = "FormCreateTour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTourName;
        private System.Windows.Forms.TextBox textBoxEntryFee;
        private System.Windows.Forms.ComboBox comboBoxSelectTeam;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonCreatePrize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxTeams;
        private System.Windows.Forms.Button buttonDeletePlayers;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonDeletePrizes;
        private System.Windows.Forms.Button buttonCreateTour;
    }
}