using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using InputMod;

public class PleyerBese1 : MonoBehaviour
{

    // pulo Defalt

    bool estarnocao = false;
    bool estarPulando = false;
    bool dualJupmp = false;
    public float jumpForce = 10;
    public float raioDoGizmo = 0.5f;

    public Transform graudCheck;
    public Rigidbody2D rb2d;
    public LayerMask Grald;
    //movimento Defalt
    public SpriteRenderer sprite;
    public float Speed = 5, rumSpeed = 10, muver;




    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        graudCheck = GameObject.Find("GroundChek").transform;
        //sprite = GetComponent<SpriteRenderer>();


    }
    private void Update()
    {

        //Movimento en terra (Normal/ Defalt)
        muver = Input.GetAxis("Horizontal") * Speed;


        // pulo
        {
            estarPulando = Input.GetButtonDown("Jump");
            estarnocao = Physics2D.OverlapCircle(graudCheck.position, raioDoGizmo, Grald);
            if (estarnocao)
            {
                dualJupmp = false;

                Debug.Log("Estarpilano" + estarPulando);

            }


        }
        //


    }
    private void FixedUpdate()
    {
        Movimetono();

    }
    public void Movimetono()
    {

        rb2d.velocity = new Vector2(muver, rb2d.velocity.y);
        if (muver >= 0 && sprite.flipX == false || muver <= 0 && sprite.flipX == true)
        {
            flip();
        }


        // movimeto em terra firme compativel com comtrole de xbom de PC


        flip();
        // sys pulo duplo
        if (estarPulando)
        {
            if (estarnocao)
            {
                DoJump();
                dualJupmp = true;
                //   Debug.Log("estar pulando1");
            }
            else if (!estarnocao && dualJupmp)
            {
                DoJump();
                dualJupmp = false;
                // Debug.Log("estar pulando2");
            }
        }
        void flip()
        {
            sprite.flipX = !sprite.flipX;
        }
        void DoJump()
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
            rb2d.AddForce(Vector2.up * jumpForce);
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(graudCheck.position, raioDoGizmo);
    }


}


