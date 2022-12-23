// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    public ZomGenerator zomGenerator;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * zomGenerator.curr * Time.deltaTime);
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("nextZom"))
        {
            zomGenerator.RandomZombie();
        }
        if(collision.gameObject.CompareTag("End"))
        {
            Destroy(this.gameObject);
        }
    }
}
