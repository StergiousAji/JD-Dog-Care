namespace JD_Dog_Care
{
    partial class UcStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcStaff));
            this.btnStaff = new System.Windows.Forms.Button();
            this.lblSex = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblJobContract = new System.Windows.Forms.Label();
            this.lblJobPosition = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblDateJoined = new System.Windows.Forms.Label();
            this.chbPartTime = new System.Windows.Forms.CheckBox();
            this.chbFullTime = new System.Windows.Forms.CheckBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.dtpDateJoined = new System.Windows.Forms.DateTimePicker();
            this.nupSalary = new System.Windows.Forms.NumericUpDown();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.cbJobPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Location = new System.Drawing.Point(273, 450);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(215, 50);
            this.btnStaff.TabIndex = 16;
            this.btnStaff.Text = "Register";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.ForeColor = System.Drawing.Color.White;
            this.lblSex.Location = new System.Drawing.Point(30, 243);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(40, 21);
            this.lblSex.TabIndex = 46;
            this.lblSex.Text = "Sex:";
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbSex.Location = new System.Drawing.Point(152, 239);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(135, 27);
            this.cbSex.TabIndex = 4;
            this.cbSex.TextChanged += new System.EventHandler(this.CbSex_TextChanged);
            // 
            // txtForename
            // 
            this.txtForename.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(152, 146);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(210, 27);
            this.txtForename.TabIndex = 2;
            this.txtForename.TextChanged += new System.EventHandler(this.TxtForename_TextChanged);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.ForeColor = System.Drawing.Color.White;
            this.lblForename.Location = new System.Drawing.Point(30, 149);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(93, 21);
            this.lblForename.TabIndex = 45;
            this.lblForename.Text = "Forename:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.White;
            this.lblDOB.Location = new System.Drawing.Point(30, 290);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(115, 21);
            this.lblDOB.TabIndex = 50;
            this.lblDOB.Text = "Date Of Birth:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(400, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 21);
            this.lblEmail.TabIndex = 47;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(152, 192);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(210, 27);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.TextChanged += new System.EventHandler(this.TxtSurname_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(522, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 27);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.White;
            this.lblSurname.Location = new System.Drawing.Point(30, 194);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(83, 21);
            this.lblSurname.TabIndex = 49;
            this.lblSurname.Text = "Surname:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(30, 339);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 21);
            this.lblAddress.TabIndex = 48;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(152, 336);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(210, 27);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.TextChanged += new System.EventHandler(this.TxtAddress_TextChanged);
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.ForeColor = System.Drawing.Color.White;
            this.lblPostcode.Location = new System.Drawing.Point(400, 105);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(87, 21);
            this.lblPostcode.TabIndex = 52;
            this.lblPostcode.Text = "Postcode:";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(522, 102);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(135, 27);
            this.txtPostcode.TabIndex = 8;
            this.txtPostcode.TextChanged += new System.EventHandler(this.TxtPostcode_TextChanged);
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNo.Location = new System.Drawing.Point(400, 195);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(89, 21);
            this.lblPhoneNo.TabIndex = 54;
            this.lblPhoneNo.Text = "Phone No:";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(522, 192);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(210, 27);
            this.txtPhoneNo.TabIndex = 10;
            this.txtPhoneNo.TextChanged += new System.EventHandler(this.TxtPhoneNo_TextChanged);
            // 
            // txtStaffID
            // 
            this.txtStaffID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtStaffID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(152, 101);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(115, 27);
            this.txtStaffID.TabIndex = 1;
            this.txtStaffID.TextChanged += new System.EventHandler(this.TxtStaffID_TextChanged);
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.lblStaffID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.ForeColor = System.Drawing.Color.White;
            this.lblStaffID.Location = new System.Drawing.Point(30, 104);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(67, 21);
            this.lblStaffID.TabIndex = 56;
            this.lblStaffID.Text = "StaffID:";
            // 
            // lblJobContract
            // 
            this.lblJobContract.AutoSize = true;
            this.lblJobContract.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobContract.ForeColor = System.Drawing.Color.White;
            this.lblJobContract.Location = new System.Drawing.Point(400, 241);
            this.lblJobContract.Name = "lblJobContract";
            this.lblJobContract.Size = new System.Drawing.Size(87, 21);
            this.lblJobContract.TabIndex = 58;
            this.lblJobContract.Text = "Contract:";
            // 
            // lblJobPosition
            // 
            this.lblJobPosition.AutoSize = true;
            this.lblJobPosition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobPosition.ForeColor = System.Drawing.Color.White;
            this.lblJobPosition.Location = new System.Drawing.Point(400, 290);
            this.lblJobPosition.Name = "lblJobPosition";
            this.lblJobPosition.Size = new System.Drawing.Size(72, 21);
            this.lblJobPosition.TabIndex = 60;
            this.lblJobPosition.Text = "Position:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.White;
            this.lblSalary.Location = new System.Drawing.Point(400, 338);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(60, 21);
            this.lblSalary.TabIndex = 62;
            this.lblSalary.Text = "Salary:";
            // 
            // lblDateJoined
            // 
            this.lblDateJoined.AutoSize = true;
            this.lblDateJoined.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateJoined.ForeColor = System.Drawing.Color.White;
            this.lblDateJoined.Location = new System.Drawing.Point(400, 385);
            this.lblDateJoined.Name = "lblDateJoined";
            this.lblDateJoined.Size = new System.Drawing.Size(110, 21);
            this.lblDateJoined.TabIndex = 64;
            this.lblDateJoined.Text = "Date Joined:";
            // 
            // chbPartTime
            // 
            this.chbPartTime.AutoSize = true;
            this.chbPartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbPartTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPartTime.ForeColor = System.Drawing.Color.White;
            this.chbPartTime.Location = new System.Drawing.Point(633, 241);
            this.chbPartTime.Name = "chbPartTime";
            this.chbPartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbPartTime.Size = new System.Drawing.Size(99, 25);
            this.chbPartTime.TabIndex = 12;
            this.chbPartTime.Text = "Part-Time";
            this.chbPartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbPartTime.UseVisualStyleBackColor = true;
            this.chbPartTime.Click += new System.EventHandler(this.ChbPartTime_Click);
            // 
            // chbFullTime
            // 
            this.chbFullTime.AutoSize = true;
            this.chbFullTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbFullTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFullTime.ForeColor = System.Drawing.Color.White;
            this.chbFullTime.Location = new System.Drawing.Point(525, 240);
            this.chbFullTime.Name = "chbFullTime";
            this.chbFullTime.Size = new System.Drawing.Size(91, 25);
            this.chbFullTime.TabIndex = 11;
            this.chbFullTime.Text = "Full-Time";
            this.chbFullTime.UseVisualStyleBackColor = true;
            this.chbFullTime.Click += new System.EventHandler(this.ChbFullTime_Click);
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
            this.btnPrevious.TabIndex = 17;
            this.btnPrevious.Text = "🞀";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "🞂";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
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
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete Staff";
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
            this.txtSearch.TabIndex = 18;
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
            this.btnSearch.TabIndex = 19;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(152, 287);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(210, 27);
            this.dtpDOB.TabIndex = 5;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.DtpDOB_ValueChanged);
            // 
            // dtpDateJoined
            // 
            this.dtpDateJoined.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateJoined.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateJoined.Location = new System.Drawing.Point(522, 383);
            this.dtpDateJoined.Name = "dtpDateJoined";
            this.dtpDateJoined.Size = new System.Drawing.Size(210, 27);
            this.dtpDateJoined.TabIndex = 15;
            this.dtpDateJoined.ValueChanged += new System.EventHandler(this.DtpDateJoined_ValueChanged);
            // 
            // nupSalary
            // 
            this.nupSalary.DecimalPlaces = 2;
            this.nupSalary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupSalary.Location = new System.Drawing.Point(522, 336);
            this.nupSalary.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nupSalary.Name = "nupSalary";
            this.nupSalary.Size = new System.Drawing.Size(120, 27);
            this.nupSalary.TabIndex = 14;
            this.nupSalary.ValueChanged += new System.EventHandler(this.NupSalary_ValueChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(30, 385);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(94, 21);
            this.lblCity.TabIndex = 67;
            this.lblCity.Text = "City/Town:";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(152, 383);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(210, 27);
            this.txtCity.TabIndex = 7;
            this.txtCity.TextChanged += new System.EventHandler(this.TxtCity_TextChanged);
            // 
            // cbJobPosition
            // 
            this.cbJobPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobPosition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJobPosition.FormattingEnabled = true;
            this.cbJobPosition.Items.AddRange(new object[] {
            "Management",
            "Administration",
            "Grooming"});
            this.cbJobPosition.Location = new System.Drawing.Point(522, 290);
            this.cbJobPosition.Name = "cbJobPosition";
            this.cbJobPosition.Size = new System.Drawing.Size(210, 27);
            this.cbJobPosition.TabIndex = 13;
            this.cbJobPosition.TextChanged += new System.EventHandler(this.CbJobPosition);
            // 
            // UcStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.cbJobPosition);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.nupSalary);
            this.Controls.Add(this.dtpDateJoined);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.chbPartTime);
            this.Controls.Add(this.chbFullTime);
            this.Controls.Add(this.lblDateJoined);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblJobPosition);
            this.Controls.Add(this.lblJobContract);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Name = "UcStaff";
            this.Size = new System.Drawing.Size(760, 550);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblJobContract;
        private System.Windows.Forms.Label lblJobPosition;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblDateJoined;
        private System.Windows.Forms.CheckBox chbPartTime;
        private System.Windows.Forms.CheckBox chbFullTime;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpDateJoined;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.NumericUpDown nupSalary;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.ComboBox cbJobPosition;
    }
}
