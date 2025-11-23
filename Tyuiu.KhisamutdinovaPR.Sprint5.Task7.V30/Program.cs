using Tyuiu.KhisamutdinovaPR.Sprint5.Task7.V30.Lib;
namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task7.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Хисамутдинова | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5");
            Console.WriteLine("* Тема: Чтение данных");
            Console.WriteLine("* Задание #7");
            Console.WriteLine("* Вариант #30");
            Console.WriteLine("* Выполнил: Хисамутдинова П.Р. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Найти количество слов длиной семь символов в заданной строке. ");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(Path.GetTempPath(), "DataSprint5", "InPutDataFileTask7V30.txt");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Данные находятся в: {path}");
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine("Ответ:" + res);
            Console.ReadKey();
        }
    }
}