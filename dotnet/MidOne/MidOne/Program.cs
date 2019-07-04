using MidOne.Context;
using MidOne.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidOne
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ladob\Desktop\testt.txt";

            path = @path;

            var records = new List<Grade>();

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string headerLine = sr.ReadLine();
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Trim();

                        var recs = line.Split(',');

                        var x = new Grade()
                        {
                            StudentId = int.Parse(recs[0]),
                            SubjectId = int.Parse(recs[1]),
                            Points = int.Parse(recs[2])
                        };

                        using (var context = new GradeContext())
                        {
                            context.Entry(x).State = EntityState.Added;

                            context.SaveChanges();
                        }
                    }
                }

            }
        }
    }

    public class TextRecord
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Score { get; set; }
    }
}
