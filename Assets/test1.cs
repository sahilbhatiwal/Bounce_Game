using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    public float keyinput;
    public bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == true & Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*7, ForceMode.VelocityChange);
            flag = false;
        }

        keyinput = Input.GetAxis("Horizontal")*2;
        GetComponent<Rigidbody>().velocity = new Vector3(keyinput, GetComponent<Rigidbody>().velocity.y*1f, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        flag = true;
        if(collision.gameObject.CompareTag("platform 1"))
        {
            Debug.Log("Ball collided with platform 1");
        }
    }
}
