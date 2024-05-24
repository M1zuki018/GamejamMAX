using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        // もし衝突した相手オブジェクトの名前が"Landmine Women"ならば
        if (collision.gameObject.tag == "enemy")
        {
            // 衝突した相手オブジェクトを削除する
            Destroy(collision.gameObject);
        }
    }
}
