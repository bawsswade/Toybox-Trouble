using UnityEngine;
using System.Collections;

public class lowGrav : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        player_movement p = other.GetComponent<player_movement>();
        if (p == null)
        {
            player p2 = other.GetComponent<player>();
            p2.speed = 30f;
        }
        else
        {
            p.speed = 30f;
        }
    }
}
