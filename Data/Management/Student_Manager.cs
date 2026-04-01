using Data.Entity;
using Data.Interface;
using OfficeOpenXml;
using System.Configuration;

namespace Data.Helper
{
    public class Student_Manager : ISinhVien
    {
       private readonly List<SinhVien> _students = new();
        public IReadOnlyList<SinhVien> GetAll()
        {
            return _students;
        }
        public void AddStudent(SinhVien student)
        {
           
            _students.Add(student);
        }
        public bool RemoveStudent(string id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            _students.Remove(student);
            return true;
        }
    }
}
