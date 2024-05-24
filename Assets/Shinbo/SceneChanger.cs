using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Ç±ÇÍïKê{Ç≈Ç∑

public class SceneChanger : MonoBehaviour
{

    [SerializeField] private string loadScene;

    public void SwitchScene()
    {
        SceneManager.LoadScene(loadScene);
    }

}
