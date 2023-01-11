// Урок 7. Двумерные массивы

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine ("Введите колическтво строк");
int LinesVol=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите колическтво столбцов");
int columnsVol=Convert.ToInt32(Console.ReadLine());
double [,] number=new double [LinesVol,columnsVol];
FillArrayRandomNumbers (numbers);
PrintArray (number);
VoidFillArrayRandomNumbers (double [,],array);
{
    for (int i=0; i<Array.Getlength (0);i++)
    {
        for (int j=0; j<Array.Getlength (1);j++)
        { Array[i,j]=new Random().NextDouble()*100;
        }
    }
}
void PrintArray (double[,]array)
{
 for (int i=0; i<Array.Getlength (0);i++)
 {
    Console.Write ("[");
    for (int j=0; j<Array.Getlength (1);j++)
    {
        Console.Write (array [i,j]+"");
    }
    Console.Write ("]");
    Console.WriteLine ("");
 }   
}

_______________________________
//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine ("Введите колическтво строк");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите колическтво столбцов");
int m=Convert.ToInt32(Console.ReadLine());
int [,] number=new int [n,m];
FillArrayRandomNumbers (number);

for (int j=0; j<number.Getlength (1);j++)
    {
        double avarage=0;
        for (int i=0; i<number.Getlength (0);i++)
        { avarage+=numbers[i,j];
        }
        avarage=avarage/n;
        Console.Write(avarage+";");
    }

Console.WriteLine ();
PrintArray (numbers);
void FillArrayRandomNumbers(int[,]array)
{
    for (int i=0; i<Array.Getlength (0);i++)
    {
        for (int j=0; j<Array.Getlength (1);j++);
        {
            array[i,j]=new Random().Next(10);
        }
    }
    
 }  
 void PrintArray(int[,]array)
 {
    for(int i=0;i<array.GetLength(0);i++)
    {
        Console.Write ("[");
        for (int j=0; j<array.GetLength(1); j++);
        {
           Console.Write (array[i,j]+""); 
        }
        Console.Write ("]");
        Console.WriteLine ("");
    }

 } 
 



