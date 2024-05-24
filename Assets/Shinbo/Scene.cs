using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //これ必須です

public class Scene : MonoBehaviour
{

    [SerializeField] private string loadScene;

    public void scene()
    {
        SceneManager.LoadScene(loadScene);
    }

}
