﻿
// //[строки, столбцы]
// string[,] table = new string[2, 5];
// //String.Empty
// //table[0,0]  table[0,1] table[0,2] table[0,3] table[0,4] 
// //table[1,0]  table[1,1] table[1,3] table[1,3] table[1,4]

// //чтобы обратиться к нужному элементу указываем наименование массива 
// //и далее в квадратных скобках указываем индекс строки и столбца
// table[1, 2] = "слово";

// //распечатаем массив
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }



void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Метод заполнения матрицы случайными числами
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix); 
// Console.WriteLine();
// PrintArray(matrix);

int[,] pic = new int[,]
{
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,1,1,1,0,0,0,1,1,1,0,0,0,0},
{0,0,1,0,0,0,1,0,1,0,0,0,1,0,0,0},
{0,1,0,0,0,0,0,1,0,0,0,0,0,1,0,0},
{0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0},
{0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0},
{0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0},
{0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0},
{0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0},
{0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0},
{0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0},
};

void PrintImege(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

//метод закрашивающий картинку

// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }

// FillImage(5,6);
// PrintImege(pic);

// int Factorial(int n)
// {
//     //1!=1
//     //0!=1
//     if (n == 1) return 1;
//     else return n* Factorial(n-1);
// }

// Console.WriteLine(Factorial(3)); //1*2*3 =6

//f(1)=1
//f(2)=1
//f(f)=f(n-1)+f(n-2)

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1)+Fibonacci(n-2);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"f({i})= {Fibonacci(i)}");
}