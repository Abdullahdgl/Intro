// See https://aka.ms/new-console-template for more information

using Kodlama.ioProject2.DataAccess.Concrete.EntityFrameWork;

EFCourseDal eFCourseDal = new EFCourseDal();
eFCourseDal.GetAll();
foreach (var item in eFCourseDal.GetAll())
{
    Console.WriteLine(item.CourseName + " - " + item.CategoryId + " " + item.Description );
}