using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLookAt : MonoBehaviour
{
    public Transform alvo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(alvo);
    }
}
