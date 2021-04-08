using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{

    public bool isOn;
    public GameObject light;

    // Start is called before the first frame update
    void Start()
    {
        light.SetActive(false);
        isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            isOn = !isOn;

            if(isOn && Inventory.flashEquipped)
            {
                light.SetActive(true);
                isOn = true;
            }
            else
            {
                light.SetActive(false);
                isOn = false;
            }
        }
    }
}
