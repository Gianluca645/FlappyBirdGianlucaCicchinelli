using UnityEngine;

public class Dropper : MonoBehaviour
{
    
    Rigidbody myRigidBody;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    public void Activate()
    {
        myRigidBody.useGravity = true;
    }
}
