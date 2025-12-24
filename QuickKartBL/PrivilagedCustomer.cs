using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBL
{
    public class PrivilagedCustomer
    {
        public int customerId;
        public string customerName;
        public string emailId;
        public long phoneNumber;
        public string address;
        public MembershipCardType membershipCardType;

        public PrivilagedCustomer(int customerId,string customerName,string emailId,long phoneNumber,string address,MembershipCardType membershipCardType
            )
        {
           this.customerId = customerId;
            this.customerName = customerName;
            this.emailId = emailId;
            this.membershipCardType = membershipCardType;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }
    }
}
