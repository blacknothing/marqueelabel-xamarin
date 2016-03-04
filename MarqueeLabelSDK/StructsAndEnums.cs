using System;
using ObjCRuntime;

namespace MarqueeLabelSDK
{
    [Native]
    public enum MarqueeType : ulong
    {
        LeftRight = 0,
        RightLeft,
        Continuous,
        ContinuousReverse
    }
}

