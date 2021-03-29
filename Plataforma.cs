using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
//[RequireComponent(typeof(Rigidbody2D))]

public class Plataforma : MonoBehaviour
{
    Transform[] PonLok;

    private void Start()
    {
        PonLok[1] = GetComponent<Transform>();
        PonLok[2] = GetComponent<Transform>();
    }
    private void Update()
    {
        
    }

    public void OnDrawGizmos() 
    {

    }
}
