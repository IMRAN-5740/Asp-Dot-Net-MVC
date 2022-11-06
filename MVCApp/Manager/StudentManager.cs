using EF.Repository.Interface.Repository;
using EF.Repository.Manager;
using MVCApp.Interfaces.Manager;
using MVCApp.Models;
using MVCApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Manager
{
    public class StudentManager : CommonManager<Student>, IStudentManager
    {
        public StudentManager() : base(new StudentRepository())
        {


        }

        //Implement
        public bool IsExistRegNo(string regNo)
        {
            var student = GetFirstOrDefault(c => c.RegNo.ToLower() == regNo.ToLower());
            if (student != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Student  GetById(int id)
        {
            var student = GetFirstOrDefault(c => c.Id == id);
            return student;
        }

        
    }
}