public interface IContactManager
{
    void AddContact(Contact contact);
    void UpdateContact(Contact contact);
    void DeleteContact(int contactId);
    List<Contact> ListContacts();
}

public interface INotificationService
{
    void SendNotification(string message);
}

public class Contact
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}
