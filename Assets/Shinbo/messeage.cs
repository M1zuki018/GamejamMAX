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
        //20秒以下なら(40秒以上)
        if (a <= 20) 
        {
            _Text.text = ("");
        }
        //２０秒以上&&４０秒より小さいなら(40秒未満20秒以上)
        if (a >= 20 && a < 40)
        {
            _Text.text = ("");
        }
        //４０秒以上&&６０秒より小さいなら(20秒未満0秒以上)
        if(a >= 40 && a < 60)
        {
            _Text.text = ("");
        }
        //６０秒以上なら(0秒以下)
        if(a >= 60)
        {
            _Text.text = ("");
        }
    }
}
