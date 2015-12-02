using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WU15.StudentAdministration.Web.Models;
using WU15.StudentAdministration.Web.DataAccess;
using System.Data.Entity;

namespace WU15.StudentAdministration.Web.API
{
    public class StudentsController : ApiController
    {
        private DefaultDataContext db = new DefaultDataContext();

        public IEnumerable<Student> Get()
        {
            var students = db.Students.OrderBy(x => x.Active).ThenByDescending(xy => xy.FirstName);

            return students;
        }

        public Student Get(int id)
        {
            return db.Students.FirstOrDefault(x => x.Id == id);
        }

        public string Post(Student student)
        {
            if (student.Id > 0)
            {
                db.Entry(student).State = EntityState.Modified;
            }
            else
            {
                db.Students.Add(student);
            }

            db.SaveChanges();

            return string.Format("{0} {1}", student.FirstName, student.LastName);
        }
    }
}
//Lagt till användargränssnitt, titta genom Arnes PP sida: 71-74.
// Forsätt att kolla genom Arnes PP sida: 76 fram till 81.