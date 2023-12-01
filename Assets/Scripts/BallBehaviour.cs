using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallBehaviour : MonoBehaviour
{
    public Text scoreTxt;
    public Text gameOver;
    public int speed;
    Rigidbody rb;
    int score;
    int cubenumber=8;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vector = new Vector3(horizontal, 0, vertical);

        rb.AddForce(vector * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        score++;
        scoreTxt.text = "Score : " + score;
        if (score == cubenumber)
        {
            gameOver.gameObject.SetActive(true);
        }
    }
}
