using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_grade
{
    class grade
    {
       
        string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        float _mark;

        public float Mark
        {
            get { return _mark; }
            set 
            {
                if (_mark >= 0)
                {
                    _mark = value;
                }
                else
                {
                    _mark = 0;
                }
            }
        }
        public grade(string subject, float mark)
        {
            this.Subject = subject;
            this.Mark = mark;
        }

        public bool PassStatus
        {
            get
            {
                return _mark >= 35;
            }
        }
        public string LetterGrade
        {
            get 
            {
                string lg = "";
                if (_mark >= 90 && _mark <= 100)
                {
                    lg = "O+";
                }
                else if (_mark >= 75 && _mark <= 89)
                {
                    lg = "A";
                }
                else if (_mark >= 60 && _mark <= 74)
                {
                    lg = "B";
                }
                else if (_mark >= 35 && _mark <= 59)
                {
                    lg = "c";
                }
                else
                {
                    lg = "D";
                }
                return lg;
            }
        }

    }
}
