// See https://aka.ms/new-console-template for more information


// TODO: task 2

// string input = Console.ReadLine()!;
// int number;
// bool res = int.TryParse(input, out number);


// if (res == true)
// {
//     Console.WriteLine($"{number} is a number");
// }
// else
// {
//     Console.WriteLine($"{input} is not a number, it is a string");
// }



// TODO: task 3

// for (int i = 0; i < 10; i++)
//     if (i % 2 == 0)
//         Console.Write($"{i} ");

// Console.WriteLine();


// TODO: task 3.5



// static void calcroots(int a, int b, int c)
// {
//     double d = Math.Sqrt(b * b - 4 * a * c);
//     double temp = ((-1 * b) + d) / (2 * a);
//     double x1 = Math.Sqrt(temp);
//     double x2 = x1 * (-1);

//     double tempp = ((-1 * b) - d) / (2 * a);
//     double x3 = Math.Sqrt(tempp);
//     double x4 = x3 * (-1);

//     double[] arr =  new double[4];

//     arr[0] = x1;
//     arr[1] = x2;
//     arr[2] = x3;
//     arr[3] = x4;

//     for (int i = 0; i < 4; i++)
//     {
//         for (int j = 0; j < i + 1; j++)
//         {
//             if (arr[j] > arr[i])
//             {
//                 double p = arr[i];
//                 arr[i] = arr[j];
//                 arr[j] = p;
//             }
//         }
//     }

//     foreach (var item in arr)
//     {
//         Console.WriteLine(item);
//     }
// }

// int a = 1;
// int b = -5;
// int c = 4;
// calcroots(a,b,c);

// TODO: task 4

// static void AnalyzeWithIf(object?[] data)
// {
//     foreach(object? obj in data)
//     {
//         if(obj is null)
//         {
//             Console.WriteLine("object is null");
//         }

//         else if (obj is int i1)
//         {
//             if (i1 > 0)
//             {
//                 Console.WriteLine($"{obj} is a positive number");
//             }

//             else if (i1 < 0)
//             {
//                 Console.WriteLine($"{obj} is a negative number");
//             }

//             else
//             {
//                 Console.WriteLine($"{obj} is a zero");
//             }
//         }

//         else if(obj is string s1)
//         {
//             Console.WriteLine($"{obj} is a string");
//         }

//         else
//         {
//             Console.WriteLine("idk what object is");
//         }
//     }
// }


// static void AnalyzeWithSwitch(object?[] data)
// {
//     foreach (object? obj in data)
//     {
//         switch (obj)
//         {
//             case null:
//                 Console.WriteLine("object is null");
//                 break;

//             case string s1:
//                 Console.WriteLine($"{obj} is a string");
//                 break;

//             case int i1:
//                 if (i1 > 0)
//                 {
//                     Console.WriteLine($"{obj} is a positive number");
//                 }

//                 else if (i1 < 0)
//                 {
//                     Console.WriteLine($"{obj} is a negative number");
//                 }

//                 else
//                 {
//                     Console.WriteLine($"{obj} is a zero");
//                 }

//                 break;

//             default:
//                 Console.WriteLine("idk what object is");
//                 break;
//         }
//     }
// }

// static string GetCategory(object? obj) => obj switch
// {
//     int i when i > 0 => "Positive number",
//     int i when i < 0 => "Negative number",
//     int i => "Zero",
//     string s => "String",
//     null => "Null",
//     _ => "Unknown"
// };

// object?[] data = { 15, "Hello", -5, null,  "World", 42, 0, "C#", -10 };

// AnalyzeWithIf(data);
// Console.WriteLine("------------------------------");
// AnalyzeWithSwitch(data);
// Console.WriteLine("------------------------------");
// foreach (var item in data)
// {
//     Console.WriteLine($"{item ?? "null"} - {GetCategory(item)}");
// }




// TODO: task 5

// int[] numbers = {5, -3, 8, 12, -7, 0, 15, -2, 4, 20};

// static void printEvenIndx(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i % 2 == 0)
//         {
//             Console.WriteLine(arr[i]);
//         }
//     }
// }

// static int calculateSum(int[] arr)
// {
//     int res = 0;
//     foreach(int item in arr)
//     {
//         res += item;
//     }

//     return res;
// }

// static int findFirstGreaterThan(int[] arr, int num)
// {
//     int i = 0;
//     while (true)
//     {
//         if (arr[i] > num)
//         {
//             return arr[i];
//         }
//         i++;
//     }
// }

// static void printSumUntilLimit(int[] arr, int limit)
// {
//     int sum = 0;
//     int i = 0;
//     do
//     {
//         sum += arr[i];
//         i++;
//         Console.WriteLine(sum);
//     } while (sum < limit);
// }

