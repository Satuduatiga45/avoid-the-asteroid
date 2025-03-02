using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{

    float time = 0;
    float timer = 0.5f;
    public GameObject meteor;

    void Start()
    {
        
    }

    
    void Update()
    {
        
        if (time <= 0)
        {
            Instantiate(meteor, transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
        if (timer >= 0) 
        {
            timer -= 0.0001f;
        }
        
    }
}
