using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Heroine")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("result");
        }
    }

}
