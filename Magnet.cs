using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject magnetObject;

    public Transform subBoomBody;

    public Transform pulleyLever;

    public float speed = 2f;
    private bool topLimit = false;
    private bool lowLimit  =false;
    public bool active = false;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //extendStopToggle();
        float angle = pulleyLever.transform.eulerAngles.x;
        if (angle > 315 && angle < 350)
        {
            ExtendMagnet();  
            
        }
        else if (angle <45 && angle > 0)
        {
            RetractMagnet();

        }
        

        Debug.Log("magnet y position: " + magnetObject.transform.position.y);

        Debug.Log("subBoom y position: " + subBoomBody.position.y);

        Debug.Log("sweet spot" + (subBoomBody.position.y - 0.05));
        
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "bottom" || other.tag == "barrel")
        {
            lowLimit = true;
            
           

        }
        else if (other.tag == "top")
        {

            topLimit = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "bottom")
        {
            lowLimit = false;
        }
        else if (other.tag == "top")
        {
            topLimit  = false;
        }
    }


    private void ExtendMagnet()
    {
       
        float current_position = magnetObject.transform.position.y;
        if ( active && !lowLimit)
        {
            transform.Translate(Vector3.forward *speed * Time.deltaTime );
            UIManager.Instance.ExtendPulleyDone();
        }
       
    }

    private void RetractMagnet(){

        float current_position = magnetObject.transform.position.y;
        if (active && !topLimit)
        {
            
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            lowLimit = false;
        }
    }

    public void Grabbed()
    {
        active = true;
    }

    public void UnGrabbed()
    {
        active = false;
    }

    //private void extendStopToggle(){
    //    float current_position = magnetObject.transform.position.y;
    //    if (current_position > subBoomBody.position.y - 0.08 || subBoomBody.position.y < 1.24){
           
    //        topLimit = true;
            
    //    }
        
    //    else {
    //        topLimit = false;
      
    //    }
    //}


    // public void OnTriggerEnter(){

    // }
}
