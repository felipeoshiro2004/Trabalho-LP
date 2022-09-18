using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour

{

    public float velocidade;
	Rigidbody2D rb;

	public LayerMask enemy;

	float direcao;

	public float velocidadepulo;
    
    void Start()
    {

		velocidadepulo = 0.0f;
	
	rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
	if(Input.GetKey(KeyCode.LeftArrow)){ 

		direcao = 1;
		transform.Translate(new Vector2(1 * velocidade,0));
		transform.localScale = new Vector2(-4.669762f,4.702249f);
	}
	if(Input.GetKey(KeyCode.RightArrow)){

		direcao = -1;
		transform.Translate(new Vector2(-1 * velocidade,0));
		transform.localScale = new Vector2(4.669762f,4.702249f);
	}
	if(Input.GetKey(KeyCode.UpArrow)){
		velocidadepulo = 2f;
		//RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(0,-1));
        //if(hit.collider != null){
		rb.velocity = Vector2.up * velocidadepulo;
	}      

	if(Input.GetKey(KeyCode.L)){
		RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(-direcao,0), Mathf.Infinity,enemy);
        if(hit.collider != null){ 

			Debug.Log("Atirou");

			Destroy (hit.collider.gameObject);

		}
		
	}


    }

	}

//}


