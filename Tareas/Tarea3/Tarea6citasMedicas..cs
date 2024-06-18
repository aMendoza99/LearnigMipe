//using System;

//namespace MedicalAppointmentApp
//{
//    public class MedicalAppointment : Person
//    {
//        public DateTime AppointmentDate { get; set; }
//        public string Doctor { get; set; }
//        public string Department { get; set; }

//        public MedicalAppointment(string name, int age, string gender, DateTime appointmentDate, string doctor, string department)
//            : base(name, age, gender)
//        {
//            AppointmentDate = appointmentDate;
//            Doctor = doctor;
//            Department = department;
//        }

//        public void RescheduleAppointment(DateTime newDate)
//        {
//            AppointmentDate = newDate;
//        }

//        public override string ToString()
//        {
//            return base.ToString() + $", Appointment Date: {AppointmentDate}, Doctor: {Doctor}, Department: {Department}";
//        }
//    }
//}
