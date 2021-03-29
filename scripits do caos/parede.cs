using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parede : MonoBehaviour
{
    

    [Header("dano fracionado")]
    int danoDaParede = 10;
    LayerMask barra;
   
    [Header("dano do capiroto")]
    int mataLogo = 10000000;
    LayerMask grald;
    Slider slider;


    private void FixedUpdate()
    {
        DanoDaParede();
        DanoDochao();
    }

    void DanoDaParede()
    {
        slider.value -= 10;
    }

    void DanoDochao()
    {

    }

}
