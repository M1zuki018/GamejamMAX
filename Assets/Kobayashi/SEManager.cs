using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour
{
    [SerializeField]AudioSource _audioSource;
    [SerializeField]AudioClip _clearSE;
    [SerializeField]AudioClip _gameOvarSE;
    [SerializeField]AudioClip _midGameOvarSE;
    float _a=60;
    void Start()
    {
        _a=TimeCounter._countUpTimer;
        if(_a>=60)
        {
            _audioSource.PlayOneShot(_clearSE);
        }
        else if(_a<=20)
        {
            _audioSource.PlayOneShot(_gameOvarSE);
        }
        else
        {
            _audioSource.PlayOneShot(_midGameOvarSE);
        }
    }
}
