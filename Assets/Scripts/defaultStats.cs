using UnityEngine;
using System.Collections;

public class defaultStats : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.name + " in low grav");

        //GameObject[] gList = GameObject.FindGameObjectsWithTag("character");
        player_movement p = other.GetComponent<player_movement>();
        if (p == null)
        {
            player p2 = other.GetComponent<player>();
            p2.speed = 60f;
            p2.jumpStr = 30f;
        }
        else
        {
            p.speed = 60f;
            p.jumpStr = 30f;
        }
        other.GetComponent<Rigidbody2D>().mass = 2f;
        other.GetComponent<Rigidbody2D>().gravityScale = 4f;
        other.GetComponent<Rigidbody2D>().drag = 0f;
    }
}
