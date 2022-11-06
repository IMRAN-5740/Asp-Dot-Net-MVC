using EF.Repository.Interface.Manager;
using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.Interfaces.Manager
{
    interface IStudentManager:ICommonManager<Student>
    {

        //Method Signature
        bool IsExistRegNo(string regNo);

        Student GetById(int id);
    }
}
