
using System;
using System.Windows.Forms;
using InventoryManager.Core.Storage;

namespace InventoryManager.Forms
{
    public partial class ViewItemForm : Form
    {
        private Item Item;

        public ViewItemForm(Item item)
        {
            Item = item;
            InitializeComponent();
        }

        private void ViewItemForm_Load(object sender, EventArgs e)
        {
            Text = $"Viewing {Item.Name}";
            tbItemName.Text = Item.Name;
            rtbItemDescription.Text = Item.Description;
            nudItemCount.Value = Item.Count;
        }

        /*
            Close button is pressed
                - Disposes the form
        */
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}



