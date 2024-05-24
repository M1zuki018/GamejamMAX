using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Ç±ÇÍïKê{Ç≈Ç∑

public class Scene : MonoBehaviour
{

    [SerializeField] private string loadScene;

    public void scene()
    {
        SceneManager.LoadScene(loadScene);
    }

}
