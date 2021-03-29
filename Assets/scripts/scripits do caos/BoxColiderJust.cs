using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoxColiderJust : MonoBehaviour
{

    private BoxCollider2D Bcd;
    private SpriteRenderer Str;

   public float iniorX;
    
   
    public float iniorY;

    // Start is called before the first frame update

    private void Awake()
    {
        Str = GetComponent<SpriteRenderer>();
        Bcd = GetComponent<BoxCollider2D>();
         
    }
    void start() {
        

    }

    // Update is called once per frame
    void Update()
    {


        Str.size = new Vector2(iniorX, iniorY);



        

            

    }
}
