Console.WriteLine("BookFlow - Training booking");
Console.WriteLine();

string trainerName = "Alex";
Console.Write("Trainer: ");
Console.WriteLine(trainerName);

string serviceName = "Personal training";
Console.Write("Service: ");
Console.WriteLine(serviceName);

decimal sessionPrice = 500m;
Console.Write("Price: ");
Console.WriteLine(sessionPrice);

decimal clientBalance = 800m;
Console.Write("Balance: ");
Console.WriteLine(clientBalance);

bool isSlotAvailable = true;
Console.Write("Available: ");
Console.WriteLine(isSlotAvailable);


Console.WriteLine();

if (isSlotAvailable == false)
{
    Console.WriteLine("Slot unavailable");
}
else if (clientBalance < sessionPrice)
{
    Console.WriteLine("Not enough money");
}
else
{
    Console.WriteLine("Booking confirmed");
}

