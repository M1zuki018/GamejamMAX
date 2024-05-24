using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //����K�{�ł�

public class SceneChanger : MonoBehaviour
{

    [SerializeField] private string loadScene;

    public void SwitchScene()
    {
        SceneManager.LoadScene(loadScene);
    }

}