using System;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // TODO: Update the item's price with the new price.
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
        Console.WriteLine($"You have added {additionalQuantity} {ItemName}'s.");
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        if (quantitySold <= 0)
        {
            Console.WriteLine($"{quantitySold} is not a valid number.");

        }
        else if (QuantityInStock >= quantitySold)
        {
            QuantityInStock -= quantitySold;
            Console.WriteLine($"You have sold {quantitySold} {ItemName}'s.");
        }
        else
        {
            Console.WriteLine("You do not have enough items in stock available to sell.");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine($"\nItem Name: {ItemName}");
        Console.WriteLine($"Item ID: {ItemId}");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        // 2. Sell some items and then print the updated details.
        // 3. Restock an item and print the updated details.
        // 4. Check if an item is in stock and print a message accordingly.

        // Print details of all items
        Console.WriteLine("Inventory List:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Sell items that are more than the available inventory
        Console.WriteLine("\nSelling 20 Laptop's:");
        item1.SellItem(20);
        Console.WriteLine("\nSelling 16 Smartphone's:");
        item2.SellItem(16);


        // Sell some items (negetaive scenerios)
        Console.WriteLine("\nSelling -4 Laptop's in Inventory:");
        item1.SellItem(-4);
        Console.WriteLine("\nSelling -6 Smartphone's in Inventory:");
        item2.SellItem(-6);

        // Sell some items and then print the updated details (positive scenerios)
        Console.WriteLine("\nSelling 4 Laptop's in Inventory:");
        item1.SellItem(4);
        item1.PrintDetails();

        Console.WriteLine("\nSelling 6 Smartphone's in Inventory:");
        item2.SellItem(6);
        item2.PrintDetails();


        // Restock an item and print the updated details
        Console.WriteLine("\nAdding 5 Laptop's to inventory");
        item1.RestockItem(5);
        item1.PrintDetails();

        Console.WriteLine("\nAdding 10 Smartphone's to inventory");
        item2.RestockItem(10);
        item2.PrintDetails();

        // Check if an item is in stock and print a message accordingly
        Console.WriteLine($"\nIs item 101 - Laptop in stock? {item1.IsInStock()}");
        Console.WriteLine($"Is item 102 - Smartphone in stock? {item2.IsInStock()}");
    }
}
