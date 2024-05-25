using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    [SerializeField] private ObjectCreator _creator;

    //時間を表示するText型の変数
    [SerializeField] private Text TimeText;


    //カウントアップ
    public static float _countUpTimer = 0.0f;

    private void Start()
    {
        _countUpTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {

        //時間をカウントする
        _countUpTimer += Time.deltaTime;

        //時間を表示する
        TimeText.text = _countUpTimer.ToString("f1");


    }
}