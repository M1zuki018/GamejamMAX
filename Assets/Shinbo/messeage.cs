using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messeage : MonoBehaviour
{
    float a;
    public Text _Text;

    // Start is called before the first frame update
    void Start()
    {
        a = TimeCounter._countUpTimer;
    }

    // Update is called once per frame
    void Update()
    {
        //20�b�ȉ��Ȃ�(40�b�ȏ�)
        if (a <= 20) 
        {
            _Text.text = ("�j�ǁI�I");
        }
        //�Q�O�b�ȏ�&&�S�O�b��菬�����Ȃ�(40�b����20�b�ȏ�)
        if (a >= 20 && a < 40)
        {
            _Text.text = ("����������Ƃ���΂���...");
        }
        //�S�O�b�ȏ�&&�U�O�b��菬�����Ȃ�(20�b����0�b�ȏ�)
        if(a >= 40 && a < 60)
        {
            _Text.text = ("�������ɂ���");
        }
        //�U�O�b�ȏ�Ȃ�(0�b�ȉ�)
        if(a >= 60)
        {
            _Text.text = ("���΂�܂���");
        }
    }
}
