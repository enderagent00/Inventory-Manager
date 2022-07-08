
using System.Windows.Forms;

namespace InventoryManager.Forms
{
    public static class MessageBoxExt
    {
        /*
            Display an error to the user
        */ 
        public static void DisplayError(string title, string text)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

