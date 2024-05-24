using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class HeroineMove : MonoBehaviour
{
    public float _speed = 0.01f;
    float _timer ;
    bool _moveExecution=true;
    int _time=2;
    [SerializeField]
    GameObject _leftGameObject;
    [SerializeField]
    GameObject _rightGameObject;
    Vector2 _leftPosition;
    Vector2 _rightPosition;
    // Start is called before the first frame update
    void Start()
    {
        _leftPosition=_leftGameObject.transform.position;
        _rightPosition=_rightGameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (_leftPosition.x >= this.gameObject.transform.position.x) this.gameObject.transform.Rotate(0,180,0);
        if (_rightPosition.x <= this.gameObject.transform.position.x) this.gameObject.transform.Rotate(0, 180, 0);
        if (_moveExecution == true) transform.Translate(Vector2.left * _speed, Space.Self);
        _timer += Time.deltaTime;
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
        }
        
    }
    private void randomDirection()
    {
        int random = 0;
        random = Random.Range(1, 10);
        if (random <= 4) this.gameObject.transform.Rotate(0, -180, 0);
        else if (random >= 9)
        {
            _timer = 0;
            _moveExecution = false;
        }
        else this.gameObject.transform.Rotate(0, 180, 0);
    }
}
