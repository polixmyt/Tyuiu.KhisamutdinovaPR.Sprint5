using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task7.V30.Lib
{
    public class DataService : ISprint5Task7V30
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);
            string result = Regex.Replace(text, @"\b\d\b", "9");
            string newpath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V30.txt");
            File.WriteAllText(newpath, result);
            return result;
        }
    }
}