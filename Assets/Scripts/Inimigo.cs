using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class Inimigo : MonoBehaviour
{ 

    float tempoMovimento;
    float direcao;
    public float velocidade;
 
    void Start()
 {
        direcao = -1f;
        tempoMovimento = 2f;
 } 

    void Update()
 {
        if(tempoMovimento >= 0f){
        tempoMovimento -= Time.deltaTime;
}
        else{
            if(direcao == 1){
            direcao = -1;
            tempoMovimento = 4f;
}
        else{
            direcao = 1;
            tempoMovimento = 4f;
}
            }       
        transform.localScale = (new Vector2 (direcao * 5, 5));
        transform.Translate(new Vector2(direcao * velocidade,0)); 

 
 } 

}
