using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// projeto de teste de materia

[RequireComponent(typeof(GameObject))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
[RequireComponent(typeof(SpriteRenderer))]


public class PleyerBase : MonoBehaviour
{


    [Header("sys pulo e chão")]
    public float jumpforce;
    public float radius;
    public float puloFraco;
    public float muvspeed;
    public Transform groundChek;
    public LayerMask whasIsGround;
    public bool iOnFloor = false;
    public bool inJumping = false;


    [Header("Corpo Base")]
    public Rigidbody2D RB2;
    public CapsuleCollider2D Corpor;
    public SpriteRenderer Sprite2D;





    [Header("teporario")]
    public SYSVDMA SYSVDMA;

    [Header("Configuração Padrão")]
    public bool autoConfigBase = true;

    void Start()
    {
        RB2 = GetComponent<Rigidbody2D>();
        // groundChek = GetComponent<GameObject>();
        Corpor = GetComponent<CapsuleCollider2D>();
        Sprite2D = GetComponent<SpriteRenderer>();
        groundChek = GameObject.Find("GroundChek").transform;

        conftribalbese();
    }
    // Update is called once per frame
    void Update()
    {
        vidaPleyer();
        movimento();


    }
    void FixedUpdate()
    {

        // pulo de um salto
        {

            iOnFloor = Physics2D.OverlapCircle(groundChek.position, radius, whasIsGround);
            if (Input.GetButtonDown("Jump") && iOnFloor == true)
                inJumping = true;
        }


    }
    void conftribalbese()
    {
        RB2.freezeRotation = autoConfigBase;
        RB2.useAutoMass = autoConfigBase;

    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundChek.position, radius);
    }

    public void movimento()
    {


        void Flip()
        {
            Sprite2D.flipX = !Sprite2D.flipX;
        }

        float muve = Input.GetAxis("Horizontal");
        RB2.velocity = new Vector2(muve * muvspeed, RB2.velocity.y);
        if ((muve > 0 && Sprite2D.flipX == true) || (muve < 0 && Sprite2D.flipX == false))
        {
            Flip();

        }
        if (inJumping)
        {
            RB2.AddForce(new Vector2(0f, jumpforce));
            inJumping = false;

        }
        if (RB2.velocity.y > 0f && !Input.GetButton("Jump"))
        {
            RB2.velocity += Vector2.up * -puloFraco;

        }

    }

    void vidaPleyer(float morteObsolut = 0)
    {
        // local da morte
        {
            if (SYSVDMA.VidaAtual <= morteObsolut)
            {
                SYSVDMA.Pleyer[0].SetActive(false);
            }
        }
    }


}

