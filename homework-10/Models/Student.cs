using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_10.Models
{
    class Student:User 
    {
        private static int _Id { get; set; }
      
        public int _Point { get; set; }


        public int ID { get; set; }

        public Student(string fullname, int point):base(fullname,"","")
        {



            _Id++;

            ID = _Id;
            _Point = point;

        }




        public void StudenInfo()
        {
            Console.WriteLine($"Id: {_Id} \n" +
                $"Fullname: {_Fullname} \n" +
                $"Point: {_Point}");
        }

    }
}
