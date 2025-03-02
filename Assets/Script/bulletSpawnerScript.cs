using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawnerScript : MonoBehaviour
{
    float time = 0;
    float timer;
    public GameObject bullet;

    void Start()
    {

    }


    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            if (time <= 0)
            {
                Instantiate(bullet, transform.position, Quaternion.identity);
                time = timer;
            }
            else
            {
                time -= Time.deltaTime;
            }
        }
    }
}
