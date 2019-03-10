using UnityEngine;
namespace Mono
{
    public class Player : MonoBehaviour
    {
        public bool Dead;
        private float speed;

        void Start()
        {
            speed = 5;
        }

        void Update()
        {
            float x = Input.GetAxisRaw("Horizontal");
            float z = Input.GetAxisRaw("Vertical");
            Vector3 vector = new Vector3(x, 0, z).normalized * speed * Time.deltaTime;
            transform.position += vector;
        }
    }
}
