using UnityEngine;

public class BonjourRotation : MonoBehaviour
{
    public float m_rotationspeed = 180;
    public bool m_inverse = false;
    void Start()
    {
        Debug.Log("Wello World");
    }
    private void OnEnable()
    {

        Debug.Log("tu me vois...");
    }
    private void OnDisable()
    {

        Debug.Log("tu me vois plus...");
    }

    void Update()
    {
        if (m_inverse)
            transform.Rotate(-m_rotationspeed * Time.deltaTime, 0, 0, Space.Self);
        else
            transform.Rotate(m_rotationspeed * Time.deltaTime, 0, 0, Space.Self);
    }
}
