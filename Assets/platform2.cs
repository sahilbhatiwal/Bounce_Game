using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.left, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("candy"))
        {
            Debug.Log("Candy Collided with Platform 2");
        }
    }
}
