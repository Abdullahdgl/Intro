// See https://aka.ms/new-console-template for more information
using Kodlama.ioProject.Business.Concrete;
using Kodlama.ioProject.DataAccess.Concrete.InMemory;
using Kodlama.ioProject.Entites.Concrete;

Console.WriteLine("Hello, World!");

InMemoryCourseDal courseDal = new InMemoryCourseDal();
courseDal.GetAll();
foreach (var course in courseDal.GetAll())
{
    Console.WriteLine(course.CourseName); 
}

