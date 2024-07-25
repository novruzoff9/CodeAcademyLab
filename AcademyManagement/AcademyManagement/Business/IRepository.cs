using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Business
{
    public interface IRepository
    {
        void GetById(int id);
        void GetAll();
        void DeleteById(int id);
        void AddStudent(string firstname, string lastname, string username, string password);
        void Update(int id, string firstname, string lastname, string username, string password);
    }
}
