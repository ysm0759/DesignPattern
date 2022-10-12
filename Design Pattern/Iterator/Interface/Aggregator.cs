using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Iterator
{
    public interface Aggregator
    {
        Iterator Iterator();
    }
}
