using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerCanvasScript : MonoBehaviour {

    public float score;
    public Text scoreText,GameOverText;
    
    public void Start()
    {
        score = 0;
        GameOverText.text = "";
    }
    public void FixedUpdate()
    {
        scoreText.text = "" + score;
    }
}
