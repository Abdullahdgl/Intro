// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concrete;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 1000000;

//Variable ----->camelCase
bool isAuthenticated = true;
Console.WriteLine(message1);
//Conditon - şartlar
if(isAuthenticated ==true)
{
    Console.WriteLine("Buton --- > Hoşgeldin Abdullah");
}
else
{
    Console.WriteLine("Sisteme giriş yap");
}
string[] Loans = { "Kredi 1","Kredi 2 ", "Kredi 3", "Kredi 4 ","Kredi 5","Kredi 6"};
for (int i = 0; i < Loans.Length; i++)
{
    Console.WriteLine(Loans[i]);
}

CourseManager courseManager = new(new EFCourseDal());
List<Course> courses2= courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name);
}



Console.WriteLine("Kod Bitmiştir.");

IndividualCustomer customer1 = new IndividualCustomer(); 
customer1.Id = 1;
customer1.NationalIdentity = "123456789";
customer1.FirstName = "ASLI";
customer1.LastName = "KARAYİĞİT";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "1256789";
customer2.FirstName = "ÖZGÜR";
customer2.LastName = "ATILGAN";
customer2.CustomerNumber = "2456";


CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "6855";
customer3.TaxNumber = "16529860";


CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "63335";
customer4.TaxNumber = "165292323";

BaseCustomer[] customers = {customer1, customer2, customer3, customer4};
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);

}

