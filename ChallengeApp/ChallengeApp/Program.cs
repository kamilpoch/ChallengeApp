Console.WriteLine("write number");
var numberAsString = Console.ReadLine();
char[] letters = numberAsString.ToArray();
int Counter0 = 0;
int Counter1 = 0;
int Counter2 = 0;
int Counter3 = 0;
int Counter4 = 0;
int Counter5 = 0;
int Counter6 = 0;
int Counter7 = 0;
int Counter8 = 0;
int Counter9 = 0;
foreach (char letter in letters)
{
    if (letter == '0')
    {
        Counter0++;
    }
    else if (letter == '1')
    {
        Counter1++;
    }
    else if (letter == '2')
    {
        Counter2++;
    }
    else if (letter == '3')
    {
        Counter3++;
    }
    else if (letter == '4')
    {
        Counter4++;
    }
    else if (letter == '5')
    {
        Counter5++;
    }
    else if (letter == '6')
    {
        Counter6++;
    }
    else if (letter == '7')
    {
        Counter7++;
    }
    else if (letter == '8')
    {
        Counter8++;
    }
    else if (letter == '9')
    {
        Counter9++;
    }
}

Console.WriteLine("0 =>" + Counter0);
Console.WriteLine("1 =>" + Counter1);
Console.WriteLine("2 =>" + Counter2);
Console.WriteLine("3 =>" + Counter3);
Console.WriteLine("4 =>" + Counter4);
Console.WriteLine("5 =>" + Counter5);
Console.WriteLine("6 =>" + Counter6);
Console.WriteLine("7 =>" + Counter7);
Console.WriteLine("8 =>" + Counter8);
Console.WriteLine("9 =>" + Counter9);



