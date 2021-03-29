using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desativar : MonoBehaviour
{
    public GameObject patede;
    bool desat = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DestroyGameObject()
    {
        Destroy(patede, 5);
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        DestroyGameObject();
    }

}
