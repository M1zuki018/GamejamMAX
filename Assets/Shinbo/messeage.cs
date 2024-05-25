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
        //20ïbà»â∫Ç»ÇÁ(40ïbà»è„)
        if (a <= 20) 
        {
            _Text.text = ("îjã«ÅIÅI");
        }
        //ÇQÇOïbà»è„&&ÇSÇOïbÇÊÇËè¨Ç≥Ç¢Ç»ÇÁ(40ïbñ¢ñû20ïbà»è„)
        if (a >= 20 && a < 40)
        {
            _Text.text = ("Ç‡Ç§ÇøÇÂÇ¡Ç∆Ç™ÇÒÇŒÇ¡Çƒ...");
        }
        //ÇSÇOïbà»è„&&ÇUÇOïbÇÊÇËè¨Ç≥Ç¢Ç»ÇÁ(20ïbñ¢ñû0ïbà»è„)
        if(a >= 40 && a < 60)
        {
            _Text.text = ("Ç†Ç†Ç¡ê…ÇµÇ¢");
        }
        //ÇUÇOïbà»è„Ç»ÇÁ(0ïbà»â∫)
        if(a >= 60)
        {
            _Text.text = ("åãÇŒÇÍÇ‹ÇµÇΩ");
        }
    }
}
