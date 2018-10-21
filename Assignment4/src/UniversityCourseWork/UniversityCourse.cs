using System;

namespace Assignment4
{
    public class UniversityCourse : Gathering
    {
        public UniversityCourse()
            : base(null)
        {
            CreditValue = 0;
        }

        public UniversityCourse(string name, int credits)
            : base(name)
        {
            CreditValue = credits;
        }

        private int _CreditValue;
        public int CreditValue
        {
            get
            {
                return _CreditValue;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Credits can not be negative.");
                }
                else if (value > 15)
                {
                    throw new ArgumentException("Too many credits for one course.");
                }
                else
                {
                    _CreditValue = value;
                }
            }
        }
    }
}
