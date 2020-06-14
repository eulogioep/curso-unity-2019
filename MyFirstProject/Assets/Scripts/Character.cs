using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    //Variables o Atributos
    public string name;
    public int exp = 0;

    public Character()//Constructor
    {
        name = "Antonio Banderas";
    }

    //Otro Constructor. Llamo name a la variable que paso por parámetro por consistencia. Se pone el mismo nombre que a la variable
    //que hace referencia. En este caso name modificará la variable local name. Se puede poner otro nombre si se quiere.
    public Character(string name)
    {
        //this hace referencia a la variable de la Clase (Campo, propiedad). Es obligatorio ponerlo para que no se confunda
        //con la variable local del constructor.
        this.name = name;
    }

    public Character(string name, int exp)
    {
        this.name = name;
        this.exp = exp;
    }

    public void PrintCharacterStats()
    {
        Debug.LogFormat("Heroe: {0} - {1} EXP", this.name, this.exp);
    }

}