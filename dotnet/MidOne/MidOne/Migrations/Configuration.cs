namespace MidOne.Migrations
{
    using MidOne.Context;
    using MidOne.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal sealed class Configuration : DbMigrationsConfiguration<MidOne.Context.GradeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GradeContext context)
        {
            var students = new List<Student>();
            var subjects = new List<Subject>();

            students.Add(new Student("Student1"));
            students.Add(new Student("Student2"));
            students.Add(new Student("Student3"));
            students.Add(new Student("Student4"));
            students.Add(new Student("Student5"));

            subjects.Add(new Subject("Subject1"));
            subjects.Add(new Subject("Subject2"));
            subjects.Add(new Subject("Subject3"));
            subjects.Add(new Subject("Subject4"));
            subjects.Add(new Subject("Subject5"));

            foreach (Student student in students)
                context.Students.Add(student);

            foreach (Subject subject in subjects)
                context.Subjects.Add(subject);

            base.Seed(context);
        }
    }
}
