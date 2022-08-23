namespace JD_Dog_Care
{
    partial class UcHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcHome));
            this.rtxtUserGuide = new System.Windows.Forms.RichTextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAdminSettings = new System.Windows.Forms.Button();
            this.lblAdminSettings = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnServiceOptions = new System.Windows.Forms.Button();
            this.btnVaccinations = new System.Windows.Forms.Button();
            this.btnSOAdd = new System.Windows.Forms.Button();
            this.btnVAdd = new System.Windows.Forms.Button();
            this.btnSOUpdate = new System.Windows.Forms.Button();
            this.btnVUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtUserGuide
            // 
            this.rtxtUserGuide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.rtxtUserGuide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtUserGuide.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.rtxtUserGuide.ForeColor = System.Drawing.Color.White;
            this.rtxtUserGuide.Location = new System.Drawing.Point(25, 76);
            this.rtxtUserGuide.Name = "rtxtUserGuide";
            this.rtxtUserGuide.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtUserGuide.Size = new System.Drawing.Size(710, 474);
            this.rtxtUserGuide.TabIndex = 0;
            this.rtxtUserGuide.Text = resources.GetString("rtxtUserGuide.Text");
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 21);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(535, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to the JD Dog Care Administration System";
            // 
            // btnAdminSettings
            // 
            this.btnAdminSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnAdminSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminSettings.FlatAppearance.BorderSize = 0;
            this.btnAdminSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminSettings.Image = global::JD_Dog_Care.Properties.Resources.AdminSettings_Symbol;
            this.btnAdminSettings.Location = new System.Drawing.Point(707, 6);
            this.btnAdminSettings.Name = "btnAdminSettings";
            this.btnAdminSettings.Size = new System.Drawing.Size(48, 50);
            this.btnAdminSettings.TabIndex = 2;
            this.btnAdminSettings.UseVisualStyleBackColor = false;
            this.btnAdminSettings.Click += new System.EventHandler(this.BtnAdminSettings_Click);
            this.btnAdminSettings.MouseLeave += new System.EventHandler(this.BtnAdminSettings_MouseLeave);
            this.btnAdminSettings.MouseHover += new System.EventHandler(this.BtnAdminSettings_MouseHover);
            // 
            // lblAdminSettings
            // 
            this.lblAdminSettings.AutoSize = true;
            this.lblAdminSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminSettings.Location = new System.Drawing.Point(589, 20);
            this.lblAdminSettings.Name = "lblAdminSettings";
            this.lblAdminSettings.Size = new System.Drawing.Size(123, 19);
            this.lblAdminSettings.TabIndex = 3;
            this.lblAdminSettings.Text = "Admin Settings";
            this.lblAdminSettings.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(15, 530);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(51, 35);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnServiceOptions
            // 
            this.btnServiceOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.btnServiceOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServiceOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceOptions.Font = new System.Drawing.Font("Century Gothic", 19F, System.Drawing.FontStyle.Bold);
            this.btnServiceOptions.Location = new System.Drawing.Point(430, 135);
            this.btnServiceOptions.Name = "btnServiceOptions";
            this.btnServiceOptions.Size = new System.Drawing.Size(260, 60);
            this.btnServiceOptions.TabIndex = 13;
            this.btnServiceOptions.Text = "Service Options";
            this.btnServiceOptions.UseVisualStyleBackColor = false;
            this.btnServiceOptions.Visible = false;
            this.btnServiceOptions.Click += new System.EventHandler(this.BtnServiceOptions_Click);
            // 
            // btnVaccinations
            // 
            this.btnVaccinations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.btnVaccinations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaccinations.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVaccinations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaccinations.Font = new System.Drawing.Font("Century Gothic", 19F, System.Drawing.FontStyle.Bold);
            this.btnVaccinations.Location = new System.Drawing.Point(70, 135);
            this.btnVaccinations.Name = "btnVaccinations";
            this.btnVaccinations.Size = new System.Drawing.Size(260, 60);
            this.btnVaccinations.TabIndex = 14;
            this.btnVaccinations.Text = "Vaccinations";
            this.btnVaccinations.UseVisualStyleBackColor = false;
            this.btnVaccinations.Visible = false;
            this.btnVaccinations.Click += new System.EventHandler(this.BtnVaccinations_Click);
            // 
            // btnSOAdd
            // 
            this.btnSOAdd.BackColor = System.Drawing.Color.Green;
            this.btnSOAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSOAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSOAdd.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSOAdd.Location = new System.Drawing.Point(450, 225);
            this.btnSOAdd.Name = "btnSOAdd";
            this.btnSOAdd.Size = new System.Drawing.Size(210, 50);
            this.btnSOAdd.TabIndex = 15;
            this.btnSOAdd.Text = "Add";
            this.btnSOAdd.UseVisualStyleBackColor = false;
            this.btnSOAdd.Visible = false;
            this.btnSOAdd.Click += new System.EventHandler(this.BtnSOAdd_Click);
            // 
            // btnVAdd
            // 
            this.btnVAdd.BackColor = System.Drawing.Color.Green;
            this.btnVAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVAdd.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVAdd.Location = new System.Drawing.Point(90, 225);
            this.btnVAdd.Name = "btnVAdd";
            this.btnVAdd.Size = new System.Drawing.Size(210, 50);
            this.btnVAdd.TabIndex = 16;
            this.btnVAdd.Text = "Add";
            this.btnVAdd.UseVisualStyleBackColor = false;
            this.btnVAdd.Visible = false;
            this.btnVAdd.Click += new System.EventHandler(this.BtnVAdd_Click);
            // 
            // btnSOUpdate
            // 
            this.btnSOUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnSOUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSOUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSOUpdate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSOUpdate.Location = new System.Drawing.Point(450, 300);
            this.btnSOUpdate.Name = "btnSOUpdate";
            this.btnSOUpdate.Size = new System.Drawing.Size(210, 50);
            this.btnSOUpdate.TabIndex = 17;
            this.btnSOUpdate.Text = "Update";
            this.btnSOUpdate.UseVisualStyleBackColor = false;
            this.btnSOUpdate.Visible = false;
            this.btnSOUpdate.Click += new System.EventHandler(this.BtnSOUpdate_Click);
            // 
            // btnVUpdate
            // 
            this.btnVUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnVUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVUpdate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVUpdate.Location = new System.Drawing.Point(90, 300);
            this.btnVUpdate.Name = "btnVUpdate";
            this.btnVUpdate.Size = new System.Drawing.Size(210, 50);
            this.btnVUpdate.TabIndex = 18;
            this.btnVUpdate.Text = "Update";
            this.btnVUpdate.UseVisualStyleBackColor = false;
            this.btnVUpdate.Visible = false;
            this.btnVUpdate.Click += new System.EventHandler(this.BtnVUpdate_Click);
            // 
            // UcHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.btnVUpdate);
            this.Controls.Add(this.btnSOUpdate);
            this.Controls.Add(this.btnVAdd);
            this.Controls.Add(this.btnSOAdd);
            this.Controls.Add(this.btnVaccinations);
            this.Controls.Add(this.btnServiceOptions);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAdminSettings);
            this.Controls.Add(this.btnAdminSettings);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.rtxtUserGuide);
            this.Name = "UcHome";
            this.Size = new System.Drawing.Size(760, 580);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtxtUserGuide;
        public System.Windows.Forms.Label lblWelcome;
        public System.Windows.Forms.Button btnAdminSettings;
        public System.Windows.Forms.Label lblAdminSettings;
        public System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Button btnServiceOptions;
        public System.Windows.Forms.Button btnVaccinations;
        public System.Windows.Forms.Button btnSOAdd;
        public System.Windows.Forms.Button btnVAdd;
        public System.Windows.Forms.Button btnSOUpdate;
        public System.Windows.Forms.Button btnVUpdate;
    }
}
