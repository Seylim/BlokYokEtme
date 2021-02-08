using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float velocity;
    [SerializeField] Rigidbody2D myBody;
    GameObject sliderBar;

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
            sliderBar = collision.gameObject;
            StartCoroutine(SliderBarAnim());
        }
    }

    private IEnumerator SliderBarAnim()
    {
        sliderBar.transform.position = new Vector3(sliderBar.transform.position.x, -8.6f, sliderBar.transform.position.z);
        yield return new WaitForSeconds(0.1f);
        sliderBar.transform.position = new Vector3(sliderBar.transform.position.x, -8.4f, sliderBar.transform.position.z);
        yield return new WaitForSeconds(0.1f);
        sliderBar.transform.position = new Vector3(sliderBar.transform.position.x, -8.5f, sliderBar.transform.position.z);
        yield return new WaitForSeconds(0.1f);

    }
}
