using Tyuiu.KhisamutdinovaPR.Sprint5.Task4.V21.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task4.Tests
{
    [TestClass]
    public class DataServiceTest
    {
        private const string TestFilePath = @"C:\DataSprint5\TestInput.txt";

        [TestInitialize]
        public void Setup()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(TestFilePath));
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(TestFilePath))
            {
                File.Delete(TestFilePath);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void LoadFromDataFile_FileNotFound_ThrowsException()
        {
            // Arrange
            var dataService = new DataService();

            // Act
            dataService.LoadFromDataFile("NonExistentFile.txt");
        }
    }
}