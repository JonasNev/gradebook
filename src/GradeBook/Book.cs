using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.average = 0.0;
            result.high = double.MinValue;
            result.low = double.MaxValue;
            foreach (var grade in grades)
            {
                result.high = Math.Max(grade, result.high);
                result.low = Math.Min(grade, result.low);
                result.average += grade;

            }
            result.average /= grades.Count;
            return result;
           
        }
        private List<double> grades = new List<double>();

       
        public string Name;
    }
}