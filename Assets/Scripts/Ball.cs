using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float velocity;
    [SerializeField] Rigidbody2D myBody;
    [SerializeField] Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myBody.velocity = Vector3.down * 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SlideBar")
        {
            myBody.velocity = Vector3.up * velocity;
            myAnimator.SetBool("BallHit", true);
        }
    }
}
