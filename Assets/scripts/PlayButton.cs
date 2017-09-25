using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PlayButton : Button
{
    public override void onClick()
    {
        engine.PlayTrack();
    }
}

