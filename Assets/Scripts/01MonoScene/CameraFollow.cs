using UnityEngine;
namespace Mono
{
    public class CameraFollow : MonoBehaviour
    {
        private GameObject player;

        void Start() => player = GameObject.FindWithTag("Player");

        void Update() => transform.position = new Vector3(player.transform.position.x,
            transform.position.y, player.transform.position.z);
    }

}

