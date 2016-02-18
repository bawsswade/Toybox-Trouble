using UnityEngine;
using System.Collections;

public class projLaunchRight : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb;

    IEnumerator Kill()
    {
        yield return new WaitForSeconds(0.5f);
        //Debug.Log("kill it!");
        Destroy(gameObject);
    }

	// Use this for initialization
	void Start () {
        speed = 50f;
        rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(Vector2.right * speed);
        StartCoroutine(Kill());
	}
}
