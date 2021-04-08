using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkingText : MonoBehaviour
{

    public float minTime = 0.05f;
    public float maxTime = 1.2f;

    private float timer;
    private Text textFlicker;
   


    // Start is called before the first frame update
    void Start()
    {
        
        textFlicker = GetComponent<Text>();
        timer = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
           
            textFlicker.enabled = !textFlicker.enabled;
            timer = Random.Range(minTime, maxTime);
        }
    }
}
