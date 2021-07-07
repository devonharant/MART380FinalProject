using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    float initialScore;
    public static PlayerController manage;
    Rigidbody2D rigid;
    Animator ani;
    int power = 850;
    public bool isDead = false;
    AudioSource aud;
    public AudioClip jumping, dying;
    public GameObject score;
    public int finalScore;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        manage = this;
        aud = GetComponent<AudioSource>();
        score = GameObject.Find("Score");
    }

    // Update is called once per frame

    /**
     * ADD JUMPING, BACKGROUND, AND DYING SOUNDS TO UNITY
     */
    void Update()
    {
        if (!isDead)
        {
            initialScore += Time.deltaTime;
            finalScore = (int)initialScore * 10;
            score.GetComponent<Text>().text = "Score: " + finalScore.ToString("D5");
        }

        if (Input.GetKeyDown(KeyCode.Space) && rigid.velocity.y == 0 && !isDead)
        {
            rigid.AddForce(transform.up * power);
            aud.PlayOneShot(jumping, 4f);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            ani.SetBool("Jump", false);
        }
        if (other.gameObject.tag == "Enemy")
        {
            isDead = true;
            aud.PlayOneShot(dying, 4f);
            ani.SetTrigger("Dead");
            Invoke("music", 3f);
            Invoke("loadscene", 3f);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            ani.SetBool("Jump", true);
        }
    }

    void music()
    {
        aud.Stop();
    }
    void loadscene()
    {
        SceneManager.LoadScene("EndingScene");
    }
}

