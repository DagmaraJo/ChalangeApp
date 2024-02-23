int number = 4566;
string numText = number.ToString();
char[] letersAsNumber = numText.ToArray();
Console.WriteLine("Wyniki dla licby:  " + numText);

List<char> leters = new() { '0', '1', '3', '4','5','6','7', '8', '9' };

foreach (var digit in leters)
{
    int count = 0;
    foreach (char leterAsNumber in letersAsNumber)
    {
        if (leterAsNumber == digit )
        {
            count++;
        }
    }
    Console.WriteLine($"{digit} =>  {count}");
}