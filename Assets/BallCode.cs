using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCode : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float ballSpeed = 10f;
    [SerializeField] GameObject Score1;
    [SerializeField] GameObject Score2;
    private int plr1score;
    private int plr2score;
    public Vector3 startPosition;

    private void Start()
    {
        LaunchBall();
    }
    void LaunchBall()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(ballSpeed*x,ballSpeed*y);
    }

    void ResetBall()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        LaunchBall();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            plr2score++;
            Score2.GetComponent<Text>().text = plr2score.ToString();
            ResetBall();
        }

        if (collision.gameObject.layer == 6)
        {
            plr1score++;
            Score1.GetComponent<Text>().text = plr1score.ToString();
            ResetBall();
        }
    }
}
