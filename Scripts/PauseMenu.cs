using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isOpen;
    public AudioSource audio;
    public GameObject Lang;
    

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        isOpen = false;
        Lang.SetActive(false);
       
    }

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isOpen = !isOpen;

            if (isOpen)
            {
                pauseMenu.SetActive(true);
                isOpen = true;
            }
        }
    }
        
    public void Langu()
    {
        Lang.SetActive(true);
    }
       
        public void MusicOn()
        {
        audio.Play();
        }

        public void MusicOff()
        {
        audio.Stop();
        }
        
    public void CloseLang()
    {
        Lang.SetActive(false);
    }
    
    public void OnButtonClick()
    {
       if(isOpen)
        {
            pauseMenu.SetActive(false);
            isOpen = false;
        }
    }
}
