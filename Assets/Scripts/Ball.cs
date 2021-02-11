using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Topumuzun ne kadar hızlı hareket edeceğini belirliyen değişken
    [SerializeField] float velocity;
    [SerializeField] Rigidbody2D myBody;
    [SerializeField] SlideBar slideBar;
    //Oyunun başladığını belirliyen değişken.
    bool start;

    // Update is called once per frame
    void Update()
    {
        //Eğer mouse tıklaması bırkıldığında ve oyun başlamamışsa oyunu başlatıyoruz, sliderBar animasyonunu başlatıyoruz ve topa hareket sağlıyoruz.
        if (Input.GetMouseButtonUp(0) && !start)
        {
            start = true;
            slideBar.AnimationStart();
            if (slideBar.right)
            {
                myBody.velocity = new Vector3(2f, velocity, 0f);
            }
            if (slideBar.left)
            {
                myBody.velocity = new Vector3(-2f, velocity, 0f);
            }
            if(!slideBar.left && !slideBar.right)
            {
                myBody.velocity = Vector3.up * velocity;
            }
            
        }
        //Eğer oyun başlamamışsa topu slideBar ile birlikte hareket etmesini sağlıyoruz.
        if (!start)
        {
            gameObject.transform.position = new Vector3(slideBar.transform.position.x, slideBar.transform.position.y + 0.284f, slideBar.transform.position.z);
        }
    }
}
