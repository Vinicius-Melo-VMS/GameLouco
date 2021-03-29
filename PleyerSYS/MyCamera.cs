using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MyCamera : MonoBehaviour
{

    public Transform Ply;
    // Update is called once per frame
    Vector3 NvPsCm;
   [SerializeReference]  float deley;
    
    void Update()
    {
        NvPsCm = new Vector3(Ply.transform.position.x, Ply.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, NvPsCm, deley * Time.deltaTime);
    }

   
}
 