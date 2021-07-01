using UnityEngine;

namespace HichDX
{
    public class ActionComponent : MonoBehaviour
    {
        public float Speed;
        public float jumpForce;
      
        private bool isJump;
        
        private Rigidbody rb;
        public LayerMask layer;
        public Transform cam;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        public Vector3 Move(Vector3 direction)
        {
            var targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            var moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);            
            return (moveDir * Speed * Time.deltaTime);
        }

        public void Jump()
        {
            Ray ray = new Ray(transform.position, Vector3.down);
            isJump = Physics.Raycast(ray, 1f, layer);

            if (isJump)
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

}