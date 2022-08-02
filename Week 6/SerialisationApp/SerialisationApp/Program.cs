namespace SerialisationApp;

public enum Formats { BIN, JSON, XML };

public class Program
{
    // private static readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    private static readonly string _path = Path.Combine(Directory.GetCurrentDirectory(), @"../../../");
        private static ISerialize? _serializer;
    static void Main(string[] args)
    {
        Trainee trainee = new Trainee
        {
            FirstName = "Dylan",
            LastName = "Cole",
            SpartaNo = 100
        };

        _serializer = SerializerFactory.GetSerializer(Formats.BIN);
        _serializer.SerializeToFile($"{_path}/BinaryTrainee.bin", trainee);
        Trainee deserializedDylan = _serializer.DeserialiseFromFile<Trainee>($"{_path}/BinaryTrainee.bin");

        _serializer = SerializerFactory.GetSerializer(Formats.XML);
        _serializer.SerializeToFile($"{_path}/XMLTrainee.xml", trainee);
        Trainee deserializedDylanXML = _serializer.DeserialiseFromFile<Trainee>($"{_path}/XMLTrainee.xml");

        var eng120 = new Course();
        eng120.AddTrainee(trainee);
        eng120.AddTrainee(new Trainee { FirstName = "Tom", LastName = "Woolstencroft", SpartaNo = 101 });
        _serializer.SerializeToFile($"{_path}/XMLCourse.xml", eng120);
        Course deserializedEng120XML = _serializer.DeserialiseFromFile<Course>($"{_path}/XMLCourse.xml");

        _serializer = SerializerFactory.GetSerializer(Formats.JSON);
        _serializer.SerializeToFile($"{_path}/JSONCourse.json", eng120);
        Course deserializedEng120JSON = _serializer.DeserialiseFromFile<Course>($"{_path}/JSONCourse.json");
    }
}