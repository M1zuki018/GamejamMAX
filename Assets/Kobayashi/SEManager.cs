using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour
{
    [SerializeField]AudioSource _audioSource;
    [SerializeField]AudioClip _clearSE;
    [SerializeField]AudioClip _gameOvarSE;
    [SerializeField]AudioClip _midGameOvarSE;
    [SerializeField]
    float _GameCountMAX=30;
    [SerializeField]GameObject _clearscreen;
    void Start()
    {
        _GameCountMAX=TimeCounter._countUpTimer;
        if(_GameCountMAX>=29)
        {
            _audioSource.PlayOneShot(_clearSE);
            if (_clearscreen != null)
            {
                _clearscreen.SetActive(true);
            }
        }
        else if(_GameCountMAX<=10)
        {
            _audioSource.PlayOneShot(_gameOvarSE);
        }
        else
        {
            _audioSource.PlayOneShot(_midGameOvarSE);
        }
    }
}
