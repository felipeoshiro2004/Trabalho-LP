using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botão : MonoBehaviour


{

    // Start is called before the first frame update

    public GameObject parede;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D colisao)
    {

        if (colisao.gameObject.tag=="Player"){

            parede.SetActive(false);

        }

        else{

            parede.SetActive(true);

        }

    }
}
