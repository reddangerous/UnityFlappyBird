using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float upForce = 200f;
    private bool isdead = false;
    private Rigidbody2D rb2d;
    

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (isdead) {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0, upForce));
            
        }
    }

     void OnCollisionEnter2D()
    {
        rb2d.velocity = Vector2.zero;
        isdead = true;
        GameController.instance.Die();
    }
}
