Double x = 0;
string data = File.ReadAllText(@"C:\DataSprint\InPutDataFileTask4V0.txt");
x = double.Parse(data);
double result = 4 + Math.Pow(x, 0.5) - 3 * x - 2;
Console.WriteLine(result);