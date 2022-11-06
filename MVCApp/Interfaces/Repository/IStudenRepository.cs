using EF.Repository.Interface.Repository;
using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.Interfaces.Repository
{
    internal interface IStudenRepository:ICommonRepository<Student>
    {
    }
}
