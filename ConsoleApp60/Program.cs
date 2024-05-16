// Задание уровня Новичок:
//1
//2
//Console.WriteLine("Введите ваше имя: ");
//string name = Console.ReadLine();
//Console.WriteLine(name);

//3
//Console.WriteLine("Введите первое число: ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int b = int.Parse(Console.ReadLine());
//int res = a + b;
//Console.WriteLine(res);

//4
//Console.WriteLine("Введите число: ");
//int a = int.Parse(Console.ReadLine());
//if (a % 2 == 0) Console.WriteLine("Число четное");
//else Console.WriteLine("Нечетное");

//5
//Console.WriteLine("Введите первое число: ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите третье число: ");
//int c = int.Parse(Console.ReadLine());




//int maxNumber = a;
//if (b > a && b>c) maxNumber = b;
//else if (c > a && b > a && b<c) maxNumber = c;
//Console.WriteLine(maxNumber);


//Задания уровня База

//6
//Console.WriteLine("Введите число: ");
//int x = int.Parse(Console.ReadLine());
//long Factorial (int y)
//{
//    long f = 1;
//    for (int i = 0; i <= y; i++) f *= i;
//    return f;
//}
//Console.WriteLine(Factorial(x));



//7
//long summa (int x)
//{
//    long sum = 0;
//    for (int i = 1; i <= x; i++) sum += i;
//    return sum;

//}
//Console.WriteLine(summa(100));



//Console.WriteLine("Введите текст ");
//string text = Console.ReadLine();
//Console.WriteLine((int)text.Length);




//9
//Console.WriteLine("Введите число: ");
//int x = int.Parse(Console.ReadLine());
//bool result = true;
//for (int i = 2; i <x ; i++)
//{
//    if(x% i ==0) result = false;
//    break;
//}
//if (result)
//{
//    Console.WriteLine("Число простое");

//}
//else
//{
//    Console.WriteLine("Число непростое");
//}


//10
//Console.WriteLine("Введите число 1: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число 2: ");
//int number2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число 3: ");
//int number3 = int.Parse(Console.ReadLine());
//int avg = (number1 + number2 + number3) / 3;
//Console.WriteLine(avg);

//11

//Console.WriteLine("Введите первое число: ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите третье число: ");
//int c = int.Parse(Console.ReadLine());




//int minNumber = a;
//if (b < a && b < c) minNumber = b;
//else if (c < a && b < a && c < b ) minNumber = c;
//Console.WriteLine(minNumber);

//12




//Console.WriteLine("Введите текст: ");
//string str = Console.ReadLine()!;
//string res = "";
//for (int i = str.Length-1; i >=0; i--)
//{
//    res += str[i];
//}
//Console.WriteLine(res);

//13

//using System.Diagnostics.Tracing;

//Console.WriteLine("Введите слово: ");
//string text = Console.ReadLine();
//int startIndex = 0;
//int maxIndex = (int)text.Length;
//if (text[startIndex]== text[maxIndex-1])
//{
//    startIndex++;
//    maxIndex--;
//}
//if (text[startIndex]== text[maxIndex-1])
//{
//    Console.WriteLine("Палиндром");
//}
//else Console.WriteLine("Не палиндром");

// Уровень Любитель
//14
//Console.WriteLine("Введите число: ");
//int number = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = 1; i < number; i++)
//{
//    if (number % i == 0)
//        sum += i;
//}
//if (sum == number) Console.WriteLine("Число совершенное");
//else Console.WriteLine("Несовершенное");

//15

//for(int i = 1; i <= 100; i++)
//{
//    int k =0;
//    for(int j = 2; j < i; j++)
//    {
//        if (i % j == 0) k++;
//    }
//    if (k == 0) Console.Write(i + " ");
//}




//16


//int sum = 0;
//for (int i = 2; i <= 100; i+=2)
//{

//        sum+=i;

//}
//Console.Write(sum);

//17
//Console.WriteLine("Введите текст");
//string text = Console.ReadLine();
//string abc = "";
//for (int i = (int)'A'; i <(int)'z'; i++)
//{
//   if (Char.IsLetter((char)i)) abc += (char)i;

//}
//if(abc == text)
//{
//    Console.WriteLine("Содержит все буквы алфавита");
//}
//else
//{
//    Console.WriteLine("Не содержит все буквы");
//}

//18
//Console.WriteLine("Введите первое число: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int number2 = int.Parse(Console.ReadLine());
//if (number1 != 0 && number2 != 0)
//    if (number1 > number2)
//    {
//        number1 = number1 % number2;
//        Console.WriteLine(number1);
//    }
//else
//    {
//        number2 = number2 % number1;
//        Console.WriteLine(number2);
//    }
//19
//int sum = 0;
//while (true)
//    {
//    Console.WriteLine("Введите число: ");
//    int number = int.Parse(Console.ReadLine());

//    bool test = true;
//    if (number >= 0)
//    {
//        sum += number;

//    }
//    else if (number < 0)
//              {
//        break;
//    }

//}
//Console.WriteLine(sum);

// Уровень зануда
//20 //21 //22 //23
//using System.Diagnostics.CodeAnalysis;



//int[] mas = new int[8];
//int sum = 0;
//int x = 0;
//int max = 0;
//int min = 0;
//for (int i = 1; i < 8; i++)
//{


//    sum += i;
//    if (mas[i] % 2 == 0)
//    {
//        x++;
//    }
//    if (max > mas[i])
//    {
//        max = mas[i];
//    }
//    if (min < mas[i])
//    {
//        min = mas[i];
//    }


//}

//Console.WriteLine(sum);
//Console.WriteLine(x);
//Console.WriteLine(max);
//Console.WriteLine(min);

//24
//using System.Reflection.Metadata.Ecma335;
//using static System.Net.Mime.MediaTypeNames;

//int[] mas = new int[22];
//int startIndex = 0;
//int maxIndex = mas.Length;
//for (int i = 1; i < 9; i++)
//{

    
//    if (mas[startIndex] == mas[maxIndex - 1])
//    {
//        startIndex++;
//        maxIndex--;
//    }
    
 
//}
//25//26//27////28//29//30//31


//32
int proizvidenie(int x,int y)
{
    int proizv = x * y;
    return proizv;
}
//33
void prost (int x)
{
    for (int i = 1; i <= 100; i++)
    {
        int k = 0;
        for (int j = 2; j < i; j++)
            if (k == 0)
                return x;
    }
}
Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine(prost(x));







