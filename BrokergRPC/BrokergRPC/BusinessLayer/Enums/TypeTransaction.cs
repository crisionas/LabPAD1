using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Enums
{
    public enum TypeTransaction : int
    {
        Payment=0,
        Credit=1,
        Authorization=2,
        Delayed_Capture=3,
        Void=4,
        Prenote=5
    }

}
