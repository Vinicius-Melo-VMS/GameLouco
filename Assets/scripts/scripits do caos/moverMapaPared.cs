using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class moverMapaPared : MonoBehaviour
{

    //  public static float velocidaddeDaParede = 2;
    public float velocidaddeDaParede = 10;
    public GameObject paress;
    // Start is called before the first frame update
    public Rigidbody2D rbd;
    public static float destruirParede = 10;


    private void Awake()
    {
        rbd = GetComponent<Rigidbody2D>();

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
        

           
        Cacatua();
      
    }
    public void Cacatua()
    {
        rbd.velocity = new Vector2(-velocidaddeDaParede, 0);
        // (new Vector3(-velocidaddeDaParede, 0, 0) * 2 *Time.deltaTime);



        //  Destroy(paress, destruirParede);

    }


}


