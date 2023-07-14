using System.Collections.Generic;
using System.Collections.Immutable;
using Studentmanagement;

namespace Sudentmanagement
{
    class School
    {
        public List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        public Student GetStudent(Student studentId)
        {
          return students.Find(student => student.StudentId == student.StudentId );
        }
    }
}
