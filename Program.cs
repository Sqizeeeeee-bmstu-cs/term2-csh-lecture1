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

