using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableSportApp
{
    internal class ManualSportSequence : IEnumerable<Sport>
    {
        public IEnumerator<Sport> GetEnumerator()
        {
            return new ManualSportEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
