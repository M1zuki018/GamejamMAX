using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    [SerializeField] private ObjectCreator _creator;

    //時間を表示するText型の変数
    [SerializeField] private Text TimeText;
    [SerializeField] string _sceneName;


    //カウントアップ
    public static float _countUpTimer = 0.0f;
    public static float _countDownTimer = 0.0f;

    private void Start()
    {
        _countUpTimer = 0;
        _countDownTimer = 60f;
    }

    // Update is called once per frame
    void Update()
    {

        //時間をカウントする
        _countUpTimer = _countUpTimer + Time.deltaTime;
        _countDownTimer -= Time.deltaTime;

        //時間を表示する
        TimeText.text = ("のこり ") + _countDownTimer.ToString("f1") + ("秒");

        if (_countDownTimer<=0)
        {
            SceneManager.LoadScene(_sceneName);
        }
    }
}