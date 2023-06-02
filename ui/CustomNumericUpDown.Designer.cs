namespace ICV_Tool.components.ui
{
    partial class CustomNumericUpDown
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomNumericUpDown));
            this.customPanel1 = new ICV_Tool.components.CustomPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonUp = new System.Windows.Forms.PictureBox();
            this.buttonDown = new System.Windows.Forms.PictureBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDown)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.customPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.labelTitle);
            this.customPanel1.Controls.Add(this.buttonUp);
            this.customPanel1.Controls.Add(this.buttonDown);
            this.customPanel1.Controls.Add(this.textBoxNum);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(111, 53);
            this.customPanel1.TabIndex = 3;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(31, 3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(41, 20);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonUp
            // 
            this.buttonUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonUp.Image")));
            this.buttonUp.Location = new System.Drawing.Point(8, 20);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(24, 20);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.TabStop = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            this.buttonUp.DoubleClick += new System.EventHandler(this.buttonUp_DoubleClick);
            // 
            // buttonDown
            // 
            this.buttonDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonDown.Image")));
            this.buttonDown.Location = new System.Drawing.Point(77, 22);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(28, 24);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.TabStop = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            this.buttonDown.DoubleClick += new System.EventHandler(this.buttonDown_DoubleClick);
            // 
            // textBoxNum
            // 
            this.textBoxNum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNum.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxNum.Location = new System.Drawing.Point(33, 23);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(42, 23);
            this.textBoxNum.TabIndex = 0;
            this.textBoxNum.Text = "1";
            this.textBoxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum.TextChanged += new System.EventHandler(this.textBoxNum_TextChanged);
            this.textBoxNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNum_KeyPress);
            // 
            // CustomNumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customPanel1);
            this.Name = "CustomNumericUpDown";
            this.Size = new System.Drawing.Size(111, 53);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.PictureBox buttonDown;
        private System.Windows.Forms.PictureBox buttonUp;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Label labelTitle;
    }
}
