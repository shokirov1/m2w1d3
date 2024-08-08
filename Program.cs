using m2w1d3.Task1;
using m2w1d3.Task2;
using m2w1d3.Task3;
using m2w1d3.Task4;

//Task-1
Console.WriteLine();
Console.WriteLine("----------------------Task-1----------------------");
Console.WriteLine();
Task1 task1 = new Task1();
Console.WriteLine(task1.DayOfWeek(Task1.Weekday.Monday));
Console.WriteLine(task1.DayOfWeek(Task1.Weekday.Sunday));

//Task-2
Console.WriteLine();
Console.WriteLine("----------------------Task-2----------------------");
Console.WriteLine();
Task2 task2 = new Task2();
task2.CarCheck(3);

//Task-3
Console.WriteLine();
Console.WriteLine("----------------------Task-3----------------------");
Console.WriteLine();
Task3 task3 = new Task3();
task3.CheckSeason(Task3.Season.Autumn);

//Task-4
Console.WriteLine();
Console.WriteLine("----------------------Task-4----------------------");
Console.WriteLine();
Task4 task4 = new Task4();
task4.CheckPlanet(1);
Console.WriteLine();
Console.WriteLine("--------------------------------------------------");
Console.ReadKey();

