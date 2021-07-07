using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Ending : MonoBehaviour{
    GameObject player, background,
               obstacle, gameover,
               text1, text2;

    // Start is called before the first frame update
    void Start(){
        player = GameObject.Find("Player");
        obstacle = GameObject.Find("Obstacle");
        background = GameObject.Find("Background");
        gameover = GameObject.Find("gameover");
        text1 = GameObject.Find("betterluck");
        text2 = GameObject.Find("laughter");

        Sequence mySequence = DOTween.Sequence();
        mySequence.Append(gameover.GetComponent<SpriteRenderer>().DOFade(0, 0))
                  .Append(text1.GetComponent<SpriteRenderer>().DOFade(0, 0))
                  .Append(text2.GetComponent<SpriteRenderer>().DOFade(0, 0))
                  .Append(text1.GetComponent<SpriteRenderer>().DOFade(1,1))
                  .Append(text1.GetComponent<SpriteRenderer>().DOFade(1,1))
                  .Append(text1.GetComponent<SpriteRenderer>().DOFade(0, 1))
                  .Append(text2.GetComponent<SpriteRenderer>().DOFade(1,1))
                  .Append(obstacle.transform.DOJump(new Vector3(20, -1), 1, 4, 3))
                  .Append(text2.GetComponent<SpriteRenderer>().DOFade(0,1))
                  .Append(gameover.GetComponent<SpriteRenderer>().DOFade(1,2));
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene("OpeningScene");
        }
    }
}
