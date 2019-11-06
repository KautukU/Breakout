using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public GameObject BigBall;
    public GameObject BigPaddle;
    private Rigidbody2D brick;
    // Start is called before the first frame update
    void Start()
    {
        brick = GetComponent<Rigidbody2D>();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball"|| collision.gameObject.name == "Ball2(Clone)")
        {
            float rand = Random.Range(0, 4);
            Destroy(this.gameObject);
            if (rand == 1)
            {
                Instantiate(BigBall, this.gameObject.transform.position, Quaternion.identity);
            }
            if (rand == 2)
            {
                Instantiate(BigPaddle, this.gameObject.transform.position, Quaternion.identity);
            }

        }
    }
    
}
