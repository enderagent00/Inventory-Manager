
# InventoryManager

### About

This is a Windows Forms applications which uses a database to store Items. It is an example of an inventory manager, it gives the user the ability to add and remove items from the inventory which will save for when the user next uses it. 

### Features
- Add items to the database
- Remove an item from the database
- View an item in the database
- Change the values of an item
- Error checking on item creation
- Cannot have an item with the same name
- Stores items in a local database

### Inventory Manager Form

![Screenshot](https://user-images.githubusercontent.com/97055625/178074827-d6209df0-9b04-4dee-a90c-08b39e2f20b4.png)

### Inventory Manager Sub Forms

These are forms which provide their own purpose. For example, the form below allows the user to add a new item to the table. There are other forms like editing an item or just viewing it. This form will then tell the main form an item has been created. 

![AddNewItem](https://user-images.githubusercontent.com/97055625/178075018-50959e6b-50ab-417b-af57-5d9ef4e188d6.png)

Sub Forms like these also support error handling, for example you create a new item without a name. 

![AddNewItemError](https://user-images.githubusercontent.com/97055625/178075048-24aceccb-2f96-48b3-a60f-5ff30bcb78cd.png)
