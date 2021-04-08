using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanternPickUp : MonoBehaviour
{

    public GameObject Lantern;
    public GameObject Arm;

    public bool isPickedUp;

    public GameObject lanternPickUpText;

    // Start is called before the first frame update
    void Start()
    {
       Lantern.SetActive(true);
        Arm.SetActive(false);
        isPickedUp = false;
        lanternPickUpText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
           Lantern.SetActive(false);
            Arm.SetActive(true);
            isPickedUp = true;
        }
    }

    }

