using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste1 : MonoBehaviour
{

    float speed = 1;

    SpriteRenderer andChao;
    // Start is called before the first frame update
    private void Awake()
    {
        andChao = GetComponent<SpriteRenderer>();
    }

    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed -= Time.deltaTime * 10;

        andChao.size = new Vector2(99 -speed, 4);
    }
}
