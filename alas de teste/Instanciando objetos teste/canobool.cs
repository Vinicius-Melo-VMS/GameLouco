using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canobool : MonoBehaviour
{
    public GameObject bola;
    public float tenpoLoop = 2;
    public float temgeral;
    public Transform takt;


    private void Start()
    {
        InvokeRepeating("BOLINHA", temgeral, tenpoLoop);
    }

    // Update is called once per frame
   
    private void  BOLINHA()
    {

        Instantiate(bola, takt.position, takt.rotation);
        temgeral = 0;
    }
}
