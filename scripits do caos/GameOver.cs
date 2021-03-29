using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
   // public Button [] m_button;
   // public GameObject[] MyUiButton;
  //  public bool[] atvObg;
    
      // public Scene scene;
      
    



    void Start()
    {
        

    }



    public void TenNovamente()
        {

        Application.LoadLevel(1);

        }
    public void TelaInicial1()
    {
        Application.LoadLevel(0);
    }
    public void sairDoGame() 
    {
        Application.Quit();
    }
}
