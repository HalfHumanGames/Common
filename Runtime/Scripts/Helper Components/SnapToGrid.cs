using UnityEngine;

namespace HHG.Common.Runtime
{
    public class SnapToGrid : MonoBehaviour
    {
        public float Snap = 1;
        public bool Local;

        private void LateUpdate()
        {
            transform.SnapPosition(Snap, Local);
        }
    }
}