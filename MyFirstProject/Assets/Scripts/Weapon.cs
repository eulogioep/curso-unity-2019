using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Weapon
{
    //Variables. No se inicializan por ser una estructura
    public string name;
    public int damage;

    //Constructor. Único, público, se llamará igual que la estructura y tomará todas las variables
    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    //Las estructuras pueden tener métodos
    public void PrintWeaponStats()
    {
        Debug.LogFormat("Arma: {0} - {1} daño", this.name, this.damage);
    }
}
