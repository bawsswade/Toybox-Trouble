using UnityEngine;
using System.Collections;

// for patches
public class player_movement : MonoBehaviour {

    public Sprite jumpL, jumpR, idleL, idleR;

    public GameObject projR, projL;
    public float speed = 60f;
    public float jumpStr;
    public bool isGrounded = false;
    public float maxVel = 10;
    private int jumpCount;

    // moving the rigid body
    private Rigidbody2D rb2d;
    private Sprite s;
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
            rb2d.transform.Translate(Vector3.down * 1.5f);
        }

        if(Input.GetKeyDown(KeyCode.Backslash))
        {
            if (rb2d.velocity.x < 0)
                Instantiate(projL, this.transform.position, Quaternion.identity);
            else
                Instantiate(projR, this.transform.position, Quaternion.identity);
        }
    }

    void FixedUpdate()
    {
        if(rb2d.velocity.x < 0)
        {
            if (isGrounded)
                this.gameObject.GetComponent<SpriteRenderer>().sprite = idleL;
            else
                this.gameObject.GetComponent<SpriteRenderer>().sprite = jumpL;
        }
        else
        {
            if(isGrounded)
                this.gameObject.GetComponent<SpriteRenderer>().sprite = idleR;
            else
                this.gameObject.GetComponent<SpriteRenderer>().sprite = jumpR;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        isGrounded = true;
        jumpCount = 0;
    }
}
