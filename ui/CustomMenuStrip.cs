using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ICV_Tool.components.ui
{
    public partial class CustomMenuStrip : UserControl
    {
        private Dictionary<Button, CustomDropdownMenu> _menu;
        //public RJDropdownMenu supportDevicesMenu;

        public CustomMenuStrip()
        {
            InitializeComponent();
            _menu = new Dictionary<Button, CustomDropdownMenu>();
            // supportDevicesMenu = new RJDropdownMenu(panelBar.Container);

            supportDevicesMenu.PrimaryColor = Color.FromArgb(247, 148, 29);
            supportDevicesMenu.MenuItemTextColor = Color.FromArgb(123, 131, 139);
            

            buttonSupportDevices.BackColor = Color.FromArgb(251, 229, 213);
            buttonSupportDevices.ForeColor = Color.FromArgb(127, 127, 127);

            panelBar.BackColor = Color.FromArgb(247, 148, 29);
        }

        public void CreateMenuItem(string title, Dictionary<string, List<string>> s)
        {
            
        }

        private void buttonSupportDevices_Click(object sender, EventArgs e)
        {
            supportDevicesMenu.Show(buttonSupportDevices, buttonSupportDevices.Left, buttonSupportDevices.Bottom);
        }
    }
}
