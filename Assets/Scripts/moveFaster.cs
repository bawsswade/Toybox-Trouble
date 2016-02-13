using UnityEngine;
using System.Collections;

public class moveFaster : MonoBehaviour {

    void Start()
    {
        GameObject [] gList = GameObject.FindGameObjectsWithTag("character");
        foreach (GameObject g in gList)
        {
            player_movement p = g.GetComponent<player_movement>();
            p.speed = 30f;
        }
    }
}
