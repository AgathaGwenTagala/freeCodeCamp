// Add looping logic to your code using the do-while and while statements in C#
// Exercise - Create do and while iteration loops
/*Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

// Write a while statement that iterates only while a random number is greater than some value
/* Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

// Use the continue statement to step directly to the Boolean expression
/* Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
*/

// Code challenge - Role playing game battle challenge
/* int hero = 10;
int monster = 10;

Random random = new Random();
int attack = random.Next(1, 11);

do
{
    // hero attacks
    attack = random.Next(1, 11);
    monster -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monster} health.");

    if (monster <= 0) continue;

    // monster attacks
    attack = random.Next(1, 11);
    hero -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {hero} health.");
} while (hero > 0 && monster > 0);
Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/

// Code project 1 - write code that validates integer input
/* string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();
*/

// Code project 2 - write code that validates string input
/* string? readResult;
string role = "";
bool validEntry = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        role = readResult.Trim();
    }

    if (role.ToLower() == "administrator" || role.ToLower() == "manager" || role.ToLower() == "user")
    {
        validEntry = true;
    }
    else 
    {
        Console.WriteLine($"The role name that you entered, \"{role}\" is not valid.");
    }
} while (validEntry == false);

Console.WriteLine($"Your input value ({role}) has been accepted.");
readResult = Console.ReadLine();
*/

// Code project 3 - Write code that processes the contents of a string array
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {
        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}