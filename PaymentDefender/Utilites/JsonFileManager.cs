using System;
using System.IO;
using System.Text.Json;

namespace PaymentDefender
{
    public static class JsonFileManager
    {
        public static void WriteObject<T>(T obj) where T : class // сериализация объекта класса в файл по заданному пути
        {
            string filePath = "D:\\dev\\VKR\\PaymentDefender\\Sources\\" + obj.ToString() + ".json";
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            string jsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText(filePath, jsonString);
        }

        public static T ReadObject<T>(string emailLogin) where T : class  // десериализация объекта класса из файла по заданному пути
        {
            string filePath = "D:\\dev\\VKR\\PaymentDefender\\Sources\\" + emailLogin + ".json";
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден по указанному пути.", filePath);
            }

            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }

}
