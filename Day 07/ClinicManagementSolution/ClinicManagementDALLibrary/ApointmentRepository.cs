﻿using ClinicManagementModelLibrary;

namespace ClinicManagementDALLibrary
{
    public class AppointmentRepository : IRepository<int, Appointment>
    {
        private readonly Dictionary<int, Appointment> _appointments = new Dictionary<int, Appointment>();

        public Appointment Add(Appointment item)
        {
            int id = GenerateId();
            item.Id = id;
            _appointments.Add(id, item);
            return item;
        }

        public Appointment Delete(int key)
        {
            if (_appointments.ContainsKey(key))
            {
                var appointment = _appointments[key];
                _appointments.Remove(key);
                return appointment;
            }
            return null!;
        }

        public Appointment Get(int key) => _appointments.ContainsKey(key) ? _appointments[key] : null!;

        public List<Appointment> GetAll() => _appointments.Values.ToList();

        public Appointment Update(Appointment item)
        {
            if (_appointments.ContainsKey(item.Id))
            {
                _appointments[item.Id] = item;
                return item;
            }
            return null!;
        }

        private int GenerateId()
        {
            return _appointments.Count == 0 ? 1 : _appointments.Keys.Max() + 1;
        }
    }
}
