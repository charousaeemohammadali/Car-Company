namespace CarCompany
{
    partial class FormBuy
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
            this.label2 = new System.Windows.Forms.Label();
            this.ComboModel = new System.Windows.Forms.ComboBox();
            this.txtNumDay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboLastName = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(541, 51);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 76;
            this.label2.Text = "مدل ماشین:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ComboModel
            // 
            this.ComboModel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboModel.FormattingEnabled = true;
            this.ComboModel.Location = new System.Drawing.Point(356, 50);
            this.ComboModel.Name = "ComboModel";
            this.ComboModel.Size = new System.Drawing.Size(183, 21);
            this.ComboModel.TabIndex = 75;
            this.ComboModel.SelectedIndexChanged += new System.EventHandler(this.ComboModel_SelectedIndexChanged);
            // 
            // txtNumDay
            // 
            this.txtNumDay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDay.Location = new System.Drawing.Point(436, 136);
            this.txtNumDay.Name = "txtNumDay";
            this.txtNumDay.Size = new System.Drawing.Size(100, 21);
            this.txtNumDay.TabIndex = 73;
            this.txtNumDay.TextChanged += new System.EventHandler(this.txtNumDay_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(536, 140);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "تعداد خودروهای صادرشده:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(539, 112);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "تاریخ صدور خودرو:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(542, 82);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(152, 14);
            this.label4.TabIndex = 71;
            this.label4.Text = " نام خانوادگی نماینده فروش:";
            // 
            // ComboLastName
            // 
            this.ComboLastName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLastName.FormattingEnabled = true;
            this.ComboLastName.Location = new System.Drawing.Point(357, 80);
            this.ComboLastName.Name = "ComboLastName";
            this.ComboLastName.Size = new System.Drawing.Size(183, 21);
            this.ComboLastName.TabIndex = 70;
            this.ComboLastName.SelectedIndexChanged += new System.EventHandler(this.ComboLastName_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Location = new System.Drawing.Point(16, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 34);
            this.button3.TabIndex = 69;
            this.button3.Text = "بازگشت";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.Location = new System.Drawing.Point(101, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 34);
            this.button4.TabIndex = 68;
            this.button4.Text = "ثبت";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Register_Click);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(399, 107);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(139, 21);
            this.txtDate.TabIndex = 77;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // FormBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 234);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboModel);
            this.Controls.Add(this.txtNumDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboLastName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Name = "FormBuy";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعریف فرم صادرات";
            this.Load += new System.EventHandler(this.FormBuy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboModel;
        private System.Windows.Forms.TextBox txtNumDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboLastName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtDate;
    }
}