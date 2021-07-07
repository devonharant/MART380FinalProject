using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject obstacle;
    float timer;
    float interval;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        interval = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > interval && PlayerController.manage.isDead == false)
        {
            Instantiate(obstacle, new Vector3(20, 2,0), Quaternion.identity);
            timer = 0;
            interval = Random.Range(1f, 2.5f);
        }
    }
}
