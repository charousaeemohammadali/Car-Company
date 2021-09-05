namespace CarCompany
{
    partial class FormMian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMian));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.مدیریتاطلاعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتنمایندگانفروشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعریفنوعنمایندهفروشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتخودروهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعریفرنگخودروToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعریفمدلخودروToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعریفبرندخودروToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعاتپایهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعریفنمایشگاهخارجیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعریفنمایشگاهداخلیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.صادراتخودروToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتاطلاعاتToolStripMenuItem,
            this.اطلاعاتپایهToolStripMenuItem,
            this.صادراتخودروToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // مدیریتاطلاعاتToolStripMenuItem
            // 
            this.مدیریتاطلاعاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتنمایندگانفروشToolStripMenuItem,
            this.مدیریتخودروهاToolStripMenuItem});
            this.مدیریتاطلاعاتToolStripMenuItem.Name = "مدیریتاطلاعاتToolStripMenuItem";
            this.مدیریتاطلاعاتToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.مدیریتاطلاعاتToolStripMenuItem.Text = "مدیریت اطلاعات";
            // 
            // مدیریتنمایندگانفروشToolStripMenuItem
            // 
            this.مدیریتنمایندگانفروشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعریفنوعنمایندهفروشToolStripMenuItem});
            this.مدیریتنمایندگانفروشToolStripMenuItem.Name = "مدیریتنمایندگانفروشToolStripMenuItem";
            this.مدیریتنمایندگانفروشToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.مدیریتنمایندگانفروشToolStripMenuItem.Text = "مدیریت نمایندگان فروش";
            this.مدیریتنمایندگانفروشToolStripMenuItem.Click += new System.EventHandler(this.ShowFormListAgent_Click);
            // 
            // تعریفنوعنمایندهفروشToolStripMenuItem
            // 
            this.تعریفنوعنمایندهفروشToolStripMenuItem.Name = "تعریفنوعنمایندهفروشToolStripMenuItem";
            this.تعریفنوعنمایندهفروشToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.تعریفنوعنمایندهفروشToolStripMenuItem.Text = "تعریف نوع نماینده فروش";
            this.تعریفنوعنمایندهفروشToolStripMenuItem.Click += new System.EventHandler(this.ShowFormTypeagent_Click);
            // 
            // مدیریتخودروهاToolStripMenuItem
            // 
            this.مدیریتخودروهاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعریفرنگخودروToolStripMenuItem,
            this.تعریفمدلخودروToolStripMenuItem,
            this.تعریفبرندخودروToolStripMenuItem});
            this.مدیریتخودروهاToolStripMenuItem.Name = "مدیریتخودروهاToolStripMenuItem";
            this.مدیریتخودروهاToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.مدیریتخودروهاToolStripMenuItem.Text = "مدیریت خودروها";
            this.مدیریتخودروهاToolStripMenuItem.Click += new System.EventHandler(this.ShowFormListCar_Click);
            // 
            // تعریفرنگخودروToolStripMenuItem
            // 
            this.تعریفرنگخودروToolStripMenuItem.Name = "تعریفرنگخودروToolStripMenuItem";
            this.تعریفرنگخودروToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.تعریفرنگخودروToolStripMenuItem.Text = "تعریف رنگ خودرو";
            this.تعریفرنگخودروToolStripMenuItem.Click += new System.EventHandler(this.ShowCarColor_Click);
            // 
            // تعریفمدلخودروToolStripMenuItem
            // 
            this.تعریفمدلخودروToolStripMenuItem.Name = "تعریفمدلخودروToolStripMenuItem";
            this.تعریفمدلخودروToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.تعریفمدلخودروToolStripMenuItem.Text = "تعریف مدل خودرو";
            this.تعریفمدلخودروToolStripMenuItem.Click += new System.EventHandler(this.ShowFormCarBrand);
            // 
            // تعریفبرندخودروToolStripMenuItem
            // 
            this.تعریفبرندخودروToolStripMenuItem.Name = "تعریفبرندخودروToolStripMenuItem";
            this.تعریفبرندخودروToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.تعریفبرندخودروToolStripMenuItem.Text = "تعریف برند خودرو";
            this.تعریفبرندخودروToolStripMenuItem.Click += new System.EventHandler(this.ShowFormCarBrand_Click);
            // 
            // اطلاعاتپایهToolStripMenuItem
            // 
            this.اطلاعاتپایهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعریفنمایشگاهخارجیToolStripMenuItem,
            this.تعریفنمایشگاهداخلیToolStripMenuItem});
            this.اطلاعاتپایهToolStripMenuItem.Name = "اطلاعاتپایهToolStripMenuItem";
            this.اطلاعاتپایهToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.اطلاعاتپایهToolStripMenuItem.Text = "اطلاعات پایه";
            // 
            // تعریفنمایشگاهخارجیToolStripMenuItem
            // 
            this.تعریفنمایشگاهخارجیToolStripMenuItem.Name = "تعریفنمایشگاهخارجیToolStripMenuItem";
            this.تعریفنمایشگاهخارجیToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.تعریفنمایشگاهخارجیToolStripMenuItem.Text = "تعریف نمایشگاه خارجی";
            this.تعریفنمایشگاهخارجیToolStripMenuItem.Click += new System.EventHandler(this.ShowFormIGallery_Click);
            // 
            // تعریفنمایشگاهداخلیToolStripMenuItem
            // 
            this.تعریفنمایشگاهداخلیToolStripMenuItem.Name = "تعریفنمایشگاهداخلیToolStripMenuItem";
            this.تعریفنمایشگاهداخلیToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.تعریفنمایشگاهداخلیToolStripMenuItem.Text = "تعریف نمایشگاه داخلی";
            this.تعریفنمایشگاهداخلیToolStripMenuItem.Click += new System.EventHandler(this.ShowFormFGallery_Click);
            // 
            // صادراتخودروToolStripMenuItem
            // 
            this.صادراتخودروToolStripMenuItem.Name = "صادراتخودروToolStripMenuItem";
            this.صادراتخودروToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.صادراتخودروToolStripMenuItem.Text = "صادرات خودرو";
            this.صادراتخودروToolStripMenuItem.Click += new System.EventHandler(this.FormListBuy_Click);
            // 
            // FormMian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(626, 427);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Name = "FormMian";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMian";
            this.Load += new System.EventHandler(this.FormMian_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem مدیریتاطلاعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتنمایندگانفروشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعریفنوعنمایندهفروشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتخودروهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعریفرنگخودروToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعریفمدلخودروToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعریفبرندخودروToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتپایهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعریفنمایشگاهخارجیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعریفنمایشگاهداخلیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem صادراتخودروToolStripMenuItem;
    }
}