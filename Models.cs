using BookManagement.DB;

namespace BookManagement.Model
{
    class User
    {
        public int id { get; }
        public string first_name { get; }

        public string last_name { get; }
        public int age { get; }
        public string email { get; }
        public string username { get; }
        public string password { get; }

        public User(string first_name, string last_name, int age, string email, string username, string password)
        {
            id = (ProjectDB.users.Count == 0) ? 1 : ProjectDB.users[ProjectDB.users.Count - 1].id + 1;
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
            this.email = email;
            this.username = username;
            this.password = password;
        }
    }

    class Book
    {
        public int id { get; }
        public string name { get; }
        public string description { get; }

        public string author { get; }

        public int year {  get; }

        public int pages { get; }

        public Book(string name, string description, string author, int year, int pages)
        {
            id = (ProjectDB.books.Count == 0) ? 1 : ProjectDB.books[ProjectDB.books.Count - 1].id + 1; ;
            this.name = name;
            this.description = description;
            this.author = author;
            this.year = year;
            this.pages = pages;
        }
    }
}