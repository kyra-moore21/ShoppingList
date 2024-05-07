
//dictionary
using System.Diagnostics;

Dictionary<string, decimal> items = new Dictionary<string, decimal>();
//list
List<string> cart = new List<string>();
items.Add("apple",  0.99m);
items.Add("banana", 0.59m);
items.Add("cauliflower", 1.59m);
items.Add("raspberries", 2.5m);
items.Add("watermelon", 3.00m);
items.Add("blueberries", 4.32m);
items.Add("mango", 1.42m);
items.Add("passionfruit", 6.00m);
//Dictionary<string, decimal> cartComplete = new Dictionary<string, decimal>();
bool buySomething = true;
string choice = "";
while (buySomething)
{
    Console.WriteLine(Redisplay(items));
    Console.WriteLine("What would you like to add to your cart?");
    string fruit = Console.ReadLine().Trim().ToLower();

    //fruit validation
    if (!items.ContainsKey(fruit))
    {
        Console.WriteLine("Sorry, we don't carry those. Please try again.");
        continue;

    } else 
    {
        cart.Add(fruit);
        //cartComplete.Add(fruit, items[fruit]);
        Console.WriteLine($"Adding {fruit} to cart at {items[fruit], 0:C}.");
      
    }
    //add more fruit
    while (true)
    {
        Console.WriteLine("Would you like to add more to your cart?");
        choice = Console.ReadLine().ToLower().Trim();
        if (choice == "n")
        {
            buySomething = false;
            break;
        }
        else if (choice == "y")
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid Input. Please try again.");
        }
    }
}
//get sum
decimal sum = 0;
decimal maxValue = 0;
decimal minValue = 0;
string item = "Item";
string price = "Price";
Console.WriteLine("Thanks for your order!");
Console.WriteLine("Here is your receipt");
Console.WriteLine($"{item,-18} {price,10}");
Console.WriteLine("====================================");
//display back to user
foreach (string s in cart.OrderByDescending(i => items[i]))
{

    
    if (items.ContainsKey(s))
    {
        maxValue = items.Values.Max();
        minValue = items.Values.Min();
        sum += items[s];
        Console.WriteLine($"{s,-18} {items[s],10:C}");
        //foreach (KeyValuePair<string, decimal> s2 in cartComplete.OrderByDescending(i => i.Value))
        //{

        //    Console.WriteLine($"{s2.Key}, {s2.Value}");  
        //}
        //break;
       

    }
}
Console.WriteLine($"Max: {maxValue}");
Console.WriteLine($"Min: {minValue}");
Console.WriteLine($"Your total is {sum, 10:C}");




//methods
static string Redisplay(Dictionary<string, decimal> display)
{
        //declaring for nice formatting
    string item = "Item";
    string price = "Price";
    Console.WriteLine($"{item,-18} {price,10}");
    Console.WriteLine("====================================");
    foreach (KeyValuePair<string, decimal> kvp in display.OrderBy(i => i.Value))
    {
        Console.WriteLine($"{kvp.Key,-18} {kvp.Value,10:C} ");
        

    }

    return "";
}

