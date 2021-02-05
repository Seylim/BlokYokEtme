using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    static PlayMusic music = null;
    // Start is called before the first frame update
    void Start()
    {
        if (music != null)
        {
            Destroy(gameObject);
        }
        else
        {
            music = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
