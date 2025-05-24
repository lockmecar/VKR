using System;
using System.IO;
using System.Text.Json;

namespace PaymentDefender
{
    public static class JsonFileManager
    {
        public static void WriteObject<T>(T obj, string filePath) where T : class // сериализация объекта класса в файл по заданному пути
        {
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            string jsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText(filePath, jsonString);
        }

        public static T ReadObject<T>(string filePath) where T : class        // десериализация объекта класса из файла по заданному пути
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден по указанному пути.", filePath);
            }

            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }

}
