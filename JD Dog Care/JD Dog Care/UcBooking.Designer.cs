namespace JD_Dog_Care
{
    partial class UcBooking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBooking));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.lblDogName = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblClientName = new System.Windows.Forms.Label();
            this.cbClientName = new System.Windows.Forms.ComboBox();
            this.lblServiceOption = new System.Windows.Forms.Label();
            this.cbServiceOptionNo = new System.Windows.Forms.ComboBox();
            this.txtBookingNo = new System.Windows.Forms.TextBox();
            this.lblBookingNo = new System.Windows.Forms.Label();
            this.cbDogName = new System.Windows.Forms.ComboBox();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.cbStaffName = new System.Windows.Forms.ComboBox();
            this.chbExtraOption = new System.Windows.Forms.CheckBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
            this.lblDateCreated = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(146, 242);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(210, 27);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.ValueChanged += new System.EventHandler(this.DtpDate_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(77)))), ((int)(((byte)(37)))));
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(24, 248);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 21);
            this.lblDate.TabIndex = 71;
            this.lblDate.Text = "Date:";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "hh:mm tt";
            this.dtpStartTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(146, 294);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(98, 27);
            this.dtpStartTime.TabIndex = 4;
            this.dtpStartTime.Value = new System.DateTime(2020, 3, 12, 9, 0, 0, 0);
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.DtpStartTime_ValueChanged);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(77)))), ((int)(((byte)(37)))));
            this.lblStartTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.Color.White;
            this.lblStartTime.Location = new System.Drawing.Point(24, 298);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(92, 21);
            this.lblStartTime.TabIndex = 73;
            this.lblStartTime.Text = "Start Time:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(77)))), ((int)(((byte)(37)))));
            this.lblDuration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(382, 176);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(82, 21);
            this.lblDuration.TabIndex = 75;
            this.lblDuration.Text = "Duration:";
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.btnBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(263, 400);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(241, 50);
            this.btnBooking.TabIndex = 7;
            this.btnBooking.Text = "Create Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.BtnBooking_Click);
            // 
            // lblDogName
            // 
            this.lblDogName.AutoSize = true;
            this.lblDogName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(77)))), ((int)(((byte)(37)))));
            this.lblDogName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogName.ForeColor = System.Drawing.Color.White;
            this.lblDogName.Location = new System.Drawing.Point(24, 142);
            this.lblDogName.Name = "lblDogName";
            this.lblDogName.Size = new System.Drawing.Size(99, 21);
            this.lblDogName.TabIndex = 78;
            this.lblDogName.Text = "Dog Name:";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            this.ep.Icon = ((System.Drawing.Icon)(resources.GetObject("ep.Icon")));
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(77)))), ((int)(((byte)(37)))));
            this.lblClientName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.Color.White;
            this.lblClientName.Location = new System.Drawing.Point(24, 194);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(112, 21);
            this.lblClientName.TabIndex = 80;
            this.lblClientName.Text = "Client Name:";
            // 
            // cbClientName
            // 
            this.cbClientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClientName.FormattingEnabled = true;
            this.cbClientName.Location = new System.Drawing.Point(146, 192);
            this.cbClientName.Name = "cbClientName";
            this.cbClientName.Size = new System.Drawing.Size(210, 27);
            this.cbClientName.TabIndex = 2;
            this.cbClientName.TextChanged += new System.EventHandler(this.CbClientName_TextChanged);
            // 
            // lblServiceOption
            // 
            this.lblServiceOption.AutoSize = true;
            this.lblServiceOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(77)))), ((int)(((byte)(37)))));
            this.lblServiceOption.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceOption.ForeColor = System.Drawing.Color.White;
            this.lblServiceOption.Location = new System.Drawing.Point(382, 88);
            this.lblServiceOption.Name = "lblServiceOption";
            this.lblServiceOption.Size = new System.Drawing.Size(70, 42);
            this.lblServiceOption.TabIndex = 82;
            this.lblServiceOption.Text = "Service \r\nOption:";
            // 
            // cbServiceOptionNo
            // 
            this.cbServiceOptionNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServiceOptionNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServiceOptionNo.FormattingEnabled = true;
            this.cbServiceOptionNo.Location = new System.Drawing.Point(504, 93);
            this.cbServiceOptionNo.Name = "cbServiceOptionNo";
            this.cbServiceOptionNo.Size = new System.Drawing.Size(210, 27);
            this.cbServiceOptionNo.TabIndex = 6;
            this.cbServiceOptionNo.TextChanged += new System.EventHandler(this.CbServiceOptionNo_TextChanged);
            // 
            // txtBookingNo
            // 
            this.txtBookingNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtBookingNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingNo.Location = new System.Drawing.Point(146, 90);
            this.txtBookingNo.Name = "txtBookingNo";
            this.txtBookingNo.ReadOnly = true;
            this.txtBookingNo.Size = new System.Drawing.Size(115, 27);
            this.txtBookingNo.TabIndex = 84;
            this.txtBookingNo.TextChanged += new System.EventHandler(this.TxtBookingNo_TextChanged);
            // 
            // lblBookingNo
            // 
            this.lblBookingNo.AutoSize = true;
            this.lblBookingNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(77)))), ((int)(((byte)(37)))));
            this.lblBookingNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingNo.ForeColor = System.Drawing.Color.White;
            this.lblBookingNo.Location = new System.Drawing.Point(24, 92);
            this.lblBookingNo.Name = "lblBookingNo";
            this.lblBookingNo.Size = new System.Drawing.Size(101, 21);
            this.lblBookingNo.TabIndex = 85;
            this.lblBookingNo.Text = "Booking No:";
            // 
            // cbDogName
            // 
            this.cbDogName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbDogName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDogName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDogName.FormattingEnabled = true;
            this.cbDogName.Location = new System.Drawing.Point(146, 142);
            this.cbDogName.Name = "cbDogName";
            this.cbDogName.Size = new System.Drawing.Size(210, 27);
            this.cbDogName.TabIndex = 1;
            this.cbDogName.TextChanged += new System.EventHandler(this.CbDogName_TextChanged);
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBookings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBookings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookings.ColumnHeadersHeight = 35;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookings.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookings.Location = new System.Drawing.Point(20, 85);
            this.dgvBookings.MultiSelect = false;
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookings.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBookings.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookings.Size = new System.Drawing.Size(720, 445);
            this.dgvBookings.TabIndex = 87;
            this.dgvBookings.Visible = false;
            this.dgvBookings.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBookings_CellContentDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(620, 495);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Booking";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(267, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 27);
            this.txtSearch.TabIndex = 89;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(467, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 27);
            this.btnSearch.TabIndex = 90;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(20, 495);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(51, 35);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(77)))), ((int)(((byte)(37)))));
            this.lblCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.White;
            this.lblCost.Location = new System.Drawing.Point(382, 222);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(51, 21);
            this.lblCost.TabIndex = 103;
            this.lblCost.Text = "Price:";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(77)))), ((int)(((byte)(37)))));
            this.lblStaffName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.ForeColor = System.Drawing.Color.White;
            this.lblStaffName.Location = new System.Drawing.Point(382, 271);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(102, 21);
            this.lblStaffName.TabIndex = 105;
            this.lblStaffName.Text = "Staff Name:";
            // 
            // cbStaffName
            // 
            this.cbStaffName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStaffName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaffName.FormattingEnabled = true;
            this.cbStaffName.Location = new System.Drawing.Point(504, 269);
            this.cbStaffName.Name = "cbStaffName";
            this.cbStaffName.Size = new System.Drawing.Size(210, 27);
            this.cbStaffName.TabIndex = 104;
            this.cbStaffName.TextChanged += new System.EventHandler(this.CbStaffName_TextChanged);
            // 
            // chbExtraOption
            // 
            this.chbExtraOption.AutoSize = true;
            this.chbExtraOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbExtraOption.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbExtraOption.ForeColor = System.Drawing.Color.White;
            this.chbExtraOption.Location = new System.Drawing.Point(504, 126);
            this.chbExtraOption.Name = "chbExtraOption";
            this.chbExtraOption.Size = new System.Drawing.Size(164, 25);
            this.chbExtraOption.TabIndex = 106;
            this.chbExtraOption.Text = "Add Extra Option";
            this.chbExtraOption.UseVisualStyleBackColor = true;
            this.chbExtraOption.CheckStateChanged += new System.EventHandler(this.ChbExtraOption_CheckStateChanged);
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtDuration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(504, 174);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(115, 27);
            this.txtDuration.TabIndex = 107;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(504, 221);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(115, 27);
            this.txtPrice.TabIndex = 108;
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.CustomFormat = "";
            this.dtpDateCreated.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateCreated.Location = new System.Drawing.Point(504, 314);
            this.dtpDateCreated.Name = "dtpDateCreated";
            this.dtpDateCreated.Size = new System.Drawing.Size(210, 27);
            this.dtpDateCreated.TabIndex = 109;
            this.dtpDateCreated.ValueChanged += new System.EventHandler(this.DtpDateCreated_ValueChanged);
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(77)))), ((int)(((byte)(37)))));
            this.lblDateCreated.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreated.ForeColor = System.Drawing.Color.White;
            this.lblDateCreated.Location = new System.Drawing.Point(379, 319);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(125, 21);
            this.lblDateCreated.TabIndex = 110;
            this.lblDateCreated.Text = "Date Created:";
            // 
            // UcBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(77)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.dtpDateCreated);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.chbExtraOption);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.cbStaffName);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbDogName);
            this.Controls.Add(this.txtBookingNo);
            this.Controls.Add(this.lblBookingNo);
            this.Controls.Add(this.cbServiceOptionNo);
            this.Controls.Add(this.lblServiceOption);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.cbClientName);
            this.Controls.Add(this.lblDogName);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Name = "UcBooking";
            this.Size = new System.Drawing.Size(760, 550);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Label lblDogName;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.ComboBox cbClientName;
        private System.Windows.Forms.ComboBox cbServiceOptionNo;
        private System.Windows.Forms.Label lblServiceOption;
        private System.Windows.Forms.ComboBox cbDogName;
        private System.Windows.Forms.TextBox txtBookingNo;
        private System.Windows.Forms.Label lblBookingNo;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.ComboBox cbStaffName;
        private System.Windows.Forms.CheckBox chbExtraOption;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.DateTimePicker dtpDateCreated;
        private System.Windows.Forms.Label lblDateCreated;
    }
}
