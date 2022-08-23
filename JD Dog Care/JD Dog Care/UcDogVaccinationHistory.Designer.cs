namespace JD_Dog_Care
{
    partial class UcDogVaccinationHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDogVaccinationHistory));
            this.dtpVaccinationDate = new System.Windows.Forms.DateTimePicker();
            this.lblVaccinationDate = new System.Windows.Forms.Label();
            this.lblVacciantionName = new System.Windows.Forms.Label();
            this.cbVaccinationName = new System.Windows.Forms.ComboBox();
            this.dgvVaccinationHistory = new System.Windows.Forms.DataGridView();
            this.btnUpdateVaccination = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccinationHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpVaccinationDate
            // 
            this.dtpVaccinationDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVaccinationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVaccinationDate.Location = new System.Drawing.Point(199, 298);
            this.dtpVaccinationDate.Name = "dtpVaccinationDate";
            this.dtpVaccinationDate.Size = new System.Drawing.Size(210, 27);
            this.dtpVaccinationDate.TabIndex = 2;
            this.dtpVaccinationDate.ValueChanged += new System.EventHandler(this.DtpVaccinationDate_ValueChanged);
            // 
            // lblVaccinationDate
            // 
            this.lblVaccinationDate.AutoSize = true;
            this.lblVaccinationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.lblVaccinationDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaccinationDate.ForeColor = System.Drawing.Color.White;
            this.lblVaccinationDate.Location = new System.Drawing.Point(31, 300);
            this.lblVaccinationDate.Name = "lblVaccinationDate";
            this.lblVaccinationDate.Size = new System.Drawing.Size(154, 21);
            this.lblVaccinationDate.TabIndex = 97;
            this.lblVaccinationDate.Text = "Vaccination Date:";
            // 
            // lblVacciantionName
            // 
            this.lblVacciantionName.AutoSize = true;
            this.lblVacciantionName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.lblVacciantionName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacciantionName.ForeColor = System.Drawing.Color.White;
            this.lblVacciantionName.Location = new System.Drawing.Point(31, 259);
            this.lblVacciantionName.Name = "lblVacciantionName";
            this.lblVacciantionName.Size = new System.Drawing.Size(162, 21);
            this.lblVacciantionName.TabIndex = 95;
            this.lblVacciantionName.Text = "Vaccination Name:";
            // 
            // cbVaccinationName
            // 
            this.cbVaccinationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbVaccinationName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVaccinationName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVaccinationName.FormattingEnabled = true;
            this.cbVaccinationName.Location = new System.Drawing.Point(199, 257);
            this.cbVaccinationName.Name = "cbVaccinationName";
            this.cbVaccinationName.Size = new System.Drawing.Size(210, 27);
            this.cbVaccinationName.TabIndex = 1;
            this.cbVaccinationName.TextChanged += new System.EventHandler(this.CbVaccinationName_TextChanged);
            // 
            // dgvVaccinationHistory
            // 
            this.dgvVaccinationHistory.AllowUserToAddRows = false;
            this.dgvVaccinationHistory.AllowUserToDeleteRows = false;
            this.dgvVaccinationHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVaccinationHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVaccinationHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVaccinationHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVaccinationHistory.ColumnHeadersHeight = 35;
            this.dgvVaccinationHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVaccinationHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVaccinationHistory.Location = new System.Drawing.Point(25, 25);
            this.dgvVaccinationHistory.MultiSelect = false;
            this.dgvVaccinationHistory.Name = "dgvVaccinationHistory";
            this.dgvVaccinationHistory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVaccinationHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVaccinationHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = "NULL";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVaccinationHistory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVaccinationHistory.Size = new System.Drawing.Size(413, 200);
            this.dgvVaccinationHistory.TabIndex = 93;
            this.dgvVaccinationHistory.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVaccinationHistory_CellContentDoubleClick);
            // 
            // btnUpdateVaccination
            // 
            this.btnUpdateVaccination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnUpdateVaccination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateVaccination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateVaccination.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btnUpdateVaccination.Location = new System.Drawing.Point(175, 360);
            this.btnUpdateVaccination.Name = "btnUpdateVaccination";
            this.btnUpdateVaccination.Size = new System.Drawing.Size(110, 36);
            this.btnUpdateVaccination.TabIndex = 3;
            this.btnUpdateVaccination.Text = "Update";
            this.btnUpdateVaccination.UseVisualStyleBackColor = false;
            this.btnUpdateVaccination.Click += new System.EventHandler(this.BtnUpdateVaccination_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            this.ep.Icon = ((System.Drawing.Icon)(resources.GetObject("ep.Icon")));
            // 
            // UcDogVaccinationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.btnUpdateVaccination);
            this.Controls.Add(this.dtpVaccinationDate);
            this.Controls.Add(this.lblVaccinationDate);
            this.Controls.Add(this.lblVacciantionName);
            this.Controls.Add(this.cbVaccinationName);
            this.Controls.Add(this.dgvVaccinationHistory);
            this.Name = "UcDogVaccinationHistory";
            this.Size = new System.Drawing.Size(463, 415);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccinationHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpVaccinationDate;
        private System.Windows.Forms.Label lblVaccinationDate;
        private System.Windows.Forms.Label lblVacciantionName;
        private System.Windows.Forms.ComboBox cbVaccinationName;
        private System.Windows.Forms.DataGridView dgvVaccinationHistory;
        private System.Windows.Forms.Button btnUpdateVaccination;
        private System.Windows.Forms.ErrorProvider ep;
    }
}
