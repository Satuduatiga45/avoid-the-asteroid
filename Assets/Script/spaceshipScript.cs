using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spaceshipScript : MonoBehaviour
{

    Rigidbody2D rb;
    public float ms;
    GameObject meteor;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        meteor = GameObject.FindGameObjectWithTag("meteor");
    }

    
    void Update()
    {
        float horiz = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horiz * ms, rb.velocity.y);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "meteor")
        {
            Time.timeScale = 0;
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }


    }

   

    
}
