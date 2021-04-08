using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueBaseClass : MonoBehaviour
    {

        public bool finished { get; private set; }

       public IEnumerator WriteText(string input, Text textHolder)//, AudioClip sound)
        {
          

            for(int i = 0; i < input.Length; i++)
            {
                textHolder.text += input[i];
                //play sounds
                yield return new WaitForSeconds(1f);
            }

            finished = true;
        }
    }
}