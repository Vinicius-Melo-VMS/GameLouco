using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balalinha : MonoBehaviour
{

    public GameObject bolas;
    public Rigidbody2D rb2;
    



    float VelocidadeDoTiro = -100; // a ser modificado

    float Multiplacadores = 2;
    float atlas;

    private void Awake()
    {

        rb2 = GetComponent<Rigidbody2D>();


    }
    void Update()
    {
        //  rb2.AddForce(new Vector2(VelocidadeDoTiro,0));
        altodestruicao();
    }
    void altodestruicao()
    {
        
        Destroy(bolas, 5);
    }

}
  
