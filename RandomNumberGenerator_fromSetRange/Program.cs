try
{
    int min, max, howMuch;
    Random randomNumber = new Random();

    Console.WriteLine("Hey, I will pick and print for you choosen number of random numbers from choosen range.");
    Console.WriteLine("Enter min range: ");
    min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter maximum range: ");
    max = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("How many random numbers you want me to print: ");
    howMuch = Convert.ToInt32(Console.ReadLine());
    if (howMuch <= 0) {
        throw new Exception("Wrong amount of random numbers!");
    }
    if (max <= min)
    {
        throw new Exception("Wrong numbers range! Max cannot be smaller or equal then max!");
    }

    for (int i = 1; i <= howMuch; i++) {
        Console.WriteLine("Number {0} random is: " + randomNumber.Next(min, max+1), i);
    }
    
}
catch (Exception ex) {
    Console.WriteLine(ex); 
}

