using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        //Clase
        Character hero = new Character();//Creo una instancia de la clase Character. Constructor por Defecto
        Character heroine = new Character("Lara Croft");//Constructor personalizado
        Character archer = new Character("Ojo de Alcón", 3);//Uso del tercer constructor

        //Estrucutura
        Weapon sword = new Weapon("Espada roma", 5);
        Weapon sword2 = sword;

        //Character es una clase con la variable que se crea apunta a un puntero de memoria.
        //hero2 y hero apuntan al mismo puntero. Si se modifica una, se cambia el otro.
        Character hero2 = hero;
        hero.PrintCharacterStats();
        hero2.PrintCharacterStats();

        hero.name = "Madonna";
        hero2.PrintCharacterStats();
        Debug.Log("*****************");

        //Prueba con estructura
        sword2.PrintWeaponStats();
        sword2.name = "Excalibur";
        sword2.damage = 255;

        sword.PrintWeaponStats();//Espada roma - 5 daño
        sword2.PrintWeaponStats();//Excalibur - 255 daño


        Debug.Log("*****************");
        hero.PrintCharacterStats();
        heroine.PrintCharacterStats();
        archer.PrintCharacterStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
