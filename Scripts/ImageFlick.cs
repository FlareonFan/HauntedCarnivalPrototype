using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFlick : MonoBehaviour
{
    public float minTime = 0.05f;
    public float maxTime = 1.2f;

    private float timer;
    public Image imageFlicker;


    // Start is called before the first frame update
    void Start()
    {
        imageFlicker = GetComponent<Image>();
        timer = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            imageFlicker.enabled = !imageFlicker.enabled;
            
            timer = Random.Range(minTime, maxTime);
        }
    }
}

