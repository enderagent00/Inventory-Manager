
using System;
using System.IO;
using System.Data.SQLite;
using System.Collections.Generic;

namespace InventoryManager.Core.Storage
{
    public static class DatabaseHelper
    {
        public static string DatabaseFile = $@"{Program.DependenciesDirectory}\database.db";

        #region CREATE TABLES
        /*
            Setups up database freshly
        */
        public static void CreateTables()
        {
            if (File.Exists(DatabaseFile))
            {
                File.Delete(DatabaseFile);
            }

            SQLiteConnection.CreateFile(DatabaseFile);
            CreateInventoryTable();
        }

        /*
            Creates the table to hold inventory items
        */
        private static void CreateInventoryTable()
        {
            const string cmd = @"
CREATE TABLE ItemTbl (
    ItemID               INTEGER PRIMARY KEY NOT NULL,
    Name                 TEXT,
    Description          TEXT,
    Count                INTEGER
)
                                ";

            using (SQLiteConnection connection = CreateConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(cmd, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region WRITE TO DATABSE

        /*
            Adds an item to the inventory table 
        */
        public static void InsertItem(Item item)
        {
            const string cmd = @"
INSERT INTO ItemTbl (Name, Description, Count)
VALUES (@Name, @Description, @Count)
                                ";

            using (SQLiteConnection connection = CreateConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(cmd, connection))
                {
                    command.Parameters.AddWithValue("@Name", item.Name);
                    command.Parameters.AddWithValue("@Description", item.Description);
                    command.Parameters.AddWithValue("@Count", item.Count);
                    command.ExecuteNonQuery();
                }
            }
        }

        /*
            Edits an item in the inventory table
        */
        public static void EditItem(Item item)
        {
            const string cmd = @"
UPDATE ItemTbl SET
    Name = @Name,
    Description = @Description,
    Count = @Count
WHERE ItemID = @ItemID
                                ";

            using (SQLiteConnection connection = CreateConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(cmd, connection))
                {
                    command.Parameters.AddWithValue("@Name", item.Name);
                    command.Parameters.AddWithValue("@Description", item.Description);
                    command.Parameters.AddWithValue("@Count", item.Count);
                    command.Parameters.AddWithValue("@ItemID", item.ID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /*
            Removes item from the inventory table
        */
        public static void RemoveItem(Item item)
        {
            const string cmd = @"
DELETE FROM ItemTbl WHERE ItemID = @ItemID
                                ";

            using (SQLiteConnection connection = CreateConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(cmd, connection))
                {
                    command.Parameters.AddWithValue("@ItemID", item.ID);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region READ FROM DATABASE

        /*
            Returns all of the items in the inventory table as a List
        */
        public static List<Item> GetAllItems()
        {
            const string cmd = @"
SELECT * FROM ItemTbl
                                ";

            List<Item> items = new List<Item>();

            using (SQLiteConnection connection = CreateConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(cmd, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["ItemID"]);
                            string name = Convert.ToString(reader["Name"]);
                            string description = Convert.ToString(reader["Description"]);
                            int count = Convert.ToInt32(reader["Count"]);

                            Item item = new Item(id, name, description, count);
                            items.Add(item);
                        }
                    }
                }
            }

            return items;
        }

        /*
            Checks if the name of an item already exists in the inventory table
        */
        public static bool ItemNameExists(string itemName)
        {
            const string cmd = @"
SELECT * FROM ItemTbl WHERE Name = @Name
                                ";


            using (SQLiteConnection connection = CreateConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(cmd, connection))
                {
                    command.Parameters.AddWithValue("@Name", itemName);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
            }
        }

        /*
            Gets the item ID from the item name from the inventory table
        */
        public static bool GetItemID(string itemName, out int itemID)
        {
            const string cmd = @"
SELECT * FROM ItemTbl WHERE Name = @Name
                                ";

            using (SQLiteConnection connection = CreateConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(cmd, connection))
                {
                    command.Parameters.AddWithValue("@Name", itemName);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            itemID = Convert.ToInt32(reader["ItemID"]);
                            return true;
                        }
                        else
                        {
                            itemID = default(int);
                            return false;
                        }
                    }
                }
            }
        }
        #endregion

        #region CREATE CONNECTION

        /*
            Created a connection to the database file
        */
        private static SQLiteConnection CreateConnection()
        {
            SQLiteConnection connection = new SQLiteConnection($"Data Source = {DatabaseFile}; Version = 3;");
            connection.Open();
            return connection;
        }
        #endregion
    }
}


