int number = 4566;
string numText = number.ToString();
char[] letters = numText.ToArray();
Console.WriteLine("Wyniki dla licby:  " + numText);

//string[] setOfNumbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
int[] digit = new int[10];

foreach (char letter in numText)
    {
        int letterValue = (int)Char.GetNumericValue(letter);
        digit[letterValue]++;

    }
for (var i = 0; i < 10; i++)

    Console.WriteLine( i + " =>  " + digit[i]);