using System.Data;
using MyWinApp.Models;
using MyWinApp.Repository;

namespace MyWinApp.BLL
{
    public class StudentManager
    {
        StudentRepository _studentRepository = new StudentRepository();
        public DataTable LoadDistrict()
        {   
            return _studentRepository.LoadDistrict();
        }

        public DataTable ShowStudent()
        {
            return _studentRepository.ShowStudent();
        }

        public int Insert(Student student)
        {
            return  _studentRepository.Insert(student);
        }
    }
}
