using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AtivarPorfeb : MonoBehaviour
{


    public Text tess1;
    public Text tess2;
    public Text tess3;
    public Text tess4;
    public Text tess5;
    public Text tess6;
    public Text tess7;
    public Text tess8;
    public Text tess9;
    public Text tess10;
    public Text tess11;


    [Header("destrir")]

    [Header("parede")]
    public GameObject barras1;
    public GameObject barras2;
    public GameObject barras3;
    public GameObject barras4;
    public GameObject barras5;
    public GameObject barras6;
    public GameObject barras7;
    public GameObject barras8;
    public GameObject barras9;
    public GameObject barras10;
    public GameObject barras11;

    [Header("Contajen do tenpo ")]

    public float tenpo1 = 1f;
    public float tenpo2 = 2f;
    public float tenpo3 = 3f;
    public float tenpo4 = 3f;
    public float tenpo5 = 3f;
    public float tenpo6 = 3f;
    public float tenpo7 = 3f;
    public float tenpo8 = 3f;
    public float tenpo9 = 3f;
    public float tenpo10 = 3f;
    public float tenpo11 = 3f;
    [Header("tepo limite de ativação")]
    public int masTime1 = 5;
    public float masTime2 = 5;
    public float masTime3 = 5;
    public float masTime4 = 5;
    public float masTime5 = 5;
    public float masTime6 = 5;
    public float masTime7 = 5;
    public float masTime8 = 5;
    public float masTime9 = 5;
    public float masTime10 = 5;
    public float masTime11 = 5;
    moverMapaPared moverMapaPared;

    [Header("moverMapaPared")]
    public float deste1;
    public float muverParede;

    public int zera = 0;
   
    void Start()
    {
        moverMapaPared = GetComponent<moverMapaPared>();

    }




    // Update is called once per frame
    void Update()
    {

       
        tenpo1 += Time.deltaTime;
        tenpo2 += Time.deltaTime;
        tenpo3 += Time.deltaTime;
        tenpo4 += Time.deltaTime;
        tenpo5 += Time.deltaTime;
        tenpo6 += Time.deltaTime;
        tenpo7 += Time.deltaTime;
        tenpo8 += Time.deltaTime;
        tenpo9 += Time.deltaTime;
        tenpo10 += Time.deltaTime;
        tenpo11 += Time.deltaTime;

       
        Conometro();
        Dest();

        Par1();
    }

    void Par1()
    {

        if (tenpo1 >= masTime1)
         {
            Instantiate(barras1);
            tenpo1 = zera;

        }


    }

        
    void Dest()
    {
        moverMapaPared.destruirParede = deste1;
        moverMapaPared.velocidaddeDaParede = muverParede;
    }

    void Conometro()
    {
        tess1.text = ("parede 1 : "  + tenpo1);
        tess2.text = ("parede 2 : "  + tenpo2);
        tess3.text = ("parede 3 : "  + tenpo3);
        tess4.text = ("parede 4 : "  + tenpo4);
        tess5.text = ("parede 5 : "  + tenpo5);
        tess6.text = ("parede 6 : "  + tenpo6);
        tess7.text = ("parede 7 : "  + tenpo7);
        tess8.text = ("parede 8 : "  + tenpo8);
        tess9.text = ("parede 9 : "  + tenpo9);
        tess10.text = ("parede 10 : "  + tenpo10);
        tess11.text = ("parede 11 : "  + tenpo11);
   }
}

        
 


       
            
            
            
        
   