// static void printPositiveOnly(int[] arr)
// {
//     foreach (var item in arr)
//     {
//     if (item <= 0)
//     {
//         continue;
//     }
//     Console.WriteLine(item);
//     }
// }

// printEvenIndx(numbers);
// Console.WriteLine("--------------------");
// int r = calculateSum(numbers);
// Console.WriteLine(r);
// Console.WriteLine("--------------------");
// int rr = findFirstGreaterThan(numbers, 9);
// Console.WriteLine(rr);
// Console.WriteLine("--------------------");
// printSumUntilLimit(numbers, 11);
// Console.WriteLine("--------------------");
// printPositiveOnly(numbers);


// TODO: task 5


// static void PrintMatrix(int[,] matrix)
// {
//     if (matrix == null || matrix.Length == 0)
//     {
//         Console.WriteLine("matrix is free");
//         return;
//     }

//     int rows = matrix.GetLength(0);
//     int cols = matrix.GetLength(1);

//     for (int row = 0; row < rows; row++)
//     {
//         for (int col = 0; col < cols; col++)
//         {
//             Console.Write($"{matrix[row, col]} ");
//         }
//         Console.WriteLine();
//     }

// }

// static bool IsSymmetric(int[,] matrix)
// {
//     int rows = matrix.GetLength(0);
//     int cols = matrix.GetLength(1);

//     if (rows != cols || rows == 0)
//     {
//         return false;
//     }

//     for (int row = 0; row < rows; row++)
//     {
//         for (int col = row + 1; col < cols; col++)
//         {
//             if (matrix[row, col] != matrix[col, row])
//             {
//                 return false;
//             }
//         }
//     }

//     return true;
// }

// int[,] matrix1 = { { 1, 2, 4, 5 }, { 3, 4, 6, 8 } };
// int[,] matrix2 = {{ 1, 2, 3 }, { 2, 5, 6}, {3, 6, 9}};
// int[,] matrix3 = {{ 1, 2, 5 }, { 2, 5, 8}, {3, 6, 9}};

// PrintMatrix(matrix1);
// bool r = IsSymmetric(matrix1);
// Console.WriteLine(r);
// Console.WriteLine("----");
// PrintMatrix(matrix2);
// bool rr = IsSymmetric(matrix2);
// Console.WriteLine(rr);
// Console.WriteLine("----");
// PrintMatrix(matrix3);
// bool rrr = IsSymmetric(matrix3);
// Console.WriteLine(rrr);
// Console.WriteLine("----");

// TODO: task 6



static void PrintArrayNull(int?[] arr)
{
    foreach (var item in arr)
    {
        if (item is not null)
        {
            Console.Write($"{item} ");
        }
        else
        {
            Console.Write("null ");
        }
    }
    Console.WriteLine();
}

static void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

static int CountNull(int?[] arr)
{
    int counter = 0;

    foreach (var item in arr)
    {
        if (item is null)
        {
            counter++;
        }
    }

    return counter;
}

static int CountNotNull(int?[] arr)
{
    int counter = 0;

    foreach (var item in arr)
    {
        if (item is not null)
        {
            counter++;
        }
    }

    return counter;
}


// Считаем что в массиве или числа, или null.
static int CountSum(int?[] arr)
{
    int sum = 0;

    foreach (var item in arr)
    {
        if (item.HasValue)
        {
            sum += item.Value;
        }
    }

    return sum;
}

static int[] CreateNewArrayWithNoNull(int?[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i] ?? -1;
    }

    return newArr;
}

static void PrintLength(int?[] arr)
{
    foreach (var item in arr)
    {
        string str = item?.ToString() ?? "null";

        Console.WriteLine($"element: {str}, length: {str.Length}");
    }
}

static void ReplaceNullZeros(int?[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] ??= 0;
    }
}

int?[] numbers = {10, null, 25, null, 30, 15, null};

Console.WriteLine("--------------------------------");
PrintArrayNull(numbers);
Console.WriteLine("--------------------------------");

int countNotNull = CountNotNull(numbers);
int countNull = CountNull(numbers);

Console.WriteLine($"null objects: {countNull}, not null objects: {countNotNull}");
Console.WriteLine("--------------------------------");

int sum = CountSum(numbers);
Console.WriteLine($"sum of not null numbers: {sum}");
Console.WriteLine("--------------------------------");

int[] newArr = CreateNewArrayWithNoNull(numbers);
PrintArray(newArr);
Console.WriteLine("--------------------------------");

PrintLength(numbers);
Console.WriteLine("--------------------------------");

Console.Write("Before: ");
PrintArrayNull(numbers);

ReplaceNullZeros(numbers);

Console.WriteLine("After: ");
PrintArray(numbers.Cast<int>().ToArray()); // меняем тип int? на int
Console.WriteLine("--------------------------------");
