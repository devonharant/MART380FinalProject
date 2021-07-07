using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    float speed;
    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5.2f;
        //rigid = 
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.manage.isDead == false)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        
        if(transform.position.x < -11)
        {
            Destroy(gameObject);
        }
    }
}
