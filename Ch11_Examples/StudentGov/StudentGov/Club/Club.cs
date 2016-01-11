// Club.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OrganizationNamespace;      // Added to avoid fully qualifying references
using IFundingNamespace;

namespace ClubNamespace
{
    public class Club : Organization, IFunding
    {
        private string meetingLocation;          // Private member data
        private string meetingDay;
        private string meetingTime;

        public Club(string name, string pContact,
                    string mLoc, string mDay,
                    string mTime)
            : base(name, pContact)             // Call to base constructor 
        {
            meetingLocation = mLoc;
            meetingDay = mDay;
            meetingTime = mTime;
        }

        // Required method - because of interface
        public void SetFundingAmt()
        {
            FundedAmt = 600M;
        }
    }
}
