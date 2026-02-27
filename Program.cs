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

