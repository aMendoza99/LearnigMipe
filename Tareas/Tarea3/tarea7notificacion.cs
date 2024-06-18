//public class Contact
//{
//    public string Name { get; set; }
//    public string Email { get; set; }
//    public string PhoneNumber { get; set; }

//    public Contact(string name, string email, string phoneNumber)
//    {
//        Name = name;
//        Email = email;
//        PhoneNumber = phoneNumber;
//    }
//    //linea que contendra Nombre/mail/#
//    public void DisplayContactInfo()
//    {
//        Console.WriteLine($"Name: {Name}, Email: {Email}, Phone: {PhoneNumber}");
//    }
//}

//public class Reminder : Contact
//{
//    public List<string> Reminders { get; set; } = new List<string>();

//    public Reminder(string name, string email, string phoneNumber)
//        : base(name, email, phoneNumber)
//    {
//    }

//    public void AddReminder(string reminder)
//    {
//        Reminders.Add(reminder);
//    }

//    public void AddReminder(params string[] reminders)
//    {
//        foreach (var reminder in reminders)
//        {
//            Reminders.Add(reminder);
//        }
//    }
//    //linea para mostrar recordatorios
//    public void DisplayReminders()
//    {
//        Console.WriteLine("Reminders:\n");
//        foreach (var reminder in Reminders)
//        {
//            Console.WriteLine(reminder);
//        }
//        Console.WriteLine();
//    }
//}
////linea para mostrar envio de noti
//public static class Notification
//{
//    public static void SendNotification(Reminder reminder)
//    {
//        Console.WriteLine($"\nSending notifications for {reminder.Name}:");
//        reminder.DisplayReminders();
//    }
//}


////clase que llama a Notificacion
//class ProgramNoti
//{
//    static void Main(string[] args)
//    {
//        Reminder reminder = new Reminder("Adrien Mendoza", "adrienjose@hotmail.com", "787-123-4567");
//        reminder.AddReminder("Cita con el Dentista", "Reunion con Reinaldo", "Almuerzo con el cliente");
//        reminder.DisplayContactInfo();
//        reminder.DisplayReminders();
//        Notification.SendNotification(reminder);
//    }
//}
