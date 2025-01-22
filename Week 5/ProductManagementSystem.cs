using System;

abstract class BaseMakine
{
    // Common properties for both Phone and Computer
    public DateTime ProductionDate { get; set; }
    public string SerialNumber { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string OperatingSystem { get; set; }

    // Constructor to set production date
    public BaseMakine()
    {
        ProductionDate = DateTime.Now; // Automatically set production date when an object is created
    }

    // Method to display common information
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Production Date: {ProductionDate}");
        Console.WriteLine($"Serial Number: {SerialNumber}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Operating System: {OperatingSystem}");
    }

    // Abstract method to be implemented in derived classes
    public abstract void GetProductName();
}

class Phone : BaseMakine
{
    public bool IsTrLicensed { get; set; }

    // Override to display phone-specific information
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"TR Licensed: {IsTrLicensed}");
    }

    // Implement the abstract method for phone
    public override void GetProductName()
    {
        Console.WriteLine($"Your phone's name ---> {Name}");
    }
}

class Computer : BaseMakine
{
    public int UsbPorts { get; set; }
    public bool HasBluetooth { get; set; }

    // Property encapsulation for USB ports
    public int UsbPortCount
    {
        get { return UsbPorts; }
        set
        {
            if (value == 2 || value == 4)
                UsbPorts = value;
            else
                UsbPorts = -1; // Invalid value
        }
    }

    // Override to display computer-specific information
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"USB Ports: {UsbPorts}");
        Console.WriteLine($"Bluetooth: {HasBluetooth}");
    }

    // Implement the abstract method for computer
    public override void GetProductName()
    {
        Console.WriteLine($"Your computer's name ---> {Name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Press 1 to create a Phone or 2 to create a Computer:");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Phone phone = new Phone();
                Console.Write("Enter Serial Number: ");
                phone.SerialNumber = Console.ReadLine();
                Console.Write("Enter Name: ");
                phone.Name = Console.ReadLine();
                Console.Write("Enter Description: ");
                phone.Description = Console.ReadLine();
                Console.Write("Enter Operating System: ");
                phone.OperatingSystem = Console.ReadLine();
                Console.Write("Is TR Licensed? (true/false): ");
                phone.IsTrLicensed = Convert.ToBoolean(Console.ReadLine());

                phone.DisplayInfo();
                phone.GetProductName();
            }
            else if (choice == "2")
            {
                Computer computer = new Computer();
                Console.Write("Enter Serial Number: ");
                computer.SerialNumber = Console.ReadLine();
                Console.Write("Enter Name: ");
                computer.Name = Console.ReadLine();
                Console.Write("Enter Description: ");
                computer.Description = Console.ReadLine();
                Console.Write("Enter Operating System: ");
                computer.OperatingSystem = Console.ReadLine();
                Console.Write("Enter USB Ports (2 or 4): ");
                computer.UsbPortCount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Does it have Bluetooth? (true/false): ");
                computer.HasBluetooth = Convert.ToBoolean(Console.ReadLine());

                computer.DisplayInfo();
                computer.GetProductName();
            }

            Console.WriteLine("Do you want to create another product? (yes/no):");
            string continueChoice = Console.ReadLine();
            if (continueChoice.ToLower() != "yes")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}
