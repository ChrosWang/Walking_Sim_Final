using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScreen : MonoBehaviour
{
    public Image image;
    bool keypressed;
    float alpha;
    bool never;
    // Start is called before the first frame update
    void Start()
    {
        keypressed = false;
        never = false;
        alpha = 1f;
    }

    void onlyOnceSwitch() 
    {
        if (!never)
        {
            keypressed = true;
            never = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            onlyOnceSwitch();
        }

        if (keypressed && alpha > 0)
        {
            var tempColor = image.color;
            alpha = alpha - 0.02f;
            tempColor.a = alpha;
            image.color = tempColor;
            //Debug.Log("now is "+ alpha);
        }
    }
}
