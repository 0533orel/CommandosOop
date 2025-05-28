using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Interfaces
{
    public interface IBreakable
    {
        public void GetStatus();

        public void GetBeatsLeft();

        public void GetBeatenBlows();
    }
}
