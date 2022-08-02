using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialisationApp
{
    public interface ISerialize
    {

        abstract void SerializeToFile<T>(string filePath, T item);
        abstract T DeserialiseFromFile<T>(string filePath);

    }
}
