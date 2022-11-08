using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCoins : MonoBehaviour
{
    //-----------------------------------------//
    public float score;
    public Text texScore; //texto de los puntos obtenidos
    //-----------------------------------------//


    private void Update()
    {
        texScore.text = "Score: " + score.ToString();

    }
}
