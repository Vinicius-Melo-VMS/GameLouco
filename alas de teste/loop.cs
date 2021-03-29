using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour
{
    public int inimigos = 5;
    public  bool mybool = false;
    public bool mybool2 = false;
 
    
    void Start()
    {
        string[] veotres = new string[3];
        veotres[0] = "teste;";
        veotres[1] = "teste;";
        veotres[2] = "teste;";

        foreach (string myveotres in veotres)
        {
            print(myveotres);
        }
        for (int i = 0; i < inimigos; i++)
        {
            print("morto");
        }
        if (true)
        {

        }
        while (true)
        {

        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
