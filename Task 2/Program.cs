// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
string S = Console.ReadLine();
int sum =SumNum(S);
System.Console.WriteLine(sum);

int SumNum(string str)
{
    int sum=0;
    
    for (int i=0; i<str.Length; i++)
    {
        string NumStr = Convert.ToString(str[i]);
        int Nat = Convert.ToInt32(NumStr);
        sum=sum+Nat;
    }
    return sum;
}   