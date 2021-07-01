using UnityEngine;

namespace HichDX
{
    public class FadeScreen : MonoBehaviour
    {
        private Animator anim;

        private void Awake()
        {
            anim = GetComponent<Animator>();
        }

        public void Fade()
        {
            anim.SetTrigger("clickBut");
        }
    }
}
