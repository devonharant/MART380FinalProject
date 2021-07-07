using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Opening : MonoBehaviour{
    GameObject player;
    GameObject obstacle1, obstacle2, obstacle3;
    GameObject background;
    GameObject title1;
    GameObject title2;
    GameObject story1, story2;
    // Start is called before the first frame update
    void Start(){
        player = GameObject.Find("Player");
        obstacle1 = GameObject.Find("Obstacle1");
        obstacle2 = GameObject.Find("Obstacle2");
        obstacle3 = GameObject.Find("Obstacle3");
        background = GameObject.Find("Background");
        title1 = GameObject.Find("GameTitle");
        title2 = GameObject.Find("spacetoplay");
        story1 = GameObject.Find("text1");
        story2 = GameObject.Find("text2");

        Sequence mySequence = DOTween.Sequence();
        mySequence.Append(title1.GetComponent<SpriteRenderer>().DOFade(0, 0))
                  .Append(title2.GetComponent<SpriteRenderer>().DOFade(0, 0))
                  .Append(story1.GetComponent<SpriteRenderer>().DOFade(0, 0))
                  .Append(story2.GetComponent<SpriteRenderer>().DOFade(0,0))
                  .Append(player.transform.DOJump(new Vector2(5, 0), 1, 3, 3))
                  .Append(obstacle1.transform.DOJump(new Vector3(5,-3.25f),1,3,3))
                  .Append(story1.GetComponent<SpriteRenderer>().DOFade(1,1))
                  .Append(obstacle1.transform.DOMove(new Vector3(5,-3.25f), 1))
                  .Append(story1.GetComponent<SpriteRenderer>().DOFade(0,1))
                  .Append(obstacle1.transform.DOMove(new Vector3(20, -3.25f), 2))
                  .Append(player.transform.DOMove(new Vector3(22, 0), 2))
                  .Append(story2.GetComponent<SpriteRenderer>().DOFade(1,1))
                  .Append(obstacle1.transform.DOMove(new Vector3(20, -3.25f), 1))
                  .Append(story2.GetComponent<SpriteRenderer>().DOFade(0,1))
                  .Append(player.transform.DORotate(new Vector2(0,180), 1))
                  .Append(player.transform.DOMove(new Vector3(-30,0), 3))
                  .Append(obstacle1.transform.DOMove(new Vector3(-20, -3.25f), 3))
                  .Append(obstacle2.transform.DOMove(new Vector3(-20, -3), 3))
                  .Append(obstacle3.transform.DOMove(new Vector3(-20, -3), 3))
                  .Append(title1.GetComponent<SpriteRenderer>().DOFade(1,2))
                  .Append(title2.GetComponent<SpriteRenderer>().DOFade(1,2));
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene("GameScene");
        }
    }
}
