using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RythmButton : Button
{
    public double duration;

    public bool isSound = true;

    public override void onClick()
    {
        engine.onRythmButtonClick(this);
    }
}