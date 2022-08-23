namespace JD_Dog_Care
{
    partial class UcVaccination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcVaccination));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnVaccination = new System.Windows.Forms.Button();
            this.lblVaccinationName = new System.Windows.Forms.Label();
            this.txtVaccinationNo = new System.Windows.Forms.TextBox();
            this.lblVaccinationNo = new System.Windows.Forms.Label();
            this.dgvVaccinations = new System.Windows.Forms.DataGridView();
            this.txtVaccinationName = new System.Windows.Forms.TextBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccinations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(20, 531);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(51, 35);
            this.btnBack.TabIndex = 109;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(595, 529);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 35);
            this.btnDelete.TabIndex = 108;
            this.btnDelete.Text = "Delete Vaccination";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnVaccination
            // 
            this.btnVaccination.BackColor = System.Drawing.Color.Green;
            this.btnVaccination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaccination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaccination.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaccination.Location = new System.Drawing.Point(308, 438);
            this.btnVaccination.Name = "btnVaccination";
            this.btnVaccination.Size = new System.Drawing.Size(121, 50);
            this.btnVaccination.TabIndex = 107;
            this.btnVaccination.Text = "Create";
            this.btnVaccination.UseVisualStyleBackColor = false;
            this.btnVaccination.Click += new System.EventHandler(this.BtnVaccination_Click);
            // 
            // lblVaccinationName
            // 
            this.lblVaccinationName.AutoSize = true;
            this.lblVaccinationName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaccinationName.ForeColor = System.Drawing.Color.White;
            this.lblVaccinationName.Location = new System.Drawing.Point(192, 352);
            this.lblVaccinationName.Name = "lblVaccinationName";
            this.lblVaccinationName.Size = new System.Drawing.Size(162, 21);
            this.lblVaccinationName.TabIndex = 114;
            this.lblVaccinationName.Text = "Vaccination Name:";
            // 
            // txtVaccinationNo
            // 
            this.txtVaccinationNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtVaccinationNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVaccinationNo.Location = new System.Drawing.Point(360, 308);
            this.txtVaccinationNo.Name = "txtVaccinationNo";
            this.txtVaccinationNo.ReadOnly = true;
            this.txtVaccinationNo.Size = new System.Drawing.Size(115, 27);
            this.txtVaccinationNo.TabIndex = 111;
            // 
            // lblVaccinationNo
            // 
            this.lblVaccinationNo.AutoSize = true;
            this.lblVaccinationNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.lblVaccinationNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaccinationNo.ForeColor = System.Drawing.Color.White;
            this.lblVaccinationNo.Location = new System.Drawing.Point(192, 310);
            this.lblVaccinationNo.Name = "lblVaccinationNo";
            this.lblVaccinationNo.Size = new System.Drawing.Size(136, 21);
            this.lblVaccinationNo.TabIndex = 112;
            this.lblVaccinationNo.Text = "Vaccination No:";
            // 
            // dgvVaccinations
            // 
            this.dgvVaccinations.AllowUserToAddRows = false;
            this.dgvVaccinations.AllowUserToDeleteRows = false;
            this.dgvVaccinations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVaccinations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVaccinations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVaccinations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVaccinations.ColumnHeadersHeight = 35;
            this.dgvVaccinations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVaccinations.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVaccinations.Location = new System.Drawing.Point(72, 57);
            this.dgvVaccinations.MultiSelect = false;
            this.dgvVaccinations.Name = "dgvVaccinations";
            this.dgvVaccinations.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVaccinations.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVaccinations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = "NULL";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(118)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVaccinations.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVaccinations.Size = new System.Drawing.Size(605, 210);
            this.dgvVaccinations.TabIndex = 110;
            this.dgvVaccinations.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVaccinations_CellContentDoubleClick);
            // 
            // txtVaccinationName
            // 
            this.txtVaccinationName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVaccinationName.Location = new System.Drawing.Point(360, 352);
            this.txtVaccinationName.Name = "txtVaccinationName";
            this.txtVaccinationName.Size = new System.Drawing.Size(210, 27);
            this.txtVaccinationName.TabIndex = 115;
            this.txtVaccinationName.Visible = false;
            this.txtVaccinationName.TextChanged += new System.EventHandler(this.TxtVaccinationName_TextChanged);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            this.ep.Icon = ((System.Drawing.Icon)(resources.GetObject("ep.Icon")));
            // 
            // UcVaccination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.txtVaccinationName);
            this.Controls.Add(this.lblVaccinationName);
            this.Controls.Add(this.txtVaccinationNo);
            this.Controls.Add(this.lblVaccinationNo);
            this.Controls.Add(this.dgvVaccinations);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnVaccination);
            this.Name = "UcVaccination";
            this.Size = new System.Drawing.Size(760, 580);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccinations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnVaccination;
        private System.Windows.Forms.Label lblVaccinationName;
        private System.Windows.Forms.TextBox txtVaccinationNo;
        private System.Windows.Forms.Label lblVaccinationNo;
        private System.Windows.Forms.DataGridView dgvVaccinations;
        public System.Windows.Forms.TextBox txtVaccinationName;
        private System.Windows.Forms.ErrorProvider ep;
    }
}
