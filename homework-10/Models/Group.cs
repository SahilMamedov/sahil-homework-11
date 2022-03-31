using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_10.Models
{
    class Group
    {
        public string _GroupNo { get; set; }
        public int _StudentLimit { get; set; }

        public string GroupNo
        {
            get
            {
                return _GroupNo;
            }
            set
            {
                if (value.CheckGroupNo() == true)
                {
                    _GroupNo = value;
                    Console.WriteLine("Qrup qeyd olundu");
                }
                else
                {
                    Console.WriteLine("Group Nomreni duz yazin");

                }
            }
        }





        public Group(string grupno, int studentlimit):base()
        {
            GroupNo = grupno;
            if (studentlimit >= 5 && studentlimit <= 18)
            {
                Students = new Student[studentlimit];
                _StudentLimit = studentlimit;
              
            }
            else
            {
                Console.WriteLine("Telebe sayi 5-den az 18-den cox ola bilmez");
            }


        }
        private Student[] Students;
        int a = 0;
        public void AddStudent(Student student)
        {

            if (_StudentLimit >= 5 || _StudentLimit <= 18)
            {
              
                    Students[a] = student;


                a++;

            }

        }

        public int GetStudent(int? id)
        {
            foreach (Student student in Students)
            {
                if (student.ID == id)
                {
                    Console.WriteLine($"ID: {student.ID} FullName: {student._Fullname} Point: {student._Point}");
                }
                
                else if (id == null)
                {
                    Console.WriteLine("bele idli student yoxdu");
                }

            }

            return -1;
        }

        public void GetAllStudents()
        {
            foreach (var item in Students)
            {
                Console.WriteLine($"ID: {item.ID} FullName: {item._Fullname} Point: {item._Point}");


            }
        }


    }
}
