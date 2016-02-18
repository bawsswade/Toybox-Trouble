using UnityEngine;
using System.Collections;

public class projLaunchLeft : MonoBehaviour {

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
        rb.AddForce(Vector2.left * speed);
        StartCoroutine(Kill());
	}
}
