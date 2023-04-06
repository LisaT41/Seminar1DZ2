// 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Write first number ");
string value1;
value1 = Console.ReadLine();
int numberA = Convert.ToInt32(value1);

System.Console.Write("Write seconde number ");
string value2;
value2 = Console.ReadLine();
int numberB = Convert.ToInt32(value2);

System.Console.Write("Write third number ");
string value3;
value3 = Console.ReadLine();
int numberC = Convert.ToInt32(value3);

int max = numberA;
if (max < numberB)
{
   int max = numberB;
}
if (max < numberC)
{
    int max = numberC;
}
System.Console.WriteLine("max");
