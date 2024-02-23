int number = 4566;
string numText = number.ToString();
Console.WriteLine("Wyniki dla licby:  " + numText);

int[] digit = new int[10];

foreach (char letter in numText)
{
    int letterValue = (int)Char.GetNumericValue(letter);
    digit[letterValue]++;

}
for (var i = 0; i < 10; i++)

    Console.WriteLine(i + " =>  " + digit[i]);













