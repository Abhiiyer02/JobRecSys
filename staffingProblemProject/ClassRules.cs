using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;

namespace staffingProblemProject
{
    public class ClassRules : IComparable<ClassRules>
    {
        string Combination, Remaining;
        double _confidence;

        public ClassRules(string Combination, string Remaining, double Confidence)
        {
            this.Combination = Combination;
            this.Remaining = Remaining;
            this._confidence = Confidence;
        }

        public string X
        {
            get
            {
                return Combination;
            }
        }
        public string Y
        {
            get
            {
                return Remaining;
            }
        }

        public double Confidence
        {
            get
            {
                return _confidence;
            }
        }



        #region IComparable<classRules> Members

        public int CompareTo(ClassRules other)
        {
            return X.CompareTo(other.X);
        }

        #endregion
    }
}