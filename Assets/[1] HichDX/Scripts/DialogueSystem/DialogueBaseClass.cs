using System.Collections;
using TMPro;
using UnityEngine;

namespace HichDX
{
    public class DialogueBaseClass : MonoBehaviour
    {
        public bool Finished { get; private set; }
        protected IEnumerator WriteText(string input, TMP_Text textHolder, Color textColor, float delay, AudioClip sound, float delayBetweenLines)
        {
            textHolder.color = textColor;
            for (int i = 0; i < input.Length; i++)
            {
                textHolder.text += input[i];
                //SoundManager.instance.PlaySound(sound);
                yield return new WaitForSeconds(delay);
            }

            //yield return new WaitForSeconds(delayBetweenLines);
            yield return new WaitUntil(()=> Input.GetMouseButton(0));
            Finished = true;
        }
    }
}
