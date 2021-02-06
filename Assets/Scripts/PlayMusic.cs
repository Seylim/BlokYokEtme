using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    static PlayMusic music = null;

    //Awake fonksiyonu obje oluşurken çalışan ilk fonksiyon.
    void Awake()
    {
        //Eğer müzik çalan PlayMusic sınıfına sahip obje yok ise music adlı değişkene ilk oluşturulan objeyi static değişkene atıyoruz.
        if (music == null)
        {
            music = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
        //Eğer müzik çalan PlayMusic sınıfına sahip obje var ise yeni oluşturulan objeyi yok ediyoruz.
        else
        {
            Destroy(gameObject);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
