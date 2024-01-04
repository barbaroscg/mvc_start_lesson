using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcbasics.Models
{
    public class Repository
    {
        public static List<Course> Courses { get; set; } = new List<Course>()
        {
             new Course()
                {
                        Id = 1,
                        Title = "AspNet Core",
                        Description = "Güzel, keyifli bir kurs",
                        Image = "1.jpg",
                        Tags = new string[] {"aspnet", "web geliştirme"},
                        isActive = true,
                        isHome = true
                },
                new Course()
                {
                        Id = 2,
                        Title = "ReactJs",
                        Description = "Seri, hızlı bir kurs",
                        Image = "2.jpg",
                        Tags = new string[] {"react js", "web geliştirme"},
                        isActive = false,
                        isHome = true
                },
                new Course()
                {
                        Id = 3,
                        Title = "Redux Toolkit",
                        Description = "Güzel, keyifli bir kurs",
                        Image = "3.jpg",
                         isActive = true,
                        isHome = true                
                },
                new Course()
                {
                        Id = 4,
                        Title = "Falan Toolkit",
                        Description = "Hoş, keyifli bir kurs",
                        Image = "2.jpg",
                        isActive = true,
                        isHome = true
                },
        };

        public static Course GetCourseById(int id){
            return Courses.FirstOrDefault(u => u.Id == id);
        }
    }
}