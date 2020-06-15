using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Character
{
    Weapon arch;

    public Archer() : base()
    {
        
    }

    public Archer(string name, Weapon arch) : base()
    {
        this.arch = arch;
    }
}
