using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playermovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;

    private void Awake() {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update() {
        float horizontalInput = Input.GetAxis("Horizontal");
        
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);


        if(Input.GetKey(KeyCode.Space)) {
            body.velocity = new Vector2(body.velocity.x, speed);
        }
        
        anim.SetBool("Walk", horizontalInput != 0);
        flip();
        

    }  
    
    private void flip() {
        float horizontalInputTwo = Input.GetAxis("Horizontal");

        if ((horizontalInputTwo > 0) && (transform.localScale.x < 0)) {
            transform.localScale = new Vector3((-1) * transform.localScale.x, transform.localScale.y, transform.localScale.z);
        } else if ((horizontalInputTwo < 0) && (transform.localScale.x > 0)) {
            transform.localScale = new Vector3((-1) * transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
    }
    
        

}
