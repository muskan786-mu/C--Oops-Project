using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBL
{
    public struct CustomerDateOfBirth
    {
        public byte dobDay;
        public string dobMonth;
        public int dobYear;

        public CustomerDateOfBirth(byte dobDay,string bodMonth,int bodYear)
        {
            this.dobDay = dobDay;
            this.dobMonth = bodMonth;
            this.dobYear = bodYear;
        }
    }
}
