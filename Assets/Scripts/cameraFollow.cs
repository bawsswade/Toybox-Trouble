using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
    //public GameObject player;
    public GameObject[] pList;
    public float smoothOffset = .05f;

    private Vector2 vel;
    public Vector3 minCamPos;
    public Vector3 maxCamPos;
    public Vector3 midPoint;

    // Use this for initialization
    void Start()
    {
        //player = GameObject.FindWithTag("character");
        pList = GameObject.FindGameObjectsWithTag("character");
        //minCamPos = new Vector3(-33f, -10f, -10);
        //maxCamPos = new Vector3(1f, 1f, -10);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        midPoint = Vector3.zero;
        foreach (GameObject g in pList)
        {
            midPoint += g.transform.position;
        }
        midPoint /= 2;

        float xPos = Mathf.SmoothDamp(transform.position.x, midPoint.x, ref vel.x, smoothOffset);
        float yPos = Mathf.SmoothDamp(transform.position.y, midPoint.y, ref vel.y, smoothOffset);

        transform.position = new Vector3(xPos, yPos +2f, transform.position.z);

        if (transform.position.x < minCamPos.x)
        {
            transform.position = new Vector3(minCamPos.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > maxCamPos.x)
        {
            transform.position = new Vector3(maxCamPos.x, transform.position.y, transform.position.z);
        }
        if (transform.position.y < minCamPos.y)
        {
            transform.position = new Vector3(transform.position.x, minCamPos.y, transform.position.z);
        }
    }

    public void SetMinPos()
    {
        minCamPos = transform.position;
    }

    public void SetMaxPos()
    {
        maxCamPos = transform.position;
    }
}
