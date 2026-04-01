using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
   public interface ISinhVien
    {
        IReadOnlyList<SinhVien> GetAll();
            void AddStudent(SinhVien sinhVien);
            bool RemoveStudent(string id);
    }
}
