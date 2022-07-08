
using System;
using System.Windows.Forms;
using InventoryManager.Core.Storage;

namespace InventoryManager.Forms
{
    public partial class EditItemForm : Form
    {
        public EventHandler<Item> EditedItem;
        private Item ItemBefore;

        public EditItemForm(Item itemBefore)
        {
            ItemBefore = itemBefore;
            InitializeComponent();
        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {
            lblError.Hide();

            Text = $"Editing {ItemBefore.Name}";
            tbItemName.Text = ItemBefore.Name;
            rtbItemDescription.Text = ItemBefore.Description;
            nudItemCount.Value = ItemBefore.Count;
        }

        /*
            Confirm button is pressed
            - Validates if the user entered data is correct
            - Creates a new item and invokes the CreatedItem event
            - Displays an error if the data is invalid not and returns out
        */
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Validation

            if (string.IsNullOrEmpty(tbItemName.Text))
            {
                OutputError("Username cannot be empty!");
                return;
            }
            else if (tbItemName.Text != ItemBefore.Name && DatabaseHelper.ItemNameExists(tbItemName.Text))
            {
                OutputError("Item Name Already Exists");
                return;
            }

            // Edit Item

            Item item = new Item(
                ItemBefore.RowID,
                ItemBefore.ID,
                tbItemName.Text,
                rtbItemDescription.Text,
                (int)nudItemCount.Value
            );

            Dispose();
            EditedItem?.Invoke(this, item);
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



