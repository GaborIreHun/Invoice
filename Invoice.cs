using System;

class Invoice
{

    public string name;

    public string partNumber;

    public string description;

    public int quantity;

    public decimal pricePerItem;

    


    public void SetName(string invoiceName)
    {
        name = invoiceName;
    }

    public string GetName()
    {
        return name;
    }



    public void SetPartNumber(string invoicePartNumber)
    {
        partNumber = invoicePartNumber;
    }

    public string GetPartNumber()
    {
        return partNumber;
    }



    public void SetDescription(string invoiceDescription)
    {
        description = invoiceDescription;
    }

    public string GetDescription()
    {
        return description;
    }



    public void SetQuantity(int invoiceQuantity)
    {

        quantity = invoiceQuantity;
        
    }

    public int GetQuantity()
    {
        return quantity;
    }



    public void SetPricePerItem(decimal invoicePricePerItem)
    {
        pricePerItem = invoicePricePerItem;
    }

    public decimal GetPricePreItem()
    {
        return pricePerItem;
    }



}



