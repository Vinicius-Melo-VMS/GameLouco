
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


//[RequireComponent(typeof(RaycastHit2D))]
public class ParedeMuvLoop : MonoBehaviour
{
    /// <summary>
    /// Verificador loop de voids
    /// </summary>
    [Header("Max Tenpo inicio loop")]

    public float tenpoGeralDoGame;

    [Header("parede")]


    [Header("Nivel de vericação 1")]

    [Header("Zera Tempo do game: Universão " + "DEFINIDO COMO PADÃO (0)")]
    public GameObject[] parede;
    
    [Header("Max Tenpo inicio loop")]
    public int[] obstaculos;


    [Header(" tpd= Tenpo do loops  ")]
    [Header("tenpo do ledeys")]
    public float tpd1;
    public float tpd2;
    public float tpd3;
    public float tpd4;
    int zera = 0;
    /// <summary>
    /// varificador de loop dendos do void
    /// </summary>
    [Header("DVLIF= dento do void loop IF ")]
    [Header("Nivel de vericação 2")]
    public float DVLIF1;
    public float DVLIF2;
    public float DVLIF3;
    public float DVLIF4;



    private void Awake()
    {

    }
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // tenp daley
        tpd1 += 1 * Time.deltaTime;
        tpd2 += 1 * Time.deltaTime;
        tpd3 += 1 * Time.deltaTime;
        tpd4 += 1 * Time.deltaTime;

        tenpoGeralDoGame += 1 * Time.deltaTime;


        for (float i = tenpoGeralDoGame; i <= obstaculos[0]; i++)
        {
            Loop1();

        }

         for (float i = tenpoGeralDoGame; i >= obstaculos[1]; i++)
           {
               Loop2();

          }

         tpd1 += 0.5f * Time.deltaTime;
        tpd2 += 0.5f  * Time.deltaTime;
        tpd3 += 0.5f * Time.deltaTime;
        tpd4 += 0.5f * Time.deltaTime;
          
  


    }
   public void Loop1()
    {
       


        if (tpd1 >= DVLIF1)
        {
            Instantiate(parede[0]);
            tpd1 = zera;
        }
        else if (tpd2 >= DVLIF2)
        {
            Instantiate(parede[0]);
            tpd2 = zera;
            tpd1 = zera;

        }

        else if (tpd3 >= DVLIF3)
        {
            Instantiate(parede[0]);
            tpd1 = zera;
            tpd2 = zera;
            tpd3 = zera;

        }

        else if (tpd4 >= DVLIF4)
        {
            Instantiate(parede[0]);
            tpd1 = zera;
            tpd2 = zera;
            tpd3 = zera;
            tpd4 = zera;


        }
       

       }
    void Loop2()
    {
       

        if (tpd1 >= DVLIF1)
        {
            Instantiate(parede[0]);
            tpd1 = zera;
        }
        else if (tpd2 >= DVLIF2)
        {
            Instantiate(parede[1]);
            tpd2 = zera;
            tpd1 = zera;
        }

        else if (tpd3 >= DVLIF3)
        {
            Instantiate(parede[0]);
            
            tpd2 = zera;
            tpd1 = zera;
            tpd3 = zera;
            
        }

        else if (tpd4 >= DVLIF4)
        {
            Instantiate(parede[1]);

            tpd2 = zera;
            tpd1 = zera;
            tpd3 = zera;
            tpd4 = zera;
        }

    }
    void Loop3()
    {
       



        if (tpd1 >= DVLIF1)
        {
            Instantiate(parede[0]);
            tpd1 = zera;
        }
        else if (tpd2 >= DVLIF2)
        {
            Instantiate(parede[1]);
            tpd2 = zera;
            tpd1 = zera;
        }

        else if (tpd3 >= DVLIF3)
        {
            Instantiate(parede[2]);

            tpd2 = zera;
            tpd1 = zera;
            tpd3 = zera;

        }

        else if (tpd4 >= DVLIF4)
        {
            Instantiate(parede[3]);

            tpd2 = zera;
            tpd1 = zera;
            tpd3 = zera;
            tpd4 = zera;



        }
    }
    void Loop4()
    {
         
            if (tpd1 >= DVLIF1)
            {
                Instantiate(parede[0]);
                tpd1 = zera;
            }
            else if (tpd2 >= DVLIF2)
            {
                Instantiate(parede[2]);
                tpd2 = zera;
                tpd1 = zera;
            }

            else if (tpd3 >= DVLIF3)
            {
                Instantiate(parede[4]);

                tpd2 = zera;
                tpd1 = zera;
                tpd3 = zera;

            }

            else if (tpd4 >= DVLIF4)
            {
                Instantiate(parede[3]);

                tpd2 = zera;
                tpd1 = zera;
                tpd3 = zera;
                tpd4 = zera;
            }

        }
}
