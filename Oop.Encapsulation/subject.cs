using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Oop.Encapsulation
{
    internal class subject
    {
        private string name;
        public string Name
        {
            get { 
                return name;
            }
            set {
                if (string.IsNullOrEmpty(value) || Regex.IsMatch(value, @"\d") || value.Length < 4)
                {
                    throw new ArgumentException("Name must be atleast 4 characters long. Name cannot be a number, null or empty");
                }
                name = value;
            }
        }

        private string code;
        public string Code
        {
            get { return code; }
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Z]{3}-[1-9][0-9]{2}$"))
                {
                    throw new ArgumentException("Code must be in the format of three uppercase letters, a hyphen, and three numbers where the first number cannot be 0. \n Example: CJG-678");
                }
                code = value;
            }
        }

        private string teacher;
        public string Teacher
        {
            get { return teacher; }
            set {
                if(string.IsNullOrWhiteSpace(value) || Regex.IsMatch(value, @"\d"))
                {
                    throw new ArgumentException("Teacher name cannot be a number, null or empty");
                }
                teacher = value;
            }
        }


        private int ectsPoints;
        public int EctsPoints
        {
        get { return ectsPoints; }
        set {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentException("ECTS points must be a number between 1 and 10");
                }
                ectsPoints = value; 
            }
        }

        private DateOnly startDate;
        public DateOnly StartDate
        {
            get { return startDate; }
            set { 
                if (value.Year < 2021)
                {
                    throw new ArgumentException("Start date must be after 2021");
                }
                startDate = value;
            }
        }


        private DateOnly endDate;
        public DateOnly EndDate
        {
            get { return endDate; }
            set {
                if (value.Year < startDate.Year)
                {
                    throw new ArgumentException("The end date must be after the start date");
                }
                endDate = value; }
        }

        private DateOnly examDate;
        public DateOnly ExamDate
        {
            get { return examDate; }
            set {
                if (value.Year < startDate.Year || value.Year > endDate.Year)
                {
                    throw new ArgumentException("The exam date must be after the start date and before the end date");
                }
                examDate = value; }
        }
    }
}
