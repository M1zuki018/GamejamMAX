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
        if (a <= 10) 
        {
            _Text.text = ("破局！！");
        }
        //２０秒以上&&４０秒より小さいなら(40秒未満20秒以上)
        if (a >= 10 && a < 20)
        {
            _Text.text = ("もうちょっとがんばって...");
        }
        //４０秒以上&&６０秒より小さいなら(20秒未満0秒以上)
        if(a >= 20 && a < 29)
        {
            _Text.text = ("ああっ惜しい");
        }
        //６０秒以上なら(0秒以下)
        if(a >= 29)
        {
            _Text.text = ("結ばれました");
        }
    }
}
