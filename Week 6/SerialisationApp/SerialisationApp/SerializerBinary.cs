using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerialisationApp;

internal class SerializerBinary : ISerialize
{
    public void SerializeToFile<T>(string filePath, T item)
    {
        //Stream or filestream
        FileStream fileStream = File.Create(filePath);
        //Create a Binary formatter object
        BinaryFormatter writer = new BinaryFormatter();
        writer.Serialize(fileStream, item);
        fileStream.Close();
    }

    public T DeserialiseFromFile<T>(string filePath)
    {
        // Create a stream object for reading
        Stream fileStream = File.OpenRead(filePath);
        BinaryFormatter reader = new BinaryFormatter();
        var deserializedItem = (T)reader.Deserialize(fileStream);
        fileStream.Close();
        return deserializedItem;
    }
}

