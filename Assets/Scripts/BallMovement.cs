using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public GameObject Player;
    public Transform BallSpawn;
    private Rigidbody2D ball;


    int i = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        
        int rand = Random.Range(0, 3);

        if (rand == 0)
        {
            ball.velocity = new Vector2(-2f, speed);
        }
        else if (rand == 1)
        {
            ball.velocity = new Vector2(0f, speed);
        }
        else if (rand == 2)
        {
            ball.velocity = new Vector2(2f, speed);
        }
        
    }

    void Update()
    {

    }
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        float Player = ball.transform.position.x - GameObject.Find("Player").transform.position.x;
        if (collision.gameObject.name == "Player")
        {
            ball.velocity = new Vector2(Player * 5f, speed);
        }
    }
}
