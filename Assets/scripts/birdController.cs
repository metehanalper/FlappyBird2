using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Animator animator;
    private bool isDead;

    private float addForce=200f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead && Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0,1)*addForce);
            animator.SetTrigger("flapp");
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        animator.SetTrigger("dead");
        
    }
}
