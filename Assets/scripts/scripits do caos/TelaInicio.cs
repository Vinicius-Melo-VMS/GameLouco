using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelaInicio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void iniciar()
    {
        Application.LoadLevel(1);
    }
    public void sairDoGame()
    {
        Application.Quit();
    }

        
    
}
