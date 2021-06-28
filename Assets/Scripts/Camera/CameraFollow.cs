using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    //let camera follow target
    public class CameraFollow : MonoBehaviour
    {
        public GameObject player;
        public float timeOffset;
        public Vector3 posOffset;

        private Vector3 velocity;

        private void Update()
        {
            transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + posOffset, ref velocity, timeOffset);
        }

    }
}
