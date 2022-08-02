using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialisationApp;

public class SerializerFactory
{
    public static ISerialize GetSerializer(Formats format)
    {
        switch (format)
        {
            case Formats.BIN:
                return new SerializerBinary();
            case Formats.JSON:
                return new SerializerJSON();
            case Formats.XML:
                return new SerializerXML();
            default:
                throw new ArgumentException();
        }
    }
}
