using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    float speed = 3f;
    float width = 19.2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.manage.isDead == false)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }

        if (transform.position.x < -width)
        {
            transform.position += new Vector3(2 * width, 0, 0);
        }
    }
}
