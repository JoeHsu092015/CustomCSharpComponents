namespace ICV_Tool.components.ui
{
    partial class CustomMenuStrip
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
            this.components = new System.ComponentModel.Container();
            this.panelBar = new System.Windows.Forms.Panel();
            this.buttonSupportDevices = new System.Windows.Forms.Button();
            this.supportDevicesMenu = new ICV_Tool.components.CustomDropdownMenu(this.components);
            this.panelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.Coral;
            this.panelBar.Controls.Add(this.buttonSupportDevices);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(1035, 36);
            this.panelBar.TabIndex = 0;
            // 
            // buttonSupportDevices
            // 
            this.buttonSupportDevices.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonSupportDevices.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSupportDevices.Location = new System.Drawing.Point(-1, -1);
            this.buttonSupportDevices.Name = "buttonSupportDevices";
            this.buttonSupportDevices.Size = new System.Drawing.Size(95, 36);
            this.buttonSupportDevices.TabIndex = 0;
            this.buttonSupportDevices.Text = "Support";
            this.buttonSupportDevices.UseVisualStyleBackColor = true;
            this.buttonSupportDevices.Click += new System.EventHandler(this.buttonSupportDevices_Click);
            // 
            // supportDevicesMenu
            // 
            this.supportDevicesMenu.IsMainMenu = false;
            this.supportDevicesMenu.MenuItemHeight = 25;
            this.supportDevicesMenu.MenuItemTextColor = System.Drawing.Color.Empty;
            this.supportDevicesMenu.Name = "rjDropdownMenu1";
            this.supportDevicesMenu.PrimaryColor = System.Drawing.Color.Empty;
            this.supportDevicesMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // CustomMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBar);
            this.Name = "CustomMenuStrip";
            this.Size = new System.Drawing.Size(1035, 36);
            this.panelBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBar;
        public CustomDropdownMenu supportDevicesMenu;
        private System.Windows.Forms.Button buttonSupportDevices;
    }
}
