using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magician : Character
{
    Weapon staff;

    public Magician() : base()
    {

    }

    //Crea un arma por defecto para todos los magos creados
    public Magician(string name) : base(name)
    {
        this.staff = new Weapon("Vara de Sauce", 25);
    }

    public Magician(string name, int exp) : base(name, exp)
    {

    }
}
