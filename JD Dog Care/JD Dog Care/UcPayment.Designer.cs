namespace JD_Dog_Care
{
    partial class UcPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcPayment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.txtPaymentNo = new System.Windows.Forms.TextBox();
            this.lblPaymentNo = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtBookingNo = new System.Windows.Forms.TextBox();
            this.lblBookingNo = new System.Windows.Forms.Label();
            this.txtSecurityCode = new System.Windows.Forms.TextBox();
            this.lblSecurityCode = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.btnCreatePayment = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.chbPaid = new System.Windows.Forms.CheckBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(267, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(467, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 27);
            this.btnSearch.TabIndex = 92;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
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
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBookings.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookings.Size = new System.Drawing.Size(720, 445);
            this.dgvBookings.TabIndex = 93;
            this.dgvBookings.Visible = false;
            this.dgvBookings.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBookings_CellContentDoubleClick);
            // 
            // txtPaymentNo
            // 
            this.txtPaymentNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtPaymentNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentNo.Location = new System.Drawing.Point(337, 60);
            this.txtPaymentNo.Name = "txtPaymentNo";
            this.txtPaymentNo.ReadOnly = true;
            this.txtPaymentNo.Size = new System.Drawing.Size(115, 27);
            this.txtPaymentNo.TabIndex = 100;
            this.txtPaymentNo.TextChanged += new System.EventHandler(this.TxtPaymentNo_TextChanged);
            // 
            // lblPaymentNo
            // 
            this.lblPaymentNo.AutoSize = true;
            this.lblPaymentNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblPaymentNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentNo.ForeColor = System.Drawing.Color.White;
            this.lblPaymentNo.Location = new System.Drawing.Point(211, 62);
            this.lblPaymentNo.Name = "lblPaymentNo";
            this.lblPaymentNo.Size = new System.Drawing.Size(110, 21);
            this.lblPaymentNo.TabIndex = 99;
            this.lblPaymentNo.Text = "Payment No:";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Debit Card",
            "Credit Card"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(337, 250);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(210, 27);
            this.cbPaymentMethod.TabIndex = 3;
            this.cbPaymentMethod.TextChanged += new System.EventHandler(this.CbPaymentMethod_TextChanged);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblPaymentMethod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.lblPaymentMethod.Location = new System.Drawing.Point(211, 244);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(84, 42);
            this.lblPaymentMethod.TabIndex = 97;
            this.lblPaymentMethod.Text = "Payment \r\nMethod:";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(337, 152);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(210, 27);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.DtpDate_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(211, 157);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 21);
            this.lblDate.TabIndex = 96;
            this.lblDate.Text = "Date:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.White;
            this.lblCost.Location = new System.Drawing.Point(211, 202);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(50, 21);
            this.lblCost.TabIndex = 101;
            this.lblCost.Text = "Cost:";
            // 
            // txtBookingNo
            // 
            this.txtBookingNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtBookingNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingNo.Location = new System.Drawing.Point(337, 107);
            this.txtBookingNo.Name = "txtBookingNo";
            this.txtBookingNo.ReadOnly = true;
            this.txtBookingNo.Size = new System.Drawing.Size(115, 27);
            this.txtBookingNo.TabIndex = 101;
            this.txtBookingNo.TextChanged += new System.EventHandler(this.TxtBookingNo_TextChanged);
            // 
            // lblBookingNo
            // 
            this.lblBookingNo.AutoSize = true;
            this.lblBookingNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblBookingNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingNo.ForeColor = System.Drawing.Color.White;
            this.lblBookingNo.Location = new System.Drawing.Point(211, 109);
            this.lblBookingNo.Name = "lblBookingNo";
            this.lblBookingNo.Size = new System.Drawing.Size(101, 21);
            this.lblBookingNo.TabIndex = 103;
            this.lblBookingNo.Text = "Booking No:";
            // 
            // txtSecurityCode
            // 
            this.txtSecurityCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityCode.Location = new System.Drawing.Point(337, 342);
            this.txtSecurityCode.Name = "txtSecurityCode";
            this.txtSecurityCode.Size = new System.Drawing.Size(118, 27);
            this.txtSecurityCode.TabIndex = 5;
            this.txtSecurityCode.Visible = false;
            this.txtSecurityCode.TextChanged += new System.EventHandler(this.TxtSecurityCode_TextChanged);
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.AutoSize = true;
            this.lblSecurityCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblSecurityCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityCode.ForeColor = System.Drawing.Color.White;
            this.lblSecurityCode.Location = new System.Drawing.Point(211, 344);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(123, 21);
            this.lblSecurityCode.TabIndex = 105;
            this.lblSecurityCode.Text = "Security Code:";
            this.lblSecurityCode.Visible = false;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(337, 297);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(210, 27);
            this.txtCardNumber.TabIndex = 4;
            this.txtCardNumber.Visible = false;
            this.txtCardNumber.TextChanged += new System.EventHandler(this.TxtCardNumber_TextChanged);
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCardNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.ForeColor = System.Drawing.Color.White;
            this.lblCardNumber.Location = new System.Drawing.Point(211, 299);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(121, 21);
            this.lblCardNumber.TabIndex = 107;
            this.lblCardNumber.Text = "Card Number:";
            this.lblCardNumber.Visible = false;
            // 
            // btnCreatePayment
            // 
            this.btnCreatePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(77)))));
            this.btnCreatePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePayment.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePayment.Location = new System.Drawing.Point(263, 440);
            this.btnCreatePayment.Name = "btnCreatePayment";
            this.btnCreatePayment.Size = new System.Drawing.Size(222, 50);
            this.btnCreatePayment.TabIndex = 8;
            this.btnCreatePayment.Text = "Create Payment";
            this.btnCreatePayment.UseVisualStyleBackColor = false;
            this.btnCreatePayment.Click += new System.EventHandler(this.BtnCreatePayment_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            this.ep.Icon = ((System.Drawing.Icon)(resources.GetObject("ep.Icon")));
            // 
            // chbPaid
            // 
            this.chbPaid.AutoSize = true;
            this.chbPaid.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbPaid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPaid.ForeColor = System.Drawing.Color.White;
            this.chbPaid.Location = new System.Drawing.Point(350, 387);
            this.chbPaid.Name = "chbPaid";
            this.chbPaid.Size = new System.Drawing.Size(60, 25);
            this.chbPaid.TabIndex = 6;
            this.chbPaid.Text = "Paid";
            this.chbPaid.UseVisualStyleBackColor = true;
            this.chbPaid.CheckStateChanged += new System.EventHandler(this.ChbPaid_CheckStateChanged);
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(337, 200);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(115, 27);
            this.txtCost.TabIndex = 108;
            this.txtCost.TextChanged += new System.EventHandler(this.TxtCost_TextChanged);
            // 
            // UcPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.chbPaid);
            this.Controls.Add(this.btnCreatePayment);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.txtSecurityCode);
            this.Controls.Add(this.lblSecurityCode);
            this.Controls.Add(this.txtBookingNo);
            this.Controls.Add(this.lblBookingNo);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtPaymentNo);
            this.Controls.Add(this.lblPaymentNo);
            this.Controls.Add(this.cbPaymentMethod);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Name = "UcPayment";
            this.Size = new System.Drawing.Size(760, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCost;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.DataGridView dgvBookings;
        public System.Windows.Forms.TextBox txtPaymentNo;
        public System.Windows.Forms.Label lblPaymentNo;
        public System.Windows.Forms.ComboBox cbPaymentMethod;
        public System.Windows.Forms.Label lblPaymentMethod;
        public System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblCost;
        public System.Windows.Forms.TextBox txtBookingNo;
        public System.Windows.Forms.Label lblBookingNo;
        public System.Windows.Forms.TextBox txtSecurityCode;
        public System.Windows.Forms.Label lblSecurityCode;
        public System.Windows.Forms.TextBox txtCardNumber;
        public System.Windows.Forms.Label lblCardNumber;
        public System.Windows.Forms.Button btnCreatePayment;
        public System.Windows.Forms.ErrorProvider ep;
        public System.Windows.Forms.CheckBox chbPaid;
    }
}
