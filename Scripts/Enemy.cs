using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int EnemyHealth = 10;
    GameObject enemy;

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyHealth <= 0)
        {
            GetComponent<EnemyAi>().enabled = false;
            //enemy.GetComponent<Animation>().Play("Dying");
           // Advance.numberKilled += 1;
            Destroy(gameObject);
        }
    }


}
