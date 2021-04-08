using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClass
    {
        private Text textHolder;

        [Header ("Text Options")]
        [SerializeField] private string input;
        //  [SerializeField] private AudioClip sound;

        [Header("Panel Options")]
        [SerializeField] private GameObject panel;

    private void Awake()
        {
            textHolder = GetComponent<Text>();
            textHolder.text = "";
           
        }

        private void Start()
        {
            StartCoroutine(WriteText(input, textHolder)); //sound));
            panel.SetActive(true);
        }
    }

   
}