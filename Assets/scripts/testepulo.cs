using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testepulo : MonoBehaviour
{
    public Transform groundchek;
    public LayerMask whasIsGround;
    bool iOnFloor = false;
    bool inJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        iOnFloor = Physics2D.Linecast(transform.position, groundchek.position, whasIsGround);
        if (Input.GetKeyDown("Jump")) ;
        inJumping = true;
    }
    private void FixedUpdate()
    {
        
           
    }
}
