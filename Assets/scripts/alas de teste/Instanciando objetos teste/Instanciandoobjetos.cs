using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciandoobjetos : MonoBehaviour
{
    public Rigidbody2D tirosBerya;
    public Transform tiroBLoc;
    public float tiroforce = 10000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("E"))
        {
            Rigidbody2D tiroiiia = Instantiate(tirosBerya, tiroBLoc.position, tiroBLoc.rotation);
            
        }
    }
}
