
using System;
using System.Windows.Forms;
using InventoryManager.Core.Storage;

namespace InventoryManager.Forms
{
    public partial class AddNewRowItem : Form
    {
        public EventHandler<Item> CreatedItem;

        public AddNewRowItem()
        {
            InitializeComponent();
        }

        private void AddNewRowForm_Load(object sender, EventArgs e)
        {
            lblError.Hide();
        }

        /*
            Add button is pressed
            - Validates if the user entered data is correct
            - Creates a new item and invokes the CreatedItem event
            - Displays an error if the data is invalid not and returns out
        */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validation

            if (string.IsNullOrWhiteSpace(tbItemName.Text))
            {
                OutputError("Username cannot be empty!");
                return;
            }
            else if (DatabaseHelper.ItemNameExists(tbItemName.Text))
            {
                OutputError("Item Name Already Exists");
                return;
            }

            // Create Item

            Item item = new Item(
                tbItemName.Text,
                rtbItemDescription.Text,
                (int)nudItemCount.Value
            );

            Dispose();
            CreatedItem?.Invoke(this, item);
        }

        /*
            Cancel button is pressed
                - Disposes the form
        */ 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /*
            Outputs an error to lblError
        */ 
        private void OutputError(string text)
        {
            lblError.Text = text;
            lblError.Show();
        }
    }
}



