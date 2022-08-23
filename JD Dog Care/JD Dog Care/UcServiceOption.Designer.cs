namespace JD_Dog_Care
{
    partial class UcServiceOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcServiceOption));
            this.dgvServiceOptions = new System.Windows.Forms.DataGridView();
            this.txtServiceOptionNo = new System.Windows.Forms.TextBox();
            this.lblServiceOption = new System.Windows.Forms.Label();
            this.lblServiceOptionDescription = new System.Windows.Forms.Label();
            this.rtxtServiceOptionDescription = new System.Windows.Forms.RichTextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.nupPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnServiceOption = new System.Windows.Forms.Button();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServiceOptions
            // 
            this.dgvServiceOptions.AllowUserToAddRows = false;
            this.dgvServiceOptions.AllowUserToDeleteRows = false;
            this.dgvServiceOptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServiceOptions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvServiceOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServiceOptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServiceOptions.ColumnHeadersHeight = 35;
            this.dgvServiceOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiceOptions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServiceOptions.Location = new System.Drawing.Point(75, 21);
            this.dgvServiceOptions.MultiSelect = false;
            this.dgvServiceOptions.Name = "dgvServiceOptions";
            this.dgvServiceOptions.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServiceOptions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServiceOptions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = "NULL";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(118)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvServiceOptions.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvServiceOptions.Size = new System.Drawing.Size(605, 210);
            this.dgvServiceOptions.TabIndex = 94;
            this.dgvServiceOptions.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvServiceOptions_CellContentDoubleClick);
            // 
            // txtServiceOptionNo
            // 
            this.txtServiceOptionNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtServiceOptionNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceOptionNo.Location = new System.Drawing.Point(360, 252);
            this.txtServiceOptionNo.Name = "txtServiceOptionNo";
            this.txtServiceOptionNo.ReadOnly = true;
            this.txtServiceOptionNo.Size = new System.Drawing.Size(115, 27);
            this.txtServiceOptionNo.TabIndex = 95;
            this.txtServiceOptionNo.TextChanged += new System.EventHandler(this.TxtServiceOptionNo_TextChanged);
            // 
            // lblServiceOption
            // 
            this.lblServiceOption.AutoSize = true;
            this.lblServiceOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.lblServiceOption.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceOption.ForeColor = System.Drawing.Color.White;
            this.lblServiceOption.Location = new System.Drawing.Point(232, 254);
            this.lblServiceOption.Name = "lblServiceOption";
            this.lblServiceOption.Size = new System.Drawing.Size(129, 21);
            this.lblServiceOption.TabIndex = 96;
            this.lblServiceOption.Text = "Service Option:";
            // 
            // lblServiceOptionDescription
            // 
            this.lblServiceOptionDescription.AutoSize = true;
            this.lblServiceOptionDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceOptionDescription.ForeColor = System.Drawing.Color.White;
            this.lblServiceOptionDescription.Location = new System.Drawing.Point(232, 296);
            this.lblServiceOptionDescription.Name = "lblServiceOptionDescription";
            this.lblServiceOptionDescription.Size = new System.Drawing.Size(101, 21);
            this.lblServiceOptionDescription.TabIndex = 98;
            this.lblServiceOptionDescription.Text = "Description:";
            // 
            // rtxtServiceOptionDescription
            // 
            this.rtxtServiceOptionDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtServiceOptionDescription.Location = new System.Drawing.Point(360, 296);
            this.rtxtServiceOptionDescription.MaxLength = 1000;
            this.rtxtServiceOptionDescription.Name = "rtxtServiceOptionDescription";
            this.rtxtServiceOptionDescription.Size = new System.Drawing.Size(216, 51);
            this.rtxtServiceOptionDescription.TabIndex = 97;
            this.rtxtServiceOptionDescription.Text = "";
            this.rtxtServiceOptionDescription.TextChanged += new System.EventHandler(this.RtxtServiceOptionDescription_TextChanged);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(232, 367);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(82, 21);
            this.lblDuration.TabIndex = 100;
            this.lblDuration.Text = "Duration:";
            // 
            // nupPrice
            // 
            this.nupPrice.DecimalPlaces = 2;
            this.nupPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPrice.Location = new System.Drawing.Point(360, 409);
            this.nupPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nupPrice.Name = "nupPrice";
            this.nupPrice.Size = new System.Drawing.Size(120, 27);
            this.nupPrice.TabIndex = 101;
            this.nupPrice.ValueChanged += new System.EventHandler(this.NupPrice_ValueChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(232, 412);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 21);
            this.lblPrice.TabIndex = 102;
            this.lblPrice.Text = "Price:";
            // 
            // btnServiceOption
            // 
            this.btnServiceOption.BackColor = System.Drawing.Color.Green;
            this.btnServiceOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServiceOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceOption.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceOption.Location = new System.Drawing.Point(319, 471);
            this.btnServiceOption.Name = "btnServiceOption";
            this.btnServiceOption.Size = new System.Drawing.Size(121, 50);
            this.btnServiceOption.TabIndex = 103;
            this.btnServiceOption.Text = "Create";
            this.btnServiceOption.UseVisualStyleBackColor = false;
            this.btnServiceOption.Click += new System.EventHandler(this.BtnServiceOption_Click);
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.White;
            this.txtDuration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(360, 365);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(120, 27);
            this.txtDuration.TabIndex = 104;
            this.txtDuration.TextChanged += new System.EventHandler(this.TxtDuration_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(570, 531);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 35);
            this.btnDelete.TabIndex = 105;
            this.btnDelete.Text = "Delete Service Option";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            this.btnBack.TabIndex = 106;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            this.ep.Icon = ((System.Drawing.Icon)(resources.GetObject("ep.Icon")));
            // 
            // UcServiceOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.btnServiceOption);
            this.Controls.Add(this.nupPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblServiceOptionDescription);
            this.Controls.Add(this.rtxtServiceOptionDescription);
            this.Controls.Add(this.txtServiceOptionNo);
            this.Controls.Add(this.lblServiceOption);
            this.Controls.Add(this.dgvServiceOptions);
            this.Name = "UcServiceOption";
            this.Size = new System.Drawing.Size(760, 580);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServiceOptions;
        private System.Windows.Forms.TextBox txtServiceOptionNo;
        private System.Windows.Forms.Label lblServiceOption;
        private System.Windows.Forms.Label lblServiceOptionDescription;
        private System.Windows.Forms.RichTextBox rtxtServiceOptionDescription;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown nupPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnServiceOption;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider ep;
    }
}
