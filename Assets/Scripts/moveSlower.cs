using UnityEngine;
using System.Collections;

public class moveSlower : MonoBehaviour {

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("entered");

        GameObject[] gList = GameObject.FindGameObjectsWithTag("character");
        foreach (GameObject g in gList)
        {
            player_movement p = g.GetComponent<player_movement>();
            p.speed = 30f;
            //p.jumpStr = 15f;
            g.GetComponent<Rigidbody2D>().mass = .8f;
            g.GetComponent<Rigidbody2D>().gravityScale = 2f;
        }
    }
}
