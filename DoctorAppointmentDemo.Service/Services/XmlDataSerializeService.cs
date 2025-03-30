using DoctorAppointmentDemo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DoctorAppointmentDemo.Service.Services
{
    public class XmlDataSerializeService : ISerializationService
    {
        public void Serialize<T>(string path, T data)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, data);
            }
        }

        public T Deserialize<T>(string path)
        {
            XmlSerializer xmlDeserializer = new XmlSerializer(typeof(T));

            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                return (T)xmlDeserializer.Deserialize(fs);
            }
        }
    }
}
