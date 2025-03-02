using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorScript : MonoBehaviour
{

    GameObject scoreUI;

    float randomX;
    float speed = 5;

    

    void Start()
    {
        
        randomX = Random.Range(10.60f, -10.60f);
        transform.position = new Vector2(randomX, transform.position.y);

        scoreUI = GameObject.FindGameObjectWithTag("score");
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.down * 100, Time.deltaTime * speed);

        if (transform.position.y <= -10f)
        {
            Destroy(gameObject);
        }


    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
                
            case "bullet":
                scoreUI.GetComponent<GameScore>().Score += 1;
                Destroy(gameObject);
                break;
                
        }
    }   

    
    

}
