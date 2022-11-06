using EF.Repository.Repository;
using MVCApp.Data;
using MVCApp.Interfaces.Repository;
using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Repository
{
    public class StudentRepository:CommonRepository<Student>,IStudenRepository
    {
        public StudentRepository():base(new ApplicationDbContext())
        {

        }
    }
}