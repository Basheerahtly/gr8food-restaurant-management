using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHEF
{
    public partial class Remove_menu : Form
    {
        private int selectedMenuID; //Store selected menu ID

        MenuService menuService = new MenuService(); //Creating menuService object
        public Remove_menu(int menuID)
        {
            InitializeComponent();
            selectedMenuID = menuID;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {   //Asking for confirmation before removing menu item 
            DialogResult result = MessageBox.Show("Are you sure you want to remove this menu item?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool isUsed =menuService.IsMenuUsedInOrders(selectedMenuID);

                if (isUsed)
                {
                    MessageBox.Show("This menu item cannot be deleted because it is already used in customer orders.","Delete Not Allowed",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                menuService.DeleteMenu(selectedMenuID);

                MessageBox.Show("Menu item removed successfully","Success",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            this.Close();// Close the form after deletion
               
             
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();// Close the form without making any changes
        }

        private void Remove_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
