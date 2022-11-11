




using UnityEngine;

public class Rotator
    : MonoBehaviour
{
    public   Rigidbody m_Rigidbody ;
    Vector3 m_EulerAngleVelocity;

    private void Awake()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();

        //Set the angular velocity of the Rigidbody (rotating around the Y axis, 100 deg/sec)
        m_EulerAngleVelocity = new Vector3(0, 100, 0);

    }

    void Start()
    {
       
    }

    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
    }
}











































/*using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 rotation;
    [SerializeField] private float speed;
    public Rigidbody rb;

    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * speed * Time.deltaTime);
        rb.MoveRotation()
    }
}*/
