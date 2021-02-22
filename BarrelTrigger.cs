using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelTrigger : Singleton<BarrelTrigger>
{
    public GameObject barrel;

    public GameObject magnet;
    private float speed = 0.01f;

    public bool magnetOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "magnet")
        {

            if (magnetOn)
            {
                
                barrel.GetComponent<FixedJoint>().connectedBody = other.GetComponent<Rigidbody>();
                Debug.Log("this is the fixed joint " + barrel.GetComponent<FixedJoint>().connectedBody);
            }

            else
            {
                UIManager.Instance.DropBoomDone();
                barrel.GetComponent<FixedJoint>().connectedBody = null;
                Destroy(barrel.GetComponent<FixedJoint>());
            }
        }
    }

}
