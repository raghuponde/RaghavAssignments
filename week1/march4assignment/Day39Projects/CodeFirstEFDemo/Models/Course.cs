using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEFDemo.Models
{
     class Course
    {
        public int Id { set; get; }
        public string Title { set; get; }

        public string Description { set; get; }

        public CourseLevel level { set; get; }

        public List<Student> Students { set; get; }

        public Author Author { set; get; }

        public int AuthorId { set; get; }
    }

    public enum CourseLevel
    {
        Beginner =1,
        Average=2,
        Diffcult=3
    }
}
