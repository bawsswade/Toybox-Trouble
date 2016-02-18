using UnityEngine;
using System.Collections;

public class moveSlower : MonoBehaviour {
    void Start()
    {
        this.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, .5f);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.name + " moving slower");
        player_movement p = other.GetComponent<player_movement>();
        if (p == null)
        {
            player p2 = other.GetComponent<player>();
            p2.jumpStr = 70f;
        }
        else
        {
            p.jumpStr = 70f;
        }
        other.GetComponent<Rigidbody2D>().drag = 10f;
    }
}
