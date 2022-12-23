// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerScript : MonoBehaviour
{
    public float JumpForce;
    float Score;

    [SerializeField]
    bool isGrounded = false;
    bool Alive = true;

    Rigidbody2D RB;

    public Text ScoreText;

    // Update is called once per frame
    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        Score = 0;
    }


    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
       {
           if(isGrounded == true)
           {
               RB.AddForce(Vector2.up * JumpForce);
               isGrounded = false;
           }
       } 
       if(Alive)
       {
           Score += Time.deltaTime * 4;
           ScoreText.text = "SCORE: " + Score.ToString("F");
       }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            if(isGrounded == false)
            {
                isGrounded = true;
            }
        }
        if(collision.gameObject.CompareTag("zombie"))
        {
            Alive = false;
            SceneManager.LoadScene("GameOver");
        }
    }
}
