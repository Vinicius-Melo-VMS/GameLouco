

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddPostos : MonoBehaviour
{

    
    public TextMeshProUGUI text;
    
    
    int potos;
    int addPotos = 0;
    int LogPotos;
    private void Awake()
    {
      
    }
    private void Start()

    {
        text.text = ("Pontos: " + addPotos);
    }

    void Update()
    {
      //  texto = GetComponent<Text>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "potos")
        {

            collision.gameObject.SetActive(false);

            text.text = ("Pontos: " + ++addPotos);
        }
        void OrgPontos()
        {
            text.text = ("Pontos: " + addPotos);

        }
    }

   

}


    





