using BookManagement.DB;
using BookManagement.Model;

namespace BookManagement.Functions
{
    static class Functions
    {
        private static bool isuserexist(string username, string password)
        {
            List<User> users = ProjectDB.users;
            foreach (User user in users)
            {
                if (user.username == username && user.password == password)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool isunique(string username, string email)
        {
            List<User> users = ProjectDB.users;
            foreach (User user in users)
            {
                if (user.username == username || user.email == email)
                {
                    return false;
                }
            }
            return true;
        }


        public static int login()
        {
            Console.WriteLine("========Log in==========");

            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            List<User> users = ProjectDB.users;
            foreach (User user in users)
            {
                if (user.username == username && user.password == password)
                {
                    return user.id;
                }
            }
            return -1;
        }

        public static int signup()
        {
            Console.WriteLine("========Sign up==========");

            Console.Write("First Name: ");
            string first_name = Console.ReadLine();

            Console.Write("Last Name: ");
            string last_name = Console.ReadLine();

            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();


            if (isunique(first_name, last_name))
            {
                User newuser = new User(first_name, last_name, age, email, username, password);
                ProjectDB.users.Add(newuser);
                return newuser.id;
            }
            return -1;
        }

        public static void seebooks() {
            List<Book> books = ProjectDB.books;
            Console.WriteLine("============== Books Section=====================");
            foreach (Book book in books) {
                Console.WriteLine($"Id: {book.id}");
                Console.WriteLine($"Book Name: {book.name}");
                Console.WriteLine($"Description: {book.description}");
                Console.WriteLine($"Author: {book.author}");
                Console.WriteLine($"Year: {book.year}");
                Console.WriteLine($"Pages: {book.pages}");

                Console.WriteLine("=============================================");
            }
        }

        public static void addbook()
        {
            Console.WriteLine("=======Add Book=========");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Pages: ");
            int pages = Convert.ToInt32(Console.ReadLine());

            Book newbook = new Book(name, description, author, year, pages);
            ProjectDB.books.Add(newbook);

            Console.WriteLine("Book is added");
        }
    }
}