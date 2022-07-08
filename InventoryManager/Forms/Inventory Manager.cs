
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using InventoryManager.Core.Storage;

namespace InventoryManager.Forms
{
    public partial class InventoryManagerForm : Form
    {
        private ItemContainer Items;
        private Item SelectedItem;
        private int RowIndex;

        public InventoryManagerForm()
        {
            InitializeComponent();
        }

        private void InventoryManagerForm_Load(object sender, EventArgs e)
        {
            ReloadItems();
        }

        #region PERIPHERAL CONTROLS

        /*
            Mouse is clicked on the data grid view
            - Checks if a row is clicked
            - If a row is clicked it will open item controls for that row 
            - If no row is clicked it will open the table controls for the entire table
        */
        private void dgvItemGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int max = (dgvItemGrid.RowCount * dgvItemGrid.RowTemplate.Height) + dgvItemGrid.ColumnHeadersHeight;

                if (e.Location.Y > max)
                {
                    cmsTableControls.Show(Cursor.Position);
                }
                else if (GetItemByRowID(RowIndex, out SelectedItem))
                {
                    cmsItemControls.Show(Cursor.Position);
                }
            }
        }

        /*
            Mouse is moved on the data grid view
            - Changes the value of RowIndex so the program keeps track of the row being clicked
        */
        private void dgvItemGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                RowIndex = e.RowIndex;
            }
        }

        /*
            Key is pressed in the search bar
            - If key is enter it will redraw the table with the new search query
        */
        private void tbSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DrawItems();
            }
        }
        #endregion

        #region TABLE CONTROLS

        /*
            Add new row option is clicked in the table controls
            - Redirects to AddNewItem()
        */
        private void tsmAddNewRow_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        /*
            Reload grid option is clicked in the table controls
            - Redirects to ReloadItems()
        */
        private void tsmReloadGrid_Click(object sender, EventArgs e)
        {
            ReloadItems();
        }

        /*
            Redraw grid option is clicked in the table controls
            - Redirects to RedrawGrid
        */
        private void tsmRedrawGrid_Click(object sender, EventArgs e)
        {
            DrawItems();
        }
        #endregion

        #region ITEM CONTROLS

        /*
            An option to increment or decrement the count for an item is clicked in the item controls
            - Redirects to IncrementItemCount() with the selected item as the target item and  value selected
        */
        private void tsmCountAdd100_Click(object sender, EventArgs e) => IncrementItemCount(SelectedItem, 100);
        private void tsmCountAdd10_Click(object sender, EventArgs e) => IncrementItemCount(SelectedItem, 10);
        private void tsmCountAdd1_Click(object sender, EventArgs e) => IncrementItemCount(SelectedItem, 1);
        private void tsmCountSubtract1_Click(object sender, EventArgs e) => IncrementItemCount(SelectedItem, -1);
        private void tsmCountSubtract10_Click(object sender, EventArgs e) => IncrementItemCount(SelectedItem, -10);
        private void tsmCountSubtract100_Click(object sender, EventArgs e) => IncrementItemCount(SelectedItem, -100);

        /*
            View Item is clicked in the item controls
            - Redirects to ViewItem() with the item as the target item
        */
        private void tsmViewItem_Click(object sender, EventArgs e)
        {
            ViewItem(SelectedItem);
        }

        /*
            Edit Item is clicked in the item controls
            - Redirects to EditItem() with the SelectedItem as the target item
        */
        private void tsmEditItem_Click(object sender, EventArgs e)
        {
            EditItem(SelectedItem);
        }

        /*
            Delete Item is clicked in the item controls    
            - Redirects to DeleteItem() with the SelectedItem as the target item
        */
        private void tsmDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteItem(SelectedItem);
        }

        #endregion

        #region SIDE BAR ITEMS

        /*
            Add new row button is clicked in the side bar
            - Redirects to AddNewItem()
        */
        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        /*
            Reload button is clicked in the side bar
            - Redirects to ReloadItems()
        */
        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadItems();
        }

        /*
            Redraw button is clicked in the side bar
            - Redirects to DrawItems()
        */
        private void btnRedraw_Click(object sender, EventArgs e)
        {
            DrawItems();
        }
        #endregion

        #region DRAWING TO THE DATA GRID VIEW

        /*
            Reloads the items on the data grid view
            - Loads from inventory table
            - Draws newly loaded items
        */
        private void ReloadItems()
        {
            LoadItems();
            DrawItems();
        }

        /*
            Draws items to the data grid view
            - Clears all the rows on the data grid view
            - Iterates over every item in the Item Container
            - Checks if the item should be drawn, if so draw it and increment the row ID to keep
            track of the row ID to keep track of where an item is on the data grid view
            - If the item should not be drawn it sets the RowID for that item to -1 so it will
            not be relevant when searching for an item at a position on the data grid view
            - Sets lblDrawCount to display the amount of items that are in the data grid view
        */
        private void DrawItems()
        {
            dgvItemGrid.Rows.Clear();
            int rowID = 0;

            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].Drawn = DrawItem(Items[i]);

                if (Items[i].Drawn)
                {
                    Items[i].RowID = rowID++;
                }
                else
                {
                    Items[i].RowID = -1;
                }
            }

            lblDrawCount.Text = $"Items Drawn: {rowID}";
        }

        /*
            Draws an individual item to the data grid view
            - Checks if the item should be drawn based on if it matches the search query in the search bar
            - If the item should be drawn it draws it and returns true to signify it drew the item
            - If the item should not be drawn it returns false to signify it did not draw the item
        */
        private bool DrawItem(Item item)
        {
            if (item.MatchesSearchQuery(tbSearchBar.Text))
            {
                dgvItemGrid.Rows.Add(
                    item.ID,
                    item.Name,
                    item.Description,
                    item.Count
                );

                return true;
            }

            return false;
        }

        /*
            Changes the values of a row at the item's position using the item's RowID
            - Saves having to redraw the entire data grid view if a value changes
        */
        private bool RedrawItem(Item item)
        {
            if (item.MatchesSearchQuery(tbSearchBar.Text))
            {
                dgvItemGrid.Rows[item.RowID].SetValues(
                    item.ID,
                    item.Name,
                    item.Description,
                    item.Count
                );

                return true;
            }

            return false;
        }
        #endregion

        #region INTERACT WITH DATABASE
        /*
            View an item in a ViewItemForm
        */
        private void ViewItem(Item item)
        {
            ViewItemForm form = new ViewItemForm(item);
            form.Show();
        }

        /*
            Add a new item with an AddNewItemForm
            - Adds the new item to the inventory table
            - Updates the Item Container to include the new item
            - Draws the new item to the data grid view
        */ 
        private void AddNewItem()
        {
            AddNewRowItem form = new AddNewRowItem();
            form.Show();

            form.CreatedItem += (object _sender, Item item) =>
            {
                DatabaseHelper.InsertItem(item);
                DatabaseHelper.GetItemID(item.Name, out item.ID);
                item.Drawn = DrawItem(item);
                Items.Add(item);

                ReMapRowIDs();
            };
        }

        /*
            Edit an item with the EditItemForm
            - Edits the item in the inventory table
            - Edits the Item Container to include the new version of the item
            - Redraws the item with the new values to the data grid view
            - Remaps the row IDs for all the drawn items
        */
        private void EditItem(Item before)
        {
            EditItemForm form = new EditItemForm(before);
            form.Show();

            form.EditedItem += (object _sender, Item item) =>
            {
                DatabaseHelper.EditItem(item);
                item.Drawn = RedrawItem(item);
                Items.EditItem(before, item);

                ReMapRowIDs();
            };
        }

        /*
            Deletes an item
            - Deletes the item from the inventory table
            - Removes the item from the Item Container
            - Removes the item from the data grid view
            - Remaps the row IDs for all the drawn items
        */ 
        private void DeleteItem(Item item)
        {
            DatabaseHelper.RemoveItem(item);
            Items.Remove(item);
            dgvItemGrid.Rows.RemoveAt(item.RowID);

            ReMapRowIDs();
            Console.WriteLine("Remapped IDs");
        }

        /*
            Loads all of the items from the inventory table
        */
        private void LoadItems()
        {
            Items = ItemContainer.LoadFromDatabase();
        }
        #endregion

        #region MISCELLANEOUS FUNCTIONS
        /*
            Remaps the row IDs for all of the drawn items
            - Sets the position of all of the drawn items to their position on the data grid view
            - Used when an item is added or removed to the inventory table, as the row IDs for all items must be updated accordingly
        */
        private void ReMapRowIDs()
        {
            int rowID = 0;

            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Drawn)
                {
                    Items[i].RowID = rowID++;
                }
            }

            lblDrawCount.Text = $"Items Drawn: {rowID}";
        }

        /*
            Gets the item at a position on the data grid view
            - If it finds the item it will set selected to that item and return true
            - If it does not find the item it will set selected to nothing and return false
        */
        private bool GetItemByRowID(int id, out Item selected)
        {
            foreach (Item item in Items)
            {
                if (item.RowID == id)
                {
                    selected = item;
                    return true;
                }
            }

            selected = default(Item);
            return false;
        }

        /*
            Increments the count of an item
            - If the number is negative it will automatically use subtraction
            - Sets the item count to the newly calculated count
            - Updated the Item Control to include the new item
            - Edits the item in the inventory table
            - Redraws the item to the data grid view
            - If the number is not valid it will display a message box error
        */
        private void IncrementItemCount(Item item, int count)
        {
            int result;

            if ((result = item.Count + count) > 0)
            {
                item.Count = result;

                Items[item.ID] = item;
                DatabaseHelper.EditItem(item);
                RedrawItem(item);
            }
            else
            {
                MessageBoxExt.DisplayError("Invalid Operation", "Count cannot be negative");
            }
        }
        #endregion
    }

    public class ItemContainer : List<Item>
    {
        /*
            Creates a new Item Container and sets the values to the items in the inventory table
        */ 
        public static ItemContainer LoadFromDatabase()
        {
            ItemContainer container = new ItemContainer();
            container.AddRange(DatabaseHelper.GetAllItems());
            return container;
        }

        /*
            Update an item in the container
        */
        public void EditItem(Item before, Item after)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i] == before)
                {
                    this[i] = after;
                    break;
                }
            }
        }
    }
}




