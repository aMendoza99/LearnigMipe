public class ContactManager : IContactManager
{
    private List<Contact> contacts = new List<Contact>();

    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
        Console.WriteLine($"Contacto añadido: {contact.Name}");
    }

    public void UpdateContact(Contact contact)
    {
        var existingContact = contacts.Find(c => c.Id == contact.Id);
        if (existingContact != null)
        {
            existingContact.Name = contact.Name;
            existingContact.Email = contact.Email;
            existingContact.Phone = contact.Phone;
            Console.WriteLine($"Contacto Actualizado: {contact.Name}");
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }

    public void DeleteContact(int contactId)
    {
        var contact = contacts.Find(c => c.Id == contactId);
        if (contact != null)
        {
            contacts.Remove(contact);
            Console.WriteLine($"Contacto removido: {contact.Name}");
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }

    public List<Contact> ListContacts()
    {
        return contacts;
    }
}

public class EmailNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Correo enviado: {message}");
    }
}

public class SmsNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Mensaje de Texto enviado: {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IContactManager contactManager = new ContactManager();

        var contact1 = new Contact { Id = 1, Name = "Adrien Mendoza", Email = "adrienjose@hotmail.com", Phone = "787-123-4567" };
        var contact2 = new Contact { Id = 2, Name = "Julian Fuentez\n", Email = "julianfuentez@hotmail.com", Phone = "787-987-4561" };

        contactManager.AddContact(contact1);
        contactManager.AddContact(contact2);

        contactManager.UpdateContact(new Contact { Id = 1, Name = "Adrien J Mendoza", Email = "adrienjose@gmail.com", Phone = "787-123-4555" });

        foreach (var contact in contactManager.ListContacts())
        {
            Console.WriteLine($"\nContacto: {contact.Name}Correo: {contact.Email}, Tel: {contact.Phone}");
        }

        contactManager.DeleteContact(2);

        INotificationService emailService = new EmailNotificationService();
        emailService.SendNotification("Este correo es una notificacion.");

        INotificationService smsService = new SmsNotificationService();
        smsService.SendNotification("Este mensaje es una notificacion.");
    }
}
