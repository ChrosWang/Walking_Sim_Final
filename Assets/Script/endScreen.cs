using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endScreen : MonoBehaviour
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
        alpha = 0f;
    }

    public void onlyOnceSwitch() 
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
        if (keypressed && alpha <= 1.0f)
        {
            var tempColor = image.color;
            alpha = alpha + 0.02f;
            tempColor.a = alpha;
            image.color = tempColor;
            Debug.Log("now is "+ alpha);
        }
    }
}


