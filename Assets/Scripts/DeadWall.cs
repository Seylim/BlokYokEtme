using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadWall : MonoBehaviour
{
    [SerializeField] SceneManagenment sceneManagenment;
    [SerializeField] float time;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        StartCoroutine(LoseWait(time));
    }

    private IEnumerator LoseWait(float time)
    {
        yield return new WaitForSeconds(time);
        sceneManagenment.Scene("Lose");
    }
}
