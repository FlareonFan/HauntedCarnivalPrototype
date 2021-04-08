using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CandleHealthUI : MonoBehaviour
{

    public GameObject lantern;
    public GameObject playerArm;

    public GameObject pickUpText;

    public bool isPickedUp;

    //for the flames inside the player's lantern
    public GameObject FullHealth;
    // public GameObject fullHealth;
    public GameObject HalfHealth;
    public GameObject LowHealth;
    //public GameObject NoHealth;
    public GameObject candleObject;

    public int flameLevel;
    public Text lighterLevel;
   

    public float timer;
    public bool isLit;




    //for the UI showing the candle's health, this may be changed as trying ideas out
    //public GameObject FullHealthUI;
    // public GameObject HalfHealthUI;
    // public GameObject LowHealthUI;

    // Start is called before the first frame update
    void Start()
    {

        Candle.actualNumberOfMatches = 100;
        Candle.actualNumberOfCandles = 1;
        lantern.SetActive(true);
        playerArm.SetActive(false);
        isPickedUp = false;
        pickUpText.SetActive(false);
        FullHealth.SetActive(false);
        HalfHealth.SetActive(false);
        LowHealth.SetActive(false);
        flameLevel = 101;
        //minusFlameLevel();
        isLit = true;
        candleObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        lighterLevel.text = "Lighter Fuel: " + Candle.actualNumberOfMatches;
        if (Input.GetKeyDown(KeyCode.L))
        {
            lantern.SetActive(false);
            playerArm.SetActive(true);
            pickUpText.SetActive(false);
            isPickedUp = true;
        }


        if (Input.GetKeyDown(KeyCode.C))
        {
            if (!isPickedUp && Candle.actualNumberOfCandles >= 0)
            {
                Debug.Log("No Lantern Found");
            }

        if (isPickedUp && Candle.actualNumberOfCandles == 0)
            {
                Candle.actualNumberOfCandles = 0;
                Debug.Log("No Candles");
            }

        if (isPickedUp && Candle.actualNumberOfCandles >= 1)
            {
                Debug.Log("Candle can be lit");
                Candle.actualNumberOfCandles -= 1;
            }
        }
    }
}
        
     
