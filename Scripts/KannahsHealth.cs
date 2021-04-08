using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KannahsHealth : MonoBehaviour
{
    public Text healthText;
    public static float fullHealth;
    public float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        fullHealth = 100;
        currentHealth = fullHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = " " + currentHealth + "/100";
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
            currentHealth = currentHealth - 10f;
            healthText.text = " " + currentHealth;
    }
}
