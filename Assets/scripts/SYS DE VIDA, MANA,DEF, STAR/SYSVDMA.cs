using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SYSVDMA : MonoBehaviour
{
   
    
    //

    [Header("Pleyer|Inimigo")]
    public GameObject[] Pleyer;
  //  public GameObject[] Eneyme;
    public LayerMask eneyme;

    [Header("ATK|DEF|VIT|STR")]
    public float VidaMax = 100;
    public float DEFMAX = 20;
    public float ATKMAX = 30;
    public float MGMAX = 10;
    public float STRMAX = 10;
    [Header("Status atual")]
    public float VidaAtual ;
    public float DefAtual ;
    public float AtkAteual ;
    public float MgAtual ;
    public float StrAtual;


    [Header("BARRAS")]
    public Slider vida;
    public Slider mana;
    public Slider Stamina;
 
    // SYSmorte

    void Start()
    {
        

    }


    void Update()
    {
        
        //validaçãos
        {
            StarGame();
            VidaP();
            ManaP();
            StarP();
        }

    }
    
    void VidaP()
    {

    }
    void ManaP()
    {

    }
    void StarP()
    {

    }
    void StarGame()
    {
        {
            vida.maxValue = VidaMax;
            Stamina.maxValue = STRMAX;
            mana.maxValue = MGMAX;

            vida.value = VidaAtual;
            mana.value = MgAtual;
            Stamina.value = StrAtual;
        }
    }
}
