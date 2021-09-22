using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_grade
{
    class GradeStatistics
    {
        double _lowestmark;

        public double Lowestmark
        {
            get { return _lowestmark; }
            set { _lowestmark = value; }
        }
        double _highestmark;

        public double Highestmark
        {
            get { return _highestmark; }
            set { _highestmark = value; }
        }
        double _total;

        public double Total
        {
            get { return _total; }
            set { _total = value; }
        }
        double _average;

        public double Average
        {
            get { return _average; }
            set { _average = value; }
        }
        public GradeStatistics()
        { 
        
        }
        public GradeStatistics(double total, double highestmark, double average, double lowestmark)
        {
            this.Total = total;
            this.Highestmark = highestmark;
            this.Lowestmark = lowestmark;
            this.Average = average;
        }
        public override string ToString()
        {
            return "TOTAL=\t\t" + Total + "\nHIGHEST MARK=\t" + Highestmark + "\nLOWEST MARK=\t" + Lowestmark + "\nAVERAGE=\t" + Average;
        }
    }
}
