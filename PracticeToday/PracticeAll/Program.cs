using System;
using PracticeAll;
using PracticeAll.Helpers.Extensions;

//int number = 100;

//number.ShowNum();

//int number3 = 6;
//number3.ShowNum();

//int num1 = 50;

//num1.ShowNum(30);

//int num1 = 6;
//int num2 = 100;
//int res = num1.SumOfNums(num2);

//Console.WriteLine(res);

//string str = "Salam Rufet bey, ";

//var result = str.ShowText("Niye hazirlashmirsiniz ?");

//Console.WriteLine(result);

//string text = "Salam";

//var res = text.CheckDigitForStr();
//Console.WriteLine(res);

//if (res)
//{
//    Console.WriteLine("Have digit");
//}
//else
//{
//    Console.WriteLine("Haven't digit");
//}


//string email = "1234A1234";

//Console.WriteLine(email.CheckEmail("@"));
//Console.WriteLine(email.CheckEmail(@"\d"));
//Console.WriteLine(email.CheckEmail(@"[a-z]"));

//Person person = new("semedgm.ailcom");

//int num = 4;
//var res = num.FindFactorial();
//Console.WriteLine(res);

//Console.WriteLine("Add your email: ");
//Email:  string email = Console.ReadLine();

//if (!email.CheckEmailAndPassword("@"))
//{
//    Console.WriteLine("Email incorrect");
//    goto Email;
//}
//Console.WriteLine("Add your password: ");
//Password: string password = Console.ReadLine();

//if (!password.CheckEmailAndPassword(@"\W"))
//{
//    Console.WriteLine("Password format is wrong");
//    goto Password;
//}
//Console.WriteLine("Login success");


//double a = 10;

//Console.WriteLine(a.PowOfNum());

//string a = "5";
//Console.WriteLine(a.IsConvertStringToNumber());

//Car car = new Car();

//car.name = "asdf";

//Console.WriteLine(car.name);

//Car car;

//car.name = "asdfasdf";

//Console.WriteLine(car.name);

//Car car;

//car.name = "adfasdfasdf";

//Console.WriteLine(car.name);

//string name = null;

//if (name is null)
//{
//    Console.WriteLine("Notfound");
//}

//int ?age = null;


//Console.WriteLine(age);

//Nullable<int> a = null;

//static void CreateDate(string name, string surname, int? age)
//{
//    if(name == null || surname == null || age == null)
//    {
//        Console.WriteLine("Please fill all inputs");
//        return;
//    }
//    Console.WriteLine(name + "-" + surname + "-" + age);
//}

//CreateDate("Tunzale", "Memmedova", null);

static void Register(user user)
{
    if(!string.IsNullOrEmpty(user.Email) && !string.IsNullOrEmpty(user.FullName) && !string.IsNullOrEmpty(user.Password) )
    {
        Console.WriteLine("Register success");
    }
    else
    {
        Console.WriteLine("Register fail");
    }
}

Register(new user { Id = 1, FullName = "XXX", Email = "", Password = "12345" });