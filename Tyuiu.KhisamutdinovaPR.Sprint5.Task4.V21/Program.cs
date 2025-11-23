using Tyuiu.KhisamutdinovaPR.Sprint5.Task4.V21.Lib;

Console.Title = "Спринт #5 | Выполнил: Хисамутдинова ПР | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #5                                                            *");
Console.WriteLine("* Тема: Работа с бинарными файлами                                     *");
Console.WriteLine("* Задание #4                                                           *");
Console.WriteLine("* Вариант #21                                                          *");
Console.WriteLine("* Выполнила Хисамутдинова ПР | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Вычислить значение по формуле и вывести на консоль.                  *");
Console.WriteLine("************************************************************************");

var service = new DataService();

try
{
    // Ввод пути к файлу
    Console.WriteLine("Введите путь к файлу:");
    string filePath = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(filePath))
    {
        Console.WriteLine("Путь к файлу не может быть пустым.");
        return;
    }

    // Убираем кавычки, если они случайно введены
    filePath = filePath.Trim('"');

    // Загрузка данных и вычисление минимального значения
    double result = service.LoadFromDataFile(filePath);
    Console.WriteLine($"Минимальное значение: {result}");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
catch (FormatException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}