using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Classroom
    {
        public List<Person> PersonList = new List<Person>();
        public List<int> YearList = new List<int>();
        public List<double> GradeList = new List<double>();
        public List<string> NameList = new List<string>();

        public void addPerson(Person persons)
        {
            PersonList.Add(persons);
            YearList.Add(persons.Year);

        }
        public string ShowPerson()
        {
            string results = "";
            foreach (var person in PersonList)
            {
                results += person.Name + "\n";
            }
            return results;
        }
        public int ShowAllAge()
        {

            return YearList.Sum();
        }
        public void SetGrade()
        {
            foreach (var student in PersonList)
            {
                GradeList.Add(student.Grade);
                NameList.Add(student.Name);
            }
        }
        public double ShowMaxGrade()
        {
            return GradeList.Max();
        }
        public double ShowMinGrade()
        {
            return GradeList.Min();
        }
        public string ShowMaxGradeName()
        {
            return NameList[GradeList.IndexOf(GradeList.Max())];

        }
        public string ShowMinGradeName()
        {
            return NameList[GradeList.IndexOf(GradeList.Min())];
        }
    }
}