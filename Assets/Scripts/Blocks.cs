using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    [SerializeField] int deadHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            deadHit--;
            if (deadHit == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
