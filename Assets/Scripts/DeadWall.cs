using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadWall : MonoBehaviour
{
    //Sahne kontrolünü sağlayan değişken.
    [SerializeField] SceneManagenment sceneManagenment;
    //LoseScreen'in ne kadar süre sonra göstereceğini ayarlıyan değişken.
    [SerializeField] float time;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Topun teması halinde top objesini siliyoruz.
        Destroy(collision.gameObject);
        StartCoroutine(LoseWait(time));
    }

    //LoseScreen'in ne kadar süre sonra göstereceğini ayarlıyan fonksiyon.
    private IEnumerator LoseWait(float time)
    {
        yield return new WaitForSeconds(time);
        sceneManagenment.Scene("Lose");
    }
}
