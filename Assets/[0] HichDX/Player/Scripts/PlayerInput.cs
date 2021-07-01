using UnityEngine;

namespace HichDX
{
    public class PlayerInput : MonoBehaviour
    {
        private ActionComponent action;
        private AnimatorComponent animatorComponent;
        public CharacterController controller;

        public GameObject camFollow;

        private void Start()
        {
            action = GetComponent<ActionComponent>();
            animatorComponent = GetComponent<AnimatorComponent>();
        }

        private void Update()
        {
            var posX = Input.GetAxis("Horizontal");
            var posZ = Input.GetAxis("Vertical");

            var direction = new Vector3(posX, 0, posZ);

            if (direction.x != 0 || direction.z != 0)
                controller.Move(action.Move(direction));

            animatorComponent.MoveAnim(posX, posZ);

            if (Input.GetButtonDown("Jump"))
                action.Jump();

            if (Input.GetButtonDown("Fire1"))
                animatorComponent.AttackAnim();



        }
    }
}
