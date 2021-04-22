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

        public void AddLetterGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                AddGrade(90);
                break;

                case 'B':
                AddGrade(80);
                break;

                case 'C':
                AddGrade(70);
                break;

                case 'D':
                AddGrade(60);
                break;


                default:
                AddGrade(0);
                break;

            }

        }
        public void AddGrade(double grade)
        {
            if(grade == 90.0)
            {

            }
            if(grade <=100 && grade >=0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalit value");
            }
        }
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.average = 0.0;
            result.high = double.MinValue;
            result.low = double.MaxValue;

            for(var index = 0; index < grades.Count; index += 1)
            {
              
                result.high = Math.Max(grades[index], result.high);
                result.low = Math.Min(grades[index], result.low);
                result.average += grades[index];

            }
            result.average /= grades.Count;

            switch(result.average)
            {
                case var d when d >= 90.0:
                result.Letter = 'A';
                break;

                case var d when d >= 80.0:
                result.Letter = 'B';
                break;

                case var d when d >= 70.0:
                result.Letter = 'C';
                break;

                case var d when d >= 60.0:
                result.Letter = 'D';
                break;

                default:
                result.Letter = 'F';
                break;
            }
           
        }
        private List<double> grades = new List<double>();

       
        public string Name;
    }
}