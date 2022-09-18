using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tempo : MonoBehaviour


{

    float tempo;
    public Text texto;
    // Start is called before the first frame update
    void Start()
    {
        tempo = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;
        texto.text = FormatTime(tempo);

    }

    string FormatTime(float tempo){
        int minutes = (int)tempo/60;
        int seconds = (int)tempo%60;
        return string.Format("{0:00}:{1:00}",minutes, seconds);
    }
}
