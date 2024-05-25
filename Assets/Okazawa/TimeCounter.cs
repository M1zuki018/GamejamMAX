using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    [SerializeField] private ObjectCreator _creator;

    //���Ԃ�\������Text�^�̕ϐ�
    [SerializeField] private Text TimeText;
    [SerializeField] string _sceneName;


    //�J�E���g�A�b�v
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

        //���Ԃ��J�E���g����
        _countUpTimer = _countUpTimer + Time.deltaTime;
        _countDownTimer -= Time.deltaTime;

        //���Ԃ�\������
        TimeText.text = ("�̂��� ") + _countDownTimer.ToString("f1") + ("�b");

        if (_countDownTimer<=0)
        {
            SceneManager.LoadScene(_sceneName);
        }
    }
}