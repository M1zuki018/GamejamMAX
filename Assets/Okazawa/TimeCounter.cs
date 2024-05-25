using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    [SerializeField] private ObjectCreator _creator;

    //���Ԃ�\������Text�^�̕ϐ�
    [SerializeField] private Text TimeText;


    //�J�E���g�A�b�v
    public static float _countUpTimer = 0.0f;

    private void Start()
    {
        _countUpTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {

        //���Ԃ��J�E���g����
        _countUpTimer += Time.deltaTime;

        //���Ԃ�\������
        TimeText.text = _countUpTimer.ToString("f1");


    }
}