using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lighter : MonoBehaviour
{

    public static int lighterPer;
    public int lighterFuel;
    public Text lighterText;

    // Start is called before the first frame update
    void Start()
    {
      //  lighterPer = 100;
        lighterFuel = lighterPer;
    }

    // Update is called once per frame
    void Update()
    {
        lighterText.text =  "Fuel Left: " + lighterFuel;
    }
}
