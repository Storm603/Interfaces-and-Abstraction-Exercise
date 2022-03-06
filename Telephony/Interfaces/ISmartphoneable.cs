using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Interfaces
{
    public interface ISmartphoneable
    {
         void Calling(string number);
         void Browsing(string website);
    }
}
