using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fodase : MonoBehaviour
{
    float tepo = 1;
    public GameObject[] paredes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("parede1", tepo);
    }
    void parede1()
    {
        Instantiate(paredes[0]);       
    }
    void parede2()
    {

    }
    void parede3()
    {

    }
    void parede4()
    {

    }
    void parede5()
    {

    }
    void parede6()
    {


    }
    void parede7()
    {

    }
}
