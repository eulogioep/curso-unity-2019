using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Paladin hereda de Character y puede hacer todo lo que Character haga
public class Paladin : Character
{
    public Weapon weapon;

    //Los constructores se heredan del padre (Character) pero pueden tener Constructores personalizados.
    //Para poder usar las variables del padre se usa base()
    public Paladin() : base()
    {

    }

    //Creo un nuevo constructor usando una variable local y también la variable del padre (name) sin tener
    //que repetir código.
    public Paladin(string name, Weapon weapon) : base(name)
    {
        this.weapon = weapon;
    }
    
}
