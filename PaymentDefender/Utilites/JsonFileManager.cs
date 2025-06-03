using System;
using System.IO;
using System.Text.Json;

namespace PaymentDefender
{
    public static class JsonFileManager
    {
        static JsonFileManager()
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string exeDirectory = Path.GetDirectoryName(exePath);
            DirectoryInfo directory = new DirectoryInfo(exeDirectory);
            while (directory != null && !directory.GetDirectories("Sources").Any())
            {
                directory = directory.Parent;
            }

            SourcePath = Path.Combine(directory.FullName, "Sources");
        }
        public static string SourcePath {  get; set; }
        public static void WriteObject<T>(T obj) where T : class // сериализация объекта класса в файл по заданному пути
        {
            string filePath = $"{SourcePath}\\{obj.ToString()}.json";
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            string jsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText(filePath, jsonString);
        }

        public static T ReadObject<T>(string emailLogin) where T : class  // десериализация объекта класса из файла по заданному пути
        {
            string filePath = $"{SourcePath}\\{emailLogin}.json";
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден по указанному пути.", filePath);
            }

            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }

}
