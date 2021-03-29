
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class plyerCov19 : MonoBehaviour
{
    [Header("corpo")]
    public Rigidbody2D rb2;
    public Collider2D cld2d;
    [Header("Jump")]
    public float jumpNormal = 0;
    public float jumpInper = 50f;
    public float tmpjump;


    [Header("gravidade")]
    public float gravidade = 1;
    public Rigidbody2D covid19;

  
    [Header("vida")]
    public float VidaCovid19 = 100;
    public Slider slider;

    [Header("vericicador do grald")]
    public GameObject raycast;
    [Header("vericicador do barra")]
    int o;
    public float actc = 1;

    private void Awake()
    {
        rb2 = GetComponent<Rigidbody2D>();
        cld2d = GetComponent<Collider2D>();


    }
    void Start()
    {
        

    }

    
    void Update()
    {
        tmpjump -= 2 * Time.deltaTime;
        // rb2.velocity =  (new Vector2(0, -gravidade));



        // ala de voids

    }


    private void FixedUpdate()
    {
        for (int i = 0; i <= actc; i++)
        {
            movimento();
        }

        

    }


    void movimento()
    {
        //  rb2.gravityScale = gravidade;
         

        if (Input.GetButtonDown("Vertical"))
        {
            rb2.velocity = (new Vector2(0, jumpNormal));
            tmpjump = 1.2f;
        }
        if (tmpjump <= 0 && Input.GetButton("Vertical"))
        {
            rb2.velocity = (new Vector2(0, jumpInper));
        }
       
       
    }

}
