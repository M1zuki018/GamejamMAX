using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //����K�{�ł�

public class Scene : MonoBehaviour
{

    [SerializeField] private string loadScene;

    public void scene()
    {
        SceneManager.LoadScene(loadScene);
    }

}
