﻿using DoctorAppointmentDemo.Data.Interfaces;
using DoctorAppointmentDemo.Data.Repositories;
using DoctorAppointmentDemo.Service.Interfaces;
using MyDoctorAppointment.Data.Interfaces;
using MyDoctorAppointment.Data.Repositories;
using MyDoctorAppointment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoctorAppointmentDemo.Data.Interfaces.IPatientRepository;

namespace DoctorAppointmentDemo.Service.Services
{
    internal class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;

        public PatientService() => _patientRepository = new PatientRepository();

        public Patient Create(Patient patient)
        {
            return _patientRepository.Create(patient);
        }

        public bool Delete(int id) => _patientRepository.Delete(id);

        public Patient? Get(int id)
        {
            return _patientRepository.GetById(id);
        }

        public IEnumerable<Patient> GetAll() => _patientRepository.GetAll();

        public Patient Update(int id, Patient patient)
        {
            return _patientRepository.Update(id, patient);
        }
    }
}
