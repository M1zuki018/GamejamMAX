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
        // �����Փ˂�������I�u�W�F�N�g�̖��O��"Landmine Women"�Ȃ��
        if (collision.gameObject.tag == "enemy")
        {
            // �Փ˂�������I�u�W�F�N�g���폜����
            Destroy(collision.gameObject);
        }
    }
}
