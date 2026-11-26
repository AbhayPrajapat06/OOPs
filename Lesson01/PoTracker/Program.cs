class PurchaseOrder
{
    public int PoNumber;
    public string Vendor = "";
    public int Amount;
    public string Status = "Open";

    public void Show()
    {
        Console.WriteLine($"PO#{PoNumber} | {Vendor} | Rs.{Amount} | {Status}");
    }
}

class Program
{
    static void Main()
    {
        List<PurchaseOrder> orders = new List<PurchaseOrder>();

        while (true)
        {
            Console.WriteLine("\n1. Add PO");
            Console.WriteLine("2. Show all POs");
            Console.WriteLine("3. Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                PurchaseOrder po = new PurchaseOrder();
                Console.Write("PO number: ");
                po.PoNumber = int.Parse(Console.ReadLine() ?? "0");
                Console.Write("Vendor: ");
                po.Vendor = Console.ReadLine() ?? "";
                Console.Write("Amount: ");
                po.Amount = int.Parse(Console.ReadLine() ?? "0");
                orders.Add(po);
                Console.WriteLine("PO added.");
            }
            else if (choice == "2")
            {
                foreach (PurchaseOrder po in orders)
                {
                    po.Show();
                }
            }
            else if (choice == "3")
            {
                break;
            }
        }
    }
}