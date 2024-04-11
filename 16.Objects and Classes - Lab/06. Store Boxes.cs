using System.ComponentModel;
using System.Numerics;
using System.Transactions;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> data = Console.ReadLine().Split().ToList();

        List<Box> boxes = new List<Box>();

        double result = 0;

        while (data[0] != "end")
        {
            declareData(data, boxes);

            data = Console.ReadLine().Split().ToList();
        }

        List<Box> newList = boxes.OrderByDescending(x => x.Result).ToList();

        foreach (Box items in newList)
        {
            Console.WriteLine(items.SerialNumber);
            Console.WriteLine($"-- {items.ItemName} - ${items.ItemPrice:F2}: {items.ItemQuantity}");
            Console.WriteLine($"-- ${items.Result:F2}");
        }
    }

    private static void declareData(List<string> data, List<Box> boxes)
    {
        int serialNum = int.Parse(data[0]);
        string itemName = data[1];
        int itemQuantity = int.Parse(data[2]);
        double itemPrice = double.Parse(data[3]);

        Box box = new Box(serialNum, itemName, itemQuantity, itemPrice);

        boxes.Add(box);
    }
}

internal class Box
{
    public int SerialNumber { get; set; }
    public string ItemName { get; set; }

    public int ItemQuantity { get; set; }
    public double ItemPrice { get; set; }

    public double Result { get; set; }

    public Box(int serial, string item, int quantity, double price)
    {
        SerialNumber = serial;
        ItemName = item;
        ItemQuantity = quantity;
        ItemPrice = price;
        Result = ItemPrice * ItemQuantity;
    }
}