using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace lab10
{
    class DataHandler<T>
    {
        public void SaveToBinaryFile(T data, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, data);
            }
        }

        public void SaveToJsonFile(T data, string filePath)
        {
            string jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonData);
        }

        public T LoadFromBinaryFile(string filePath)
        {
            if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (T)formatter.Deserialize(fs);
                }
            }
            else
            {
                Console.WriteLine("Файл данных пуст или не существует.");
                return default(T);
            }
        }
    }
}
