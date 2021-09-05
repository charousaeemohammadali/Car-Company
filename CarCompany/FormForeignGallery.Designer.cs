namespace CarCompany
{
    partial class FormForeignGallery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridForeignGallery = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCars = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtForeignName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridForeignGallery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCars)).BeginInit();
            this.SuspendLayout();
            // 
            // GridForeignGallery
            // 
            this.GridForeignGallery.AllowUserToAddRows = false;
            this.GridForeignGallery.AllowUserToDeleteRows = false;
            this.GridForeignGallery.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.GridForeignGallery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridForeignGallery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridForeignGallery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column4});
            this.GridForeignGallery.EnableHeadersVisualStyles = false;
            this.GridForeignGallery.GridColor = System.Drawing.Color.LightSeaGreen;
            this.GridForeignGallery.Location = new System.Drawing.Point(1563, 279);
            this.GridForeignGallery.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.GridForeignGallery.Name = "GridForeignGallery";
            this.GridForeignGallery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridForeignGallery.Size = new System.Drawing.Size(973, 477);
            this.GridForeignGallery.TabIndex = 4;
            this.GridForeignGallery.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridForeignGallery_CellMouseClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ForeignName";
            this.Column2.HeaderText = "نام نمایشگاه خارجی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ForeignTel";
            this.Column6.HeaderText = "تلفن";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ForeignAddress";
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
            // GridCars
            // 
            this.GridCars.AllowUserToAddRows = false;
            this.GridCars.AllowUserToDeleteRows = false;
            this.GridCars.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column3,
            this.Column5,
            this.Column1,
            this.Column8});
            this.GridCars.EnableHeadersVisualStyles = false;
            this.GridCars.GridColor = System.Drawing.Color.LightSeaGreen;
            this.GridCars.Location = new System.Drawing.Point(45, 250);
            this.GridCars.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.GridCars.Name = "GridCars";
            this.GridCars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridCars.Size = new System.Drawing.Size(1451, 551);
            this.GridCars.TabIndex = 66;
            this.GridCars.TabStop = false;
            this.GridCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCars_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CarPrice";
            this.dataGridViewTextBoxColumn1.HeaderText = "قیمت ماشین";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CarProductionYear";
            this.Column3.HeaderText = "سال تولید";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CarColor";
            this.Column5.HeaderText = "رنگ ماشین";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CarModel";
            this.Column1.HeaderText = "مدل ماشین";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CarBrand";
            this.Column8.HeaderText = "برند ماشین";
            this.Column8.Name = "Column8";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.Location = new System.Drawing.Point(1363, 866);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 81);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Remove_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReg.Location = new System.Drawing.Point(1563, 866);
            this.btnReg.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(187, 81);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "ثبت";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.Register_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(1160, 863);
            this.button1.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 83);
            this.button1.TabIndex = 6;
            this.button1.Text = "پاک";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(1067, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 34);
            this.label5.TabIndex = 74;
            this.label5.Text = "آدرس:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTel.Location = new System.Drawing.Point(1285, 95);
            this.txtTel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(305, 41);
            this.txtTel.TabIndex = 1;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(1603, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 36);
            this.label3.TabIndex = 72;
            this.label3.Text = "تلفن:";
            // 
            // txtForeignName
            // 
            this.txtForeignName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtForeignName.Location = new System.Drawing.Point(1893, 93);
            this.txtForeignName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtForeignName.Name = "txtForeignName";
            this.txtForeignName.Size = new System.Drawing.Size(305, 41);
            this.txtForeignName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(2213, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 36);
            this.label1.TabIndex = 70;
            this.label1.Text = "نام نمایشگاه خارجی:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAddress.Location = new System.Drawing.Point(347, 52);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddress.Size = new System.Drawing.Size(703, 130);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(1840, 103);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 46);
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
            this.button3.Location = new System.Drawing.Point(936, 866);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 81);
            this.button3.TabIndex = 117;
            this.button3.Text = "بازگشت";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormForeignGallery
            // 
            this.AcceptButton = this.btnReg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2619, 992);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtForeignName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GridCars);
            this.Controls.Add(this.GridForeignGallery);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormForeignGallery";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعریف نمایشگاه خارجی";
            this.Load += new System.EventHandler(this.FormForeignGallery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridForeignGallery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridForeignGallery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView GridCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtForeignName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
    }
}