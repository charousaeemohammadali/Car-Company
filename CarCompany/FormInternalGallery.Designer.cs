namespace CarCompany
{
    partial class FormInternalGallery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInternalName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.GridCars = new System.Windows.Forms.DataGridView();
            this.GridInternalGallery = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridInternalGallery)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAddress.Location = new System.Drawing.Point(131, 26);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddress.Size = new System.Drawing.Size(266, 57);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(401, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "آدرس:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTel.Location = new System.Drawing.Point(483, 44);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(117, 21);
            this.txtTel.TabIndex = 1;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(602, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 83;
            this.label3.Text = "تلفن:";
            // 
            // txtInternalName
            // 
            this.txtInternalName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtInternalName.Location = new System.Drawing.Point(711, 43);
            this.txtInternalName.Name = "txtInternalName";
            this.txtInternalName.Size = new System.Drawing.Size(117, 21);
            this.txtInternalName.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.Location = new System.Drawing.Point(512, 367);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Remove_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReg.Location = new System.Drawing.Point(587, 367);
            this.btnReg.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(70, 34);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "ثبت";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.Register_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(436, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "پاک";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CarBrand";
            this.Column8.HeaderText = "برند ماشین";
            this.Column8.Name = "Column8";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CarModel";
            this.Column1.HeaderText = "مدل ماشین";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CarColor";
            this.Column5.HeaderText = "رنگ ماشین";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CarProductionYear";
            this.Column3.HeaderText = "سال تولید";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CarPrice";
            this.dataGridViewTextBoxColumn1.HeaderText = "قیمت ماشین";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(831, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 81;
            this.label1.Text = "نام نمایشگاه داخلی:";
            // 
            // GridCars
            // 
            this.GridCars.AllowUserToAddRows = false;
            this.GridCars.AllowUserToDeleteRows = false;
            this.GridCars.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column3,
            this.Column5,
            this.Column1,
            this.Column8});
            this.GridCars.EnableHeadersVisualStyles = false;
            this.GridCars.GridColor = System.Drawing.Color.LightSeaGreen;
            this.GridCars.Location = new System.Drawing.Point(18, 109);
            this.GridCars.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GridCars.Name = "GridCars";
            this.GridCars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridCars.Size = new System.Drawing.Size(544, 231);
            this.GridCars.TabIndex = 77;
            this.GridCars.TabStop = false;
            // 
            // GridInternalGallery
            // 
            this.GridInternalGallery.AllowUserToAddRows = false;
            this.GridInternalGallery.AllowUserToDeleteRows = false;
            this.GridInternalGallery.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.GridInternalGallery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridInternalGallery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInternalGallery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column4});
            this.GridInternalGallery.EnableHeadersVisualStyles = false;
            this.GridInternalGallery.GridColor = System.Drawing.Color.LightSeaGreen;
            this.GridInternalGallery.Location = new System.Drawing.Point(587, 121);
            this.GridInternalGallery.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GridInternalGallery.Name = "GridInternalGallery";
            this.GridInternalGallery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridInternalGallery.Size = new System.Drawing.Size(365, 200);
            this.GridInternalGallery.TabIndex = 4;
            this.GridInternalGallery.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridInternalGallery_CellMouseClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "InternalName";
            this.Column2.HeaderText = "نام نمایشگاه داخلی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "InternalTel";
            this.Column6.HeaderText = "تلفن";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "InternalAddress";
            this.Column7.HeaderText = "آدرس";
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ID";
            this.Column4.HeaderText = "کد";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            this.Column4.Width = 70;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(692, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 18);
            this.label13.TabIndex = 114;
            this.label13.Text = "*";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "Industry-Return-icon.png";
            this.button3.Location = new System.Drawing.Point(357, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 34);
            this.button3.TabIndex = 118;
            this.button3.Text = "بازگشت";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormInternalGallery
            // 
            this.AcceptButton = this.btnReg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 427);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInternalName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridCars);
            this.Controls.Add(this.GridInternalGallery);
            this.Name = "FormInternalGallery";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعریف نمایشگاه داخلی";
            this.Load += new System.EventHandler(this.FormInternalGallery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridInternalGallery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInternalName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridCars;
        private System.Windows.Forms.DataGridView GridInternalGallery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
    }
}