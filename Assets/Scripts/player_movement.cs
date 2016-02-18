using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {

    // params for animations
    public float speed = 60f;
    public float jumpStr;
    public bool isGrounded = false;
    public float maxVel = 10;
    private int jumpCount;

    // moving the rigid body
    private Rigidbody2D rb2d;
    //private Animator anim;

    // Use this for initialization
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        //anim = gameObject.GetComponent<Animator>();
        jumpStr = 30f;
        jumpCount = 0;
    }

    // Called once every frame of rigid body
    void Update()
    {
        Vector2 _vel = new Vector3(0, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            isGrounded = false;
            _vel.x -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isGrounded = false;
            _vel.x += speed;
        }
        rb2d.AddForce(_vel);
        if (Input.GetKeyDown(KeyCode.UpArrow)&& jumpCount <2)
        {
            isGrounded = false;
            rb2d.AddForce(Vector2.up * jumpStr, ForceMode2D.Impulse);
            jumpCount++;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && isGrounded)
        {
            rb2d.transform.Translate(Vector3.down * 1f);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        isGrounded = true;
        jumpCount = 0;
    }
}
