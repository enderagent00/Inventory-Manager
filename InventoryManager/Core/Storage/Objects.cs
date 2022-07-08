
namespace InventoryManager.Core.Storage
{
    public class Item
    {
        public int RowID;
        public bool Drawn;

        public int ID;
        public string Name;
        public string Description;
        public int Count;

        public Item(int rowID, int Id, string name, string description, int count)
        {
            RowID = rowID;
            Drawn = false;

            ID = Id;
            Name = name;
            Description = description;
            Count = count;
        }

        public Item(int Id, string name, string description, int count)
        {
            ID = Id;
            Name = name;
            Description = description;
            Count = count;
        }

        public Item(string name, string description, int count)
        {
            Name = name;
            Description = description;
            Count = count;
        }

        /*
            Check if a search query matches the item's data
        */ 
        public bool MatchesSearchQuery(string query)
        {
            return string.IsNullOrWhiteSpace(query)
                || Compare(query, ID.ToString())
                || Compare(query, Name)
                || Compare(query, Description)
                || Compare(query, Count.ToString());
        }

        /*
            Compares two strings together to see if they contain one another
        */
        private bool Compare(string left, string right)
        {
            string _left = left.ToLower();
            string _right = right.ToLower();

            return _left.Contains(_right) || _right.Contains(_left);
        }
    }
}


