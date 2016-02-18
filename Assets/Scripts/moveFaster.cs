using UnityEngine;
using System.Collections;

public class moveFaster : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other)
    {
        player_movement p = other.GetComponent<player_movement>();
        if (p == null)
        {
            player p2 = other.GetComponent<player>();
            p2.speed = 90f;
            //p2.jumpStr = 70f;
        }
        else
        {
            p.speed = 90f;
            //p.jumpStr = 70f;
        }
        //other.GetComponent<Rigidbody2D>().drag = 10f;
    }
}
