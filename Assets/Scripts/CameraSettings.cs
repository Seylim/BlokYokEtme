using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettings : MonoBehaviour
{
    [SerializeField] SpriteRenderer backGround;
    // Start is called before the first frame update
    void Start()
    {
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float targetRatio = backGround.bounds.size.x / backGround.bounds.size.y;

        if (screenRatio >= targetRatio)
        {
            Camera.main.orthographicSize = backGround.bounds.size.y / 2;
        }
        else
        {
            float differenceInSize = targetRatio / screenRatio;
            Camera.main.orthographicSize = backGround.bounds.size.y / 2 * differenceInSize;
        }
    }
}
