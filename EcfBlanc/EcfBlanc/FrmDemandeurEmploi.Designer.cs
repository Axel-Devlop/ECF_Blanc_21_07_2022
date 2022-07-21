namespace EcfBlanc
{
    partial class FrmDemandeurEmploi
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
            this.btnValidation = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastDiplomaDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLastDiplomaName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.cbTrainingLevel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidation
            // 
            this.btnValidation.Location = new System.Drawing.Point(247, 436);
            this.btnValidation.Name = "btnValidation";
            this.btnValidation.Size = new System.Drawing.Size(118, 33);
            this.btnValidation.TabIndex = 7;
            this.btnValidation.Text = "Valider";
            this.btnValidation.UseVisualStyleBackColor = true;
            this.btnValidation.Click += new System.EventHandler(this.btnValidation_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLastName.Location = new System.Drawing.Point(175, 45);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(177, 29);
            this.tbLastName.TabIndex = 1;
            this.tbLastName.Text = "Jean";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prénom";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFirstName.Location = new System.Drawing.Point(175, 96);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(177, 29);
            this.tbFirstName.TabIndex = 2;
            this.tbFirstName.Text = "Proutex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date du dernier diplôme";
            // 
            // tbLastDiplomaDate
            // 
            this.tbLastDiplomaDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLastDiplomaDate.Location = new System.Drawing.Point(173, 323);
            this.tbLastDiplomaDate.Name = "tbLastDiplomaDate";
            this.tbLastDiplomaDate.Size = new System.Drawing.Size(177, 29);
            this.tbLastDiplomaDate.TabIndex = 6;
            this.tbLastDiplomaDate.Text = "1960";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nom du dernier diplôme";
            // 
            // tbLastDiplomaName
            // 
            this.tbLastDiplomaName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLastDiplomaName.Location = new System.Drawing.Point(173, 272);
            this.tbLastDiplomaName.Name = "tbLastDiplomaName";
            this.tbLastDiplomaName.Size = new System.Drawing.Size(177, 29);
            this.tbLastDiplomaName.TabIndex = 5;
            this.tbLastDiplomaName.Text = "Bac de droite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date d\'inscription";
            // 
            // tb
            // 
            this.tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb.Location = new System.Drawing.Point(175, 151);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(177, 29);
            this.tb.TabIndex = 3;
            this.tb.Text = "1980";
            // 
            // cbTrainingLevel
            // 
            this.cbTrainingLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrainingLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTrainingLevel.FormattingEnabled = true;
            this.cbTrainingLevel.Items.AddRange(new object[] {
            "InfBac",
            "Bac",
            "Bac+1",
            "Bac+2",
            "Bac+3",
            "Bac+4",
            "Bac+5",
            "SupBac+5"});
            this.cbTrainingLevel.Location = new System.Drawing.Point(173, 212);
            this.cbTrainingLevel.Name = "cbTrainingLevel";
            this.cbTrainingLevel.Size = new System.Drawing.Size(177, 29);
            this.cbTrainingLevel.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Niveau de formation";
            // 
            // FrmDemandeurEmploi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 491);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTrainingLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLastDiplomaDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLastDiplomaName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.btnValidation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDemandeurEmploi";
            this.Text = "JobFinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnValidation;
        private TextBox tbLastName;
        private Label label1;
        private Label label2;
        private TextBox tbFirstName;
        private Label label3;
        private TextBox tbLastDiplomaDate;
        private Label label4;
        private TextBox tbLastDiplomaName;
        private Label label5;
        private TextBox tb;
        private ComboBox cbTrainingLevel;
        private Label label6;
    }
}