using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    [SerializeField] int deadHit;
    [SerializeField] Sprite[] hitImages;
    private int hit;
    [SerializeField] AudioSource blockHitSound;
    public static int totalBlockNumber;

    // Start is called before the first frame update
    void Start()
    {
        totalBlockNumber++;
        deadHit = hitImages.Length + 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            hit++;
            deadHit--;
            if (deadHit <= 0)
            {
                blockHitSound.Play();
                Destroy(gameObject,0.07f);
                totalBlockNumber--;
            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = hitImages[hit-1];
            }
        }
    }
}
