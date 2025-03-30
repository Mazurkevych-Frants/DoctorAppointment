using DoctorAppointmentDemo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DoctorAppointmentDemo.Service.Services
{
    public class JsonDataSerializeService : ISerializationService
    {
        public void Serialize<T>(string path, T data)
        {
            var jsonSerializer = JsonSerializer.Serialize(data);
            File.WriteAllText(path, jsonSerializer);
        }

        public T Deserialize<T>(string path)
        {
            string jsonDeserializer = File.ReadAllText(path);
           
            return JsonSerializer.Deserialize<T>(jsonDeserializer);
        }
    }
}
