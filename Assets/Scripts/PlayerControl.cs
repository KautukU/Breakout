using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public GameObject Ball;
    public Transform BallSpawn;


    private Rigidbody2D rbody;
    
    // Start is called before the first frame update
    void Start()
    {
        /*Instantiate(Ball, BallSpawn.position, Ball.transform.rotation);*/

        rbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        rbody.velocity = new Vector2(horiz * speed, 0);

        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "BigPaddleDrop(Clone)")
        {
            rbody.transform.localScale = new Vector3(0.5f, 0.5f);
        }
        if (other.gameObject.name == "BigBall(Clone)")
        {
            
            Instantiate(Ball, BallSpawn.position, Ball.transform.rotation);
        }
    }

}
