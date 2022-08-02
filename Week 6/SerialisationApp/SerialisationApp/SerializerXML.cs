using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerialisationApp
{
    internal class SerializerXML : ISerialize
    {
        public T DeserialiseFromFile<T>(string filePath)
        {
            FileStream fileStream = File.OpenRead(filePath);
            //Create XML Serialiser
            XmlSerializer reader = new XmlSerializer(typeof(T));
            var deserializedItem = reader.Deserialize(fileStream);
            fileStream.Close();
            return (T)deserializedItem;
        }

        public void SerializeToFile<T>(string filePath, T item)
        {
            FileStream fileStream = File.Create(filePath);
            //Create XML Serialiser
            XmlSerializer writer = new XmlSerializer(typeof(T));
            writer.Serialize(fileStream, item);
            fileStream.Close();
        }
    }
}
