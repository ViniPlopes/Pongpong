using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    private Rigidbody2D rd;
    public Vector2 startingVelocity = new Vector2(5f, 5f);
    public GameManager gameManager;

    public float speedball = 1.1f;
    public void ReserBall()
    {
        transform.position = Vector3.zero;

        if (rd == null) rd = GetComponent<Rigidbody2D>();
        rd.velocity = startingVelocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Vector2 newvelocity = rd.velocity;

            newvelocity.y = -newvelocity.y;
            rd.velocity = newvelocity;
        }

        else if (collision.gameObject.CompareTag("Player")) 
        {
            rd.velocity = new Vector2(-rd.velocity.x, rd.velocity.y);
            rd.velocity *= speedball;
        }

        else if (collision.gameObject.CompareTag("Enemy"))
        {
            rd.velocity = new Vector2(-rd.velocity.x, rd.velocity.y);
            rd.velocity *= speedball;
        }

        if (collision.gameObject.CompareTag("PointEnemy"))
        {
            gameManager.ScoreEnemy();
            ReserBall();
        }
        if (collision.gameObject.CompareTag("PointPlayer"))
        {
            gameManager.ScorePlayer();
            ReserBall();
        }
   }
}
