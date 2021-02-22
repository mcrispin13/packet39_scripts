using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetDrop : MonoBehaviour
{
    // Start is called before the first frame update

    public Color greenColor;

    public Color orangeColor;

    private bool machineState = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("magnet : " + BarrelTrigger.Instance.magnetOn);
    }

    public void OnTriggerEnter(Collider other){
        if (other.tag == "magnet button" && machineState == false){
            UIManager.Instance.PickUpDone();
            BarrelTrigger.Instance.magnetOn = true;
            other.GetComponent<Renderer>().material.color = greenColor;
        }

        if (other.tag == "magnet button" && machineState == true){
            BarrelTrigger.Instance.magnetOn = false;
            other.GetComponent<Renderer>().material.color = orangeColor;
        }

        toggleMachineState();
    }


    public void toggleMachineState(){
        if (machineState == false) machineState = true;
        else{
            machineState = false;
        }
    }
}
