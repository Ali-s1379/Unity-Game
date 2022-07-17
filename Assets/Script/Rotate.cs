using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    public Text mytext;
    // Use this for initialization
    void Start()
    {
        mytext.color = Color.cyan;
        a = 0;
    }
    float a;
    float inc;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.75f, 0.75f, 0.75f);
        transform.position += transform.forward * Time.deltaTime;
        transform.Translate(5 * Time.deltaTime, 0, 0);
        mytext.text = Time.time.ToString("0");
       /* mytext.color = new Color(0, a, 0);
        
        if (a > 1)
        {
         inc *= -1f;
            a = 1;
        }
        if(a < 1)
        {
            a *= -1f;
            a = 0;
        }
        a += inc;
        */
    }
    bool switch1 = true;
    public void clickAction()
    {
        //   mytext.color = Color.magenta;
        switch1 = !switch1;
        mytext.gameObject.SetActive(switch1);
        mytext.gameObject.GetComponent<Text>().text = "done";
    }
}
