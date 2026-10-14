// using System.Drawing;

// public class Restangle
// {
//     public int Widht;
//     public int Height;
//     string? Color;

//     public Restangle(int widht, int height, string color)
//     {
//         Widht = widht;
//         Height = height;
//         Color = color;
//     }

//     public int GetArea()
//     {
//         return Widht * Height;
//     }

//     public int GetPerimeter()
//     {
//         return (Height + Widht) * 2;
//     }

// }


// public class User
// {
//     public string? FirstName;
//     public string? LastName;
//     public string? Username;
//     public string? Password;
//     public bool IsLoggedIn;
//     public DateTime CreatedAt;



//     public User(string firstName, string lastName, string username, string password)
//     {
//         FirstName = firstName;
//         LastName = lastName;
//         Username = username;
//         Password = password;
//         Password = password;


//     }
//     public void Login(string username, string password)
//     {
//         if (Username == username && Password == password)
//         {
//             IsLoggedIn = true;
//             System.Console.WriteLine(FirstName);
//         }
//         else
//         {
//             System.Console.WriteLine("Login or password is incorrect.");
//         }
//     }


//     public void Logout()
//     {
//         IsLoggedIn = false;
//         Console.WriteLine("You logged out.");

//     }

//     public string GetFullInfo()
//     {
//         return FirstName + " " + LastName + " " + Username + " " + IsLoggedIn;
//     }

//     public void ChangePassword(string oldPass, string newPassword)
//     {
//         if (Password == oldPass)
//         {
//             Password = newPassword;
//             System.Console.WriteLine("Password changed");
//         }
//         else
//         {
//             System.Console.WriteLine("Old password is incorrect");
//         }

//     }

//      public int GetAccountAgeInDays()
//     {
//           return (DateTime.Now - CreatedAt).Days;
//     }
// }



// public class Country
// {
//     string? Name;
//     string  Capital;
//     int Population;
//     string OfficialLanguage;

//     public Country(string name, string capital, int population, string officialLanguage)
//     {
//         Name = name;
//         Capital = capital;
//         Population = population;
//         OfficialLanguage = officialLanguage;
//     }
//     public void SetCapital(string capital)
//     {
//         Capital = capital;
//     }

//     public string GetCapital()
//     {
//         return Capital;
//     }
//     public void SetPopulation(int population)
//     {
//         Population = population;
//     }

//     public int GetPopulation()
//     {
//         return Population;
//     }
//     public void SetOfficialLanguage(string language)
//     {
//         OfficialLanguage = language;
//     }
    
//     public string GetOfficialLanguage()
//     {
//         return OfficialLanguage;
//     }
    
// }

