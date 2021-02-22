using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    //public GameObject keyButton;

    private bool machineState = false;

    public Color redColor;
    public Color greenColor;


    //levers
    
    public GameObject pulleyLever;
    public GameObject boomLever;

    public GameObject bodyLever;
    public GameObject subBoomLever;



    void Start()
    {
        bodyLever.GetComponent<SphereCollider>().enabled = false;
        boomLever.GetComponent<SphereCollider>().enabled = false;
        pulleyLever.GetComponent<SphereCollider>().enabled = false;
        subBoomLever.GetComponent<SphereCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if (other.tag == "Button" && machineState == false){
          
            UIManager.Instance.IgnitionDone();
            
            //  materialColored = new Material(Shader.Find("Diffuse"));
            //  materialColored.color = currentColor = ObjectColor;
            Debug.Log("Machine has turned on");
            other.GetComponent<Renderer>().material.color = greenColor;
            bodyLever.GetComponent<SphereCollider>().enabled = true;
            boomLever.GetComponent<SphereCollider>().enabled = true;
            pulleyLever.GetComponent<SphereCollider>().enabled = true;
            subBoomLever.GetComponent<SphereCollider>().enabled = true;
            //Debug.Log("The lever's layer is: " + bodyLever.layer); 

        }

        if (other.tag == "Button" && machineState == true){
            //  materialColored = new Material(Shader.Find("Diffuse"));
            //  materialColored.color = currentColor = ObjectColor;
            Debug.Log("Machine has turned Off");
            other.GetComponent<Renderer>().material.color = redColor; 
            bodyLever.GetComponent<SphereCollider>().enabled = false;
            boomLever.GetComponent<SphereCollider>().enabled = false;
            pulleyLever.GetComponent<SphereCollider>().enabled = false;
            subBoomLever.GetComponent<SphereCollider>().enabled = false;
            //Debug.Log("The lever's layer is: " + bodyLever.layer); 
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
