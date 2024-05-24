using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjCreaterContoroller : MonoBehaviour
{
    [SerializeField] private ObjectCreator _creator;

    //時間を表示するText型の変数

    [SerializeField] private float _defaltInterval = 1f;

    [SerializeField] private float _minInterval = 0.01f;

    [SerializeField] private float _chageInterval = 15f;

    [SerializeField] private float _decreaseInterval = 0.1f;


    private float _changeTimeTimer = 0.0f;

    private float _creatInterval = 1;


    void Update()
    {

        //時間をカウントする
        _changeTimeTimer += Time.deltaTime;


        if (_changeTimeTimer >= _chageInterval)
        {
            Debug.Log($"現在の生成インターバル；{_creatInterval}");
            _creatInterval = Mathf.Clamp(_creatInterval - _decreaseInterval, _minInterval, _defaltInterval);
            _creator.SetCreateInterval(_creatInterval);
            _changeTimeTimer = 0;
            //_chageInterval -= 1;

        }
    }
}