using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class HeroineMove : MonoBehaviour
{
    public float _speed = 5f;
    [SerializeField]
    float _baseSpeed=0.01f;
    float _rondomSpeed=1f;
    float _timer ;
    [SerializeField]
    float _moveTimer;
    bool _moveExecution=true;
    int _time = 2;
    public float _speedRangelow = 0.8f, _speedRangeMax=1.2f;
    [SerializeField]
    int _inversion = 180;
    [SerializeField]
    GameObject _leftGameObject;
    [SerializeField]
    GameObject _rightGameObject;
    [SerializeField]
    Vector2 _leftPosition;
    [SerializeField]
    Vector2 _rightPosition;
    // Start is called before the first frame update
    void Start()
    {
        if(_leftGameObject!=null)_leftPosition=_leftGameObject.transform.position;
        if(_rightGameObject!=null)_rightPosition=_rightGameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        _moveTimer = Time.deltaTime;
        if (_moveTimer >= 0.001f)
        {
            Move();
            _moveTimer=0;
        }
        if (_timer >= _time)
        {
            _moveExecution = true;
            randomDirection();
            _timer = 0;
            if(_moveExecution == false)
            {
                _time = 1;
            }
            else _time = Random.Range(2, 5);
            _rondomSpeed = Random.Range(_speedRangelow, _speedRangeMax);
        }
        
    }
    private void randomDirection()
    {
        int random = 0;
        random = Random.Range(1, 10);
        if (random <= 4) this.gameObject.transform.Rotate(0, -1*_inversion, 0);
        else if (random >= 9)
        {
            _timer = 0;
            _moveExecution = false;
        }
        else this.gameObject.transform.Rotate(0, _inversion, 0);
    }
    private void Move()
    {
        if (_leftPosition.x >= this.gameObject.transform.position.x) this.gameObject.transform.Rotate(0, _inversion, 0);
        if (_rightPosition.x <= this.gameObject.transform.position.x) this.gameObject.transform.Rotate(0, _inversion, 0);
        if (_moveExecution == true) transform.Translate(Vector2.left * _speed * _baseSpeed * _rondomSpeed, Space.Self);
        _timer += Time.deltaTime;
    }
}
