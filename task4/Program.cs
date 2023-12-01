// See https://aka.ms/new-console-template for more information
Console.WriteLine("put you income");

if (double.TryParse(Console.ReadLine(), out double income))
{
    if (TaxCalculating(income, out double tax))
    {
        Console.WriteLine($"You salary is {income} tax is {tax}");
        Console.WriteLine($"After tax {Math.Round( (income - tax),3)}");
    }  
}
else
{
    Console.WriteLine("cant calculate");
}
Console.ReadLine();

bool TaxCalculating (double income,out double tax)
{
     tax = income * 13d / 100; //13% 
    if (tax > 0)
    { return true; }
    else { return false; }   
}
