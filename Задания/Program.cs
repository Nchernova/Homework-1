// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a=5; b=7 -> max=7
// a=2; b=10 -> max=10
// a=-9; b=-3 -> max=-3
/*
Console.Write ("Input your 1st number: ");
int number_1= Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input your 2nd number: ");
int number_2= Convert.ToInt32 (Console.ReadLine());

if (number_1 < number_2)
{
  Console.WriteLine ($"Your first number is less than second number");

}
else
{
    Console.WriteLine($"Your first number is not less than second number");

}
*/


// Задача 3. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
/*
Console.Write ("Input your 1st number: ");
int num_1= Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input your 2nd number: ");
int num_2= Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input your 3nd number: ");
int num_3= Convert.ToInt32 (Console.ReadLine());


if (num_1 > num_3 )
{
Console.WriteLine ($"{num_1} is max");
}
else
{
Console.WriteLine($"{num_3} is max");
}
if (num_2 > num_3)
{
Console.WriteLine($"{num_2} is max");
}
*/


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
/*
Console.Write ("Input your number: ");
int number= Convert.ToInt32 (Console.ReadLine());

if ( (number/2) *2 == number)
{
Console.WriteLine ($"Your number is even" );
}
else
{
Console.WriteLine ($"Your number is not even");
}
*/


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
/*
Console.Write ("Input your number: ");
int number_N= Convert.ToInt32 (Console.ReadLine());
int current_i = 1;

while(current_i <= number_N)
    {
        if(current_i% 2 ==0)
        Console.Write(current_i + ", ");
        current_i ++;
    }
*/



