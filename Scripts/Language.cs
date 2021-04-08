using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Language : MonoBehaviour
{
    public GameObject englishPanel;
    public bool isEnglish;

    public GameObject spanishPanel;
    public bool isSpanish;
    

    // Start is called before the first frame update
    void Start()
    {
        englishPanel.SetActive(false);
        isEnglish = true;
        spanishPanel.SetActive(false);
        isSpanish = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
   public void English()
    {
        englishPanel.SetActive(true);
        isEnglish = true;
        isSpanish = false;
    }

    public void Spanish()
    {
        spanishPanel.SetActive(true);
        isSpanish = true;
        isEnglish = false;
    }

   
}
