// Organization.cs
// Abstract class used a base class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationNamespace
{
    public abstract class Organization
    {
        private string orgName;
        private string primaryContact;
        private decimal fundedAmt;

        public Organization(string name, string contact)
        {
            orgName = name;
            primaryContact = contact;
        }

        public Organization()
        {
        }

        // Properties for each private data member follows
        public decimal FundedAmt
        {
            set
            {
                fundedAmt = value;
            }
            get
            {
                return fundedAmt;
            }
        }

        public string OrgName
        {
            set
            {
                orgName = value;
            }
            get
            {
                return orgName;
            }
        }

        private string PrimaryContact
        {
            set
            {
                primaryContact = value;
            }
            get
            {
                return primaryContact;
            }
        }
    }
}
