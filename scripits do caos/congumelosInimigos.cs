using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class congumelosInimigos : MonoBehaviour
{
    //public GameObject pleyer;
    public  GameObject GameOver;
    int ast = 1;
    bool plt = false;
    int congInimigos;
    

    // Start is called before the first frame update
    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       


        if (collision.tag == "congInimigos")
        {
            collision.gameObject.SetActive(false);
            ast = 0;

        } if (ast == 0 )
        {
            GameOver.SetActive(true);
         }
    }
}