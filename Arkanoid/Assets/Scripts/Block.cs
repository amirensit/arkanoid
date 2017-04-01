using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour {

    public ManagerCanvasScript manager;


    void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        Destroy(gameObject);
        manager.score += 10;

    }


}
