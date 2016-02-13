using UnityEngine;
using System.Collections;

public class moveSlower : MonoBehaviour {

    void Start()
    {
        GameObject [] gList = GameObject.FindGameObjectsWithTag("character");
        foreach (GameObject g in gList)
        {
            player_movement p = g.GetComponent<player_movement>();
            p.speed = 3f;
            p.jumpStr = 5f;
            g.GetComponent<Rigidbody2D>().mass = 10f;
            g.GetComponent<Rigidbody2D>().gravityScale = .5f;
        }
    }
}
