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
            set { code = value; }
        }

        private string teacher;
        public string Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }

        private int ectsPoints;
        public int EctsPoints
        {
        get { return ectsPoints; }
        set { ectsPoints = value; }
        }

        private int startDate;
        public int StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private DateTime endDate;
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        private DateTime examDate;
        public DateTime ExamDate
        {
            get { return examDate; }
            set { examDate = value; }
        }
    }
}
