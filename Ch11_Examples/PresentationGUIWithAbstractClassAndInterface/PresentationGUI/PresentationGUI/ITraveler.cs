/* ITraveler.cs Interface
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITravelerNamespace
{
    interface ITraveler
    {
        string GetDestination();
        string GetStartLocation();
        double DetermineMiles();
    }
}
