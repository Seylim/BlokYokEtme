using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideBar : MonoBehaviour
{
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;
    public bool left = false;
    public bool right = false;
    //SlideBar'ın sol duvar ile temasını kontrol eden değişken.
    bool leftWallCollision;
    //SlideBar'ın sağ duvar ile temasını kontrol eden değişken.
    bool rightWallColision;
    //SlideBar'ın hızını belirleyen değişken.
    [SerializeField] float velocity;
    [SerializeField] Animator myAnimator;
    
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            //save began touch 2d point
            firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        if (Input.GetMouseButton(0))
        {
            //save ended touch 2d point
            secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            //create vector from the two points
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
            //normalize the 2d vector
            currentSwipe.Normalize();

            //swipe left
            if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f && !leftWallCollision)
            {
                //SlideBar'ın sola doğru harekerini sağlıyoruz.
                transform.position += Vector3.left * velocity * Time.timeScale;
                firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                rightWallColision = false;
                right = false;
                left = true;
            }
            //swipe right
            if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f && !rightWallColision)
            {
                //SlideBar'ın sağa doğru harekerini sağlıyoruz.
                transform.position += Vector3.right * velocity * Time.timeScale;
                firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                leftWallCollision = false;
                left = false;
                right = true;
            }
            if (currentSwipe.x == 0)
            {
                left = false;
                right = false;
            }
        }
    }

    //SliderBar'ın temaslarını kontrol ettiğimiz fonksiyon.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            AnimationStart();
        }
        if (collision.gameObject.tag == "LeftWall")
        {
            leftWallCollision = true;
            transform.position = new Vector3(-4.75f, transform.position.y, transform.position.z);
        }
        if (collision.gameObject.tag == "RightWall")
        {
            rightWallColision = true;
            transform.position = new Vector3(4.75f, transform.position.y, transform.position.z);
        }
    }
    //SliderBar'ın animasyonunu devreye sokan fonksiyon.
    public void AnimationStart()
    {
        myAnimator.SetBool("BallHit", true);
        StartCoroutine(AnimationController());
    }

    //SliderBar'ın animasyonunu belli bir süre sonra tekrar ilk haline çeviren fonksiyon.
    private IEnumerator AnimationController()
    {
        yield return new WaitForSeconds(1f);
        myAnimator.SetBool("BallHit", false);
    }
}
