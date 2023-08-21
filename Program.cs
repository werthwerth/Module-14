namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            List<Contact> sortedByNames = phoneBook.OrderBy(o => o.Name).ToList();
            List<Contact> sortedByLastNames = phoneBook.OrderBy(o => o.LastName).ToList();

            Console.WriteLine("Sorted By Names:");
            foreach (Contact s in sortedByNames)
            {
                Console.WriteLine("Name: {0}, Lastname: {1}, Phone: {2}, Email: {3}", s.Name, s.LastName, s.PhoneNumber, s.Email);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Sorted By LastNames:");
            foreach (Contact s in sortedByLastNames)
            {
                Console.WriteLine("Name: {0}, Lastname: {1}, Phone: {2}, Email: {3}", s.Name, s.LastName, s.PhoneNumber, s.Email);
            }
        }
    }
    public class Contact // модель класса
    {
        public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public String LastName { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
}