using UnityEngine;
using UnityEditor.Events;

namespace Alexis.QuickScript {
    public class QuickRotateMono : MonoBehaviour
    {
        public Transform m_whatToRotate;
        public float m_globalSpeedeInAngle = 360;
        public Vector3 m_rotateAxis = Vector3.up;
        public Space m_space = Space.Self;


        void Update()
        {
            float deltatime = Time.deltaTime;
            transform.Rotate(m_rotateAxis,
                m_globalSpeedeInAngle * deltatime,
                m_space);

        }
    }
}