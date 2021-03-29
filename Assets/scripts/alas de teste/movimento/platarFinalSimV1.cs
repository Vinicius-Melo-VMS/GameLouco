using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platarFinalSimV1 : MonoBehaviour
{
    [SerializeReference]
    private Transform platarbeta;
    private float X1;
    [Header("velosidade e distacia da plataforma ")]
    [SerializeReference] private float X2_DistanciaMAX;
    [SerializeReference] private float X3_Tempo;
    [SerializeReference] private float X4M_Velocidade;
   



    // Start is called before the first frame update
    void Start()
    {
        platarbeta = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        muverPlatebeta();


    }
    void muverPlatebeta()
    {
        X1 += Time.deltaTime * X4M_Velocidade;

        platarbeta.position = new Vector3(X3_Tempo, platarbeta.position.y, platarbeta.position.z);
        X3_Tempo = Mathf.PingPong(X1, X2_DistanciaMAX);

    }
}


