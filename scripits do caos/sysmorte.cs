using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sysmorte : MonoBehaviour
{
    public GameObject pleyer;

    public Animator anim;
    bool ativadordamorte;
    public GameObject telaMorte;
    float tpmpbtm; // para abri a tela da morte
    int ast = 1;
    bool plt = false;


    void Start()
    {
        //pleyer = GetComponent<GameObject>();
        anim = gameObject.GetComponent<Animator>();
        ativadordamorte = false;
        //  telaMorte.SetActive(false);

        plt = true;
    }


    void Update()
    {

        tpmpbtm -= 1 * Time.deltaTime;



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        plt = false;
        ast = 0;
        pleyer.SetActive(plt);
        // Player.actc = 0;
        tpmpbtm = 2;



        // anim.SetBool("Jump", true);

        if (ast == 0)
        {
            telaMorte.SetActive(true);
        }




    }
    void Tedamorte()
    {

    }

}
