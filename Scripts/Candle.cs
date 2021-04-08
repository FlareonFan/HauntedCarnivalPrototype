using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{

    public static int actualNumberOfCandles;
    public int numberOfCandles;

    public static int actualNumberOfMatches;
   public int numberOfMatches;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numberOfCandles = actualNumberOfCandles;
      numberOfMatches = actualNumberOfMatches;
    }
}
