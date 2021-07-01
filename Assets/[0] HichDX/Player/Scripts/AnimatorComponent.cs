using UnityEngine;

namespace HichDX
{
    public class AnimatorComponent : MonoBehaviour
    {
        public Animator animator;

        public void MoveAnim(float posX, float posZ)
        {
            animator.SetFloat("PosX", posX);
            animator.SetFloat("PosY", posZ);
        }

        public void AttackAnim()
        {
            animator.SetTrigger("Attack");
        }
    }
}
