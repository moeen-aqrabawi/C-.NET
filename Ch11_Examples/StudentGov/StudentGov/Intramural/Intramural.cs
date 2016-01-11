using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
// Added to avoid fully qualifying references
using OrganizationNamespace;
namespace IntramuralNamespace
{
    public class Intramural : Organization
    {
        private string sportType;

        public Intramural(string name, string pContact,
                            string sport)
            : base(name, pContact)        // Call to Organization (base) class constructor
        {
            sportType = sport;
        }
        public Intramural()             // Default constructor
        {
            sportType = "unknown";
        }
        public string SportType         // Property for sportType
        {
            get
            {
                return sportType;
            }
            set
            {
                sportType = value;
            }
        }
    }
}
