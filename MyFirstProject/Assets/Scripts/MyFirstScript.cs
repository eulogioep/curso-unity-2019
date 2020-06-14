using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        Character hero = new Character();//Creo una instancia de la clase Character. Constructor por Defecto

        Character heroine = new Character("Lara Croft");//Constructor personalizado

        Character archer = new Character("Ojo de Alcón", 3);//Uso del tercer constructor


        //Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);
        //Debug.LogFormat("Heroina: {0} - {1} EXP", heroine.name, heroine.exp);
        //Debug.LogFormat("Hero: {0} - {1} EXP", archer.name, archer.exp);

        hero.PrintCharacterStats();
        heroine.PrintCharacterStats();
        archer.PrintCharacterStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
