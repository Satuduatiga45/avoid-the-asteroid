using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{

    void Start()
    {
 
    }

    void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position, Vector2.up * 100, Time.deltaTime * GetComponent<MainCharacter>().bulletSpeed);


        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "meteor")
        {
            Destroy(gameObject);
        }
    }


}
