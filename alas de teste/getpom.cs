using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getpom : MonoBehaviour
{

    private getpom2 ast;
    public Rigidbody rb;

    // Start is called before the first frame update
    private void Awake()
    {
        ast = GetComponent<getpom2>();
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            rb.useGravity = true;
            ast.est12i = 10;
        }
    }
}
