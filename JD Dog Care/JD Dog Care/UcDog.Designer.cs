namespace JD_Dog_Care
{
    partial class UcDog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDog));
            this.btnDog = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtDogID = new System.Windows.Forms.TextBox();
            this.lblDogID = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.pbDogProfile = new System.Windows.Forms.PictureBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblClientName = new System.Windows.Forms.Label();
            this.cbClientName = new System.Windows.Forms.ComboBox();
            this.btnViewVaccinationHistory = new System.Windows.Forms.Button();
            this.rtxtMedicalNotes = new System.Windows.Forms.RichTextBox();
            this.lblMedicalNotes = new System.Windows.Forms.Label();
            this.btnViewMedicalNotes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDog
            // 
            this.btnDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDog.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDog.Location = new System.Drawing.Point(273, 450);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(215, 50);
            this.btnDog.TabIndex = 10;
            this.btnDog.Text = "Register";
            this.btnDog.UseVisualStyleBackColor = false;
            this.btnDog.Click += new System.EventHandler(this.BtnDog_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(487, 201);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 27);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(365, 202);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 21);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.lblSex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.ForeColor = System.Drawing.Color.White;
            this.lblSex.Location = new System.Drawing.Point(365, 292);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(40, 21);
            this.lblSex.TabIndex = 36;
            this.lblSex.Text = "Sex:";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.lblBreed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreed.ForeColor = System.Drawing.Color.White;
            this.lblBreed.Location = new System.Drawing.Point(365, 245);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(59, 21);
            this.lblBreed.TabIndex = 37;
            this.lblBreed.Text = "Breed:";
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbSex.Location = new System.Drawing.Point(487, 288);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(135, 27);
            this.cbSex.TabIndex = 6;
            this.cbSex.TextChanged += new System.EventHandler(this.CbSex_TextChanged);
            // 
            // txtBreed
            // 
            this.txtBreed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreed.Location = new System.Drawing.Point(487, 244);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(210, 27);
            this.txtBreed.TabIndex = 5;
            this.txtBreed.TextChanged += new System.EventHandler(this.TxtBreed_TextChanged);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(487, 333);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(210, 27);
            this.dtpDOB.TabIndex = 7;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.DtpDOB_ValueChanged);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.lblDOB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.White;
            this.lblDOB.Location = new System.Drawing.Point(365, 338);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(115, 21);
            this.lblDOB.TabIndex = 38;
            this.lblDOB.Text = "Date Of Birth:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnPrevious.Location = new System.Drawing.Point(10, 10);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(39, 52);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.Text = "🞀";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnNext.Location = new System.Drawing.Point(711, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(39, 52);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "🞂";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // txtDogID
            // 
            this.txtDogID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtDogID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDogID.Location = new System.Drawing.Point(487, 75);
            this.txtDogID.Name = "txtDogID";
            this.txtDogID.ReadOnly = true;
            this.txtDogID.Size = new System.Drawing.Size(115, 27);
            this.txtDogID.TabIndex = 1;
            this.txtDogID.TextChanged += new System.EventHandler(this.TxtDogID_TextChanged);
            // 
            // lblDogID
            // 
            this.lblDogID.AutoSize = true;
            this.lblDogID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.lblDogID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogID.ForeColor = System.Drawing.Color.White;
            this.lblDogID.Location = new System.Drawing.Point(365, 78);
            this.lblDogID.Name = "lblDogID";
            this.lblDogID.Size = new System.Drawing.Size(64, 21);
            this.lblDogID.TabIndex = 42;
            this.lblDogID.Text = "DogID:";
            // 
            // txtClientID
            // 
            this.txtClientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtClientID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.Location = new System.Drawing.Point(487, 117);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(115, 27);
            this.txtClientID.TabIndex = 2;
            this.txtClientID.TextChanged += new System.EventHandler(this.TxtClientID_TextChanged);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.lblClientID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.ForeColor = System.Drawing.Color.White;
            this.lblClientID.Location = new System.Drawing.Point(365, 121);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(77, 21);
            this.lblClientID.TabIndex = 44;
            this.lblClientID.Text = "ClientID:";
            // 
            // pbDogProfile
            // 
            this.pbDogProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDogProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.pbDogProfile.Location = new System.Drawing.Point(40, 105);
            this.pbDogProfile.Name = "pbDogProfile";
            this.pbDogProfile.Size = new System.Drawing.Size(265, 280);
            this.pbDogProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDogProfile.TabIndex = 40;
            this.pbDogProfile.TabStop = false;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            this.ep.Icon = ((System.Drawing.Icon)(resources.GetObject("ep.Icon")));
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(635, 495);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 35);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete Dog";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(267, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 27);
            this.txtSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(467, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 27);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.lblClientName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.Color.White;
            this.lblClientName.Location = new System.Drawing.Point(365, 159);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(112, 21);
            this.lblClientName.TabIndex = 47;
            this.lblClientName.Text = "Client Name:";
            // 
            // cbClientName
            // 
            this.cbClientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbClientName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClientName.FormattingEnabled = true;
            this.cbClientName.Location = new System.Drawing.Point(487, 159);
            this.cbClientName.Name = "cbClientName";
            this.cbClientName.Size = new System.Drawing.Size(210, 27);
            this.cbClientName.TabIndex = 3;
            this.cbClientName.TextChanged += new System.EventHandler(this.CbClientName_TextChanged);
            // 
            // btnViewVaccinationHistory
            // 
            this.btnViewVaccinationHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.btnViewVaccinationHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewVaccinationHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewVaccinationHistory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewVaccinationHistory.ForeColor = System.Drawing.Color.Black;
            this.btnViewVaccinationHistory.Location = new System.Drawing.Point(20, 470);
            this.btnViewVaccinationHistory.Name = "btnViewVaccinationHistory";
            this.btnViewVaccinationHistory.Size = new System.Drawing.Size(134, 60);
            this.btnViewVaccinationHistory.TabIndex = 15;
            this.btnViewVaccinationHistory.Text = "View Vaccination History";
            this.btnViewVaccinationHistory.UseVisualStyleBackColor = false;
            this.btnViewVaccinationHistory.Click += new System.EventHandler(this.BtnViewVaccinationHistory_Click);
            // 
            // rtxtMedicalNotes
            // 
            this.rtxtMedicalNotes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMedicalNotes.Location = new System.Drawing.Point(40, 135);
            this.rtxtMedicalNotes.MaxLength = 1000;
            this.rtxtMedicalNotes.Name = "rtxtMedicalNotes";
            this.rtxtMedicalNotes.Size = new System.Drawing.Size(265, 220);
            this.rtxtMedicalNotes.TabIndex = 16;
            this.rtxtMedicalNotes.Text = "";
            this.rtxtMedicalNotes.TextChanged += new System.EventHandler(this.RtxtDietaryRequirements_TextChanged);
            // 
            // lblMedicalNotes
            // 
            this.lblMedicalNotes.AutoSize = true;
            this.lblMedicalNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.lblMedicalNotes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalNotes.ForeColor = System.Drawing.Color.White;
            this.lblMedicalNotes.Location = new System.Drawing.Point(36, 105);
            this.lblMedicalNotes.Name = "lblMedicalNotes";
            this.lblMedicalNotes.Size = new System.Drawing.Size(126, 21);
            this.lblMedicalNotes.TabIndex = 49;
            this.lblMedicalNotes.Text = "Medical Notes:";
            // 
            // btnViewMedicalNotes
            // 
            this.btnViewMedicalNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.btnViewMedicalNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMedicalNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMedicalNotes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicalNotes.ForeColor = System.Drawing.Color.Black;
            this.btnViewMedicalNotes.Location = new System.Drawing.Point(367, 381);
            this.btnViewMedicalNotes.Name = "btnViewMedicalNotes";
            this.btnViewMedicalNotes.Size = new System.Drawing.Size(330, 36);
            this.btnViewMedicalNotes.TabIndex = 50;
            this.btnViewMedicalNotes.Text = "View Medical Notes";
            this.btnViewMedicalNotes.UseVisualStyleBackColor = false;
            this.btnViewMedicalNotes.Click += new System.EventHandler(this.BtnViewMedicalNotes_Click);
            // 
            // UcDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.btnViewMedicalNotes);
            this.Controls.Add(this.lblMedicalNotes);
            this.Controls.Add(this.rtxtMedicalNotes);
            this.Controls.Add(this.btnViewVaccinationHistory);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtDogID);
            this.Controls.Add(this.lblDogID);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pbDogProfile);
            this.Controls.Add(this.btnDog);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.cbClientName);
            this.Name = "UcDog";
            this.Size = new System.Drawing.Size(760, 550);
            ((System.ComponentModel.ISupportInitialize)(this.pbDogProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDog;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.PictureBox pbDogProfile;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtDogID;
        private System.Windows.Forms.Label lblDogID;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.ComboBox cbClientName;
        private System.Windows.Forms.Button btnViewVaccinationHistory;
        private System.Windows.Forms.Label lblMedicalNotes;
        private System.Windows.Forms.RichTextBox rtxtMedicalNotes;
        private System.Windows.Forms.Button btnViewMedicalNotes;
    }
}
