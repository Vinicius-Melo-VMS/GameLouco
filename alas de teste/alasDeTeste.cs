using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alasDeTeste : MonoBehaviour
{

    float tempeAqual;
    float tempeAqualMax = 100;
    float tempeAqualMin = 50;


    void Start(){

      
      
    }

    
    void Update()
    {
        tempeAqual += Time.deltaTime * 5;
        tempera();

    }
    void tempera()
    {
        if (tempeAqual >= tempeAqualMax)
        {
            Debug.Log ("1");
        }
        else if (tempeAqual > tempeAqualMin)
        {
            Debug.Log("2");
        }
        else
        {
            Debug.Log("fria");
        }
    }

    int Multicas(int nuber2)
    {
        int resutlts;
        resutlts = nuber2 * 2;
        return resutlts;
    }
}
