using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject bag;
    public GameObject invoButton;
    public GameObject wearBag;
    public GameObject invo;
    public bool bagPickedUp;
    public bool isOpen;
    public GameObject flashLight;
    public static bool flashEquipped;
    

    // Start is called before the first frame update
    void Start()
    {
        flashEquipped = false;
        bagPickedUp = false;
        isOpen = false;
       invoButton.SetActive(false);
        bag.SetActive(true);
        wearBag.SetActive(false);
       invo.SetActive(false);
        flashLight.SetActive(false);
      
      
       
    }

    public void openInvo()
    {
        
        isOpen = !isOpen;

        if (isOpen)
        {
            invo.SetActive(true);
            isOpen = true;
        }
        else
        {
            invo.SetActive(false);
            isOpen = false;
        }
    }
   
   

// Update is called once per frame
void Update()
    {
    
        
    }
    

    public void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            bag.SetActive(false);
            wearBag.SetActive(true);
            bagPickedUp = true;
            invoButton.SetActive(true);
            flashLight.SetActive(true);
            flashEquipped = true;
            
        }
    }
  
}
