using DoctorAppointmentDemo.Data.Interfaces;
using DoctorAppointmentDemo.Domain.Enums;
using DoctorAppointmentDemo.Service.Services;
using MyDoctorAppointment.Domain.Entities;
using MyDoctorAppointment.Domain.Enums;
using MyDoctorAppointment.Service.Interfaces;
using MyDoctorAppointment.Service.Services;
using System.Text.Json;
using System.Xml.Serialization;

namespace MyDoctorAppointment
{
    public class DoctorAppointment
    {
        private readonly IDoctorService _doctorService;

        public DoctorAppointment()
        {
            _doctorService = new DoctorService();
        }

        public void Menu()
        {
            bool working = true;
            while (working)
            {
                Console.WriteLine("Select an action:");
                Console.WriteLine("1 - Current list of doctors\r\n2 - Add new doctor\r\n3 - Delete existing doctor\r\n4 - Update doctor information\r\n5 - Exit the program");
                int selectAction = int.Parse(Console.ReadLine());

                MenuTypes menu = (MenuTypes)selectAction;

                switch (menu)
                {
                    case MenuTypes.GetAll:

                        Console.WriteLine("Current doctors list: ");
                        var docs = _doctorService.GetAll();
                        int i = 1;
                        foreach (var doc in docs)
                        {
                            Console.WriteLine($"{i}. Doctor: {doc.Name} {doc.Surname}, {doc.Experience} years of experience, {doc.DoctorType}.");
                            i++;
                        }
                        break;

                    case MenuTypes.Create:

                        Console.WriteLine("Enter your first name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter your last name:");
                        string surName = Console.ReadLine();

                        Console.WriteLine("Enter your work experience:");
                        byte workExperience = byte.Parse(Console.ReadLine());

                        Console.WriteLine("Select your specialty:");
                        Console.WriteLine("1 - Dentist\r\n2 - Dermatologist\r\n3 - FamilyDoctor\r\n4 - Paramedic");
                        int specialty = int.Parse(Console.ReadLine());
                        DoctorTypes doctorTypes = (DoctorTypes)specialty;

                        var newDoctor = new Doctor
                        {
                            Name = name,
                            Surname = surName,
                            Experience = workExperience,
                            DoctorType = doctorTypes
                        };

                        _doctorService.Create(newDoctor);
                        break;

                    case MenuTypes.Delete:

                        Console.WriteLine("Select the number of the doctor you want to delete:");
                        int deleteNum = int.Parse(Console.ReadLine());

                        _doctorService.Delete(deleteNum);
                        break;

                    case MenuTypes.Update:
                        Console.WriteLine("Select the number of the doctor whose details you want to change:");
                        int changeNum = int.Parse(Console.ReadLine());

                        Doctor changeDoctor = _doctorService.Get(changeNum);

                        Console.WriteLine($"Current first name: {changeDoctor.Name}, enter a new name if you want to change it.");
                        string changeName = Console.ReadLine();
                        changeDoctor.Name = changeName;

                        Console.WriteLine($"Current last name: {changeDoctor.Surname}, enter a new last name if you want to change it.");
                        string changeSurname = Console.ReadLine();
                        changeDoctor.Surname = changeSurname;

                        Console.WriteLine($"Current experience: {changeDoctor.Experience}, enter new experience if you want to change.");
                        byte changeExperience = byte.Parse(Console.ReadLine());
                        changeDoctor.Experience = changeExperience;

                        Console.WriteLine($"Current specialty: {changeDoctor.DoctorType}, enter a new specialty if you want to change it.");
                        Console.WriteLine("1 - Dentist\r\n2 - Dermatologist\r\n3 - FamilyDoctor\r\n4 - Paramedic");
                        int changeSpecialty = int.Parse(Console.ReadLine());
                        DoctorTypes changeDoctorTypes = (DoctorTypes)changeSpecialty;
                        changeDoctor.DoctorType = changeDoctorTypes;

                        _doctorService.Update(changeNum, changeDoctor);
                        Console.WriteLine("Doctor information updated successfully.");
                        break;

                    case MenuTypes.Exit:
                        Console.WriteLine("Exiting the program...");
                        working = false;
                        break;
                }
                    
            }
        }

        public void MenuXmlJsonSelect()
        {
            Console.WriteLine("Select data format:\n1 - XML\n2 - JSON");
            int selectFormat = int.Parse(Console.ReadLine());

            ISerializationService serializationService;
            string filePath;
            MenuXmlJson menu = (MenuXmlJson)selectFormat;
            switch (menu)
            {
                case MenuXmlJson.XML:
                    serializationService = new XmlDataSerializeService();
                    filePath = "doctors.xml";
                    break;
                case MenuXmlJson.JSON:
                    serializationService = new JsonDataSerializeService();
                    filePath = "doctors.json";
                    break;
            }
        }

    }

    public static class Program
    {
        public static void Main()
        {
            var doctorAppointment = new DoctorAppointment();

            doctorAppointment.MenuXmlJsonSelect();

            //doctorAppointment.Menu();
        }
    }
}