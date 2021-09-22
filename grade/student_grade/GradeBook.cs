using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_grade
{
    class GradeBook
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        string _regno;

        public string Regno
        {
            get { return _regno; }
            set { _regno = value; }
        }
        string _class;

        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }
        string _section;

        public string Section
        {
            get { return _section; }
            set { _section = value; }
        }

        List<grade> _grades = new List<grade>(3);

        public GradeBook(string name, string regno, string Class, string section)
        {
            this.Name = name;
            this.Regno = regno;
            this.Class = Class;
            this.Section = section;
        }

        public bool addgrade(string subject, float mark)
        {
            _grades.Add(new grade(subject, mark));
            return true;
        }

        public bool RemoveGrade(string subject)
        {
            grade g;
            foreach (grade g1 in _grades)
            {
                if (g1.Subject == subject)
                {
                    g = g1;
                    _grades.Remove(g);
                    return true;
                }
            }
            return false;
        }

        public bool UpdateGrade(string subject, float mark)
        {
            foreach (grade g in _grades)
            {
                if (g.Subject == subject)
                {
                    g.Mark = mark;
                    return true;
                }
            }
            return false;
        }
        public GradeStatistics calculate()
        {
            double total = 0.0;
            double high = 0.0;
            double avg = 0.0;
            double lower = int.MaxValue;
            int count=0;
            foreach(grade g in _grades)
            {
                count++;
                total += g.Mark;
                if (high < g.Mark)
                {
                    high = g.Mark;
                }
                if (lower > g.Mark)
                {
                    lower = g.Mark;
                }            
            }
            avg = total / count;
            return new GradeStatistics(total, high, avg, lower);
        }
        public override string ToString()
        {
            string y="";
            y+="name :"+Name+"\tRegNo :"+Regno+"\tClass :"+Class+"\tSection :"+Section+"\n\n"+"subject"+"\t\tMark"+"\tgrade"+"\tstatus"+"\n";
            foreach (grade g in _grades)
            {
                y += g.Subject + "\t\t" + g.Mark+"\t"+g.LetterGrade+"\t"+(g.PassStatus?"pass":"fail")+"\n"; 
            }
            return y;
        }
    }
}
