using System;

class InvoiceTest
{
    static void Main()
    {
        Invoice invoice = new Invoice();

        

        Console.WriteLine("Enter name on the invoice: ");
        string invoicetheName = Console.ReadLine();
        invoice.SetName(invoicetheName);


        Console.WriteLine("Enter the part number: ");
        string invoicethePartNumber = Console.ReadLine();
        invoice.SetPartNumber(invoicethePartNumber);


        Console.WriteLine("Enter the description: ");
        string invoicetheDescription = Console.ReadLine();
        invoice.SetDescription(invoicetheDescription);


        Console.WriteLine("Enter the quantity: ");
        int invoicetheQuantity = int.Parse(Console.ReadLine());
        invoice.SetQuantity(invoicetheQuantity);


        Console.WriteLine("Enter the price: ");
        decimal invoicethePicePerItem = decimal.Parse(Console.ReadLine());
        invoice.SetPricePerItem(invoicethePicePerItem);

        Console.WriteLine($"\nCustomer: {invoice.GetName()}");
        Console.WriteLine($"\nPart number: {invoice.GetPartNumber()}");
        Console.WriteLine($"\nDescription: {invoice.GetDescription()}");
        Console.WriteLine($"\nQuantity: {invoice.GetQuantity()}");
        Console.WriteLine($"\nPrice: {invoice.GetPricePreItem()}");
        Console.WriteLine($"\nTotal: {invoice.GetQuantity() * invoice.GetPricePreItem()}");


    }
    
}