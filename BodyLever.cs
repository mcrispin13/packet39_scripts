using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyLever : MonoBehaviour
{
    public Transform lever;
    public Transform slewBody;
    // Start is called before the first frame update
    private bool isDone = false;
    // Update is called once per frame
    void Update()
    {
        Vector3 newRot = new Vector3(slewBody.transform.eulerAngles.x, lever.transform.eulerAngles.x, slewBody.eulerAngles.z);
        slewBody.rotation = Quaternion.Euler(newRot);
        if (slewBody.transform.eulerAngles.x != 0 && !isDone)
        {
            isDone = true;
            UIManager.Instance.RotateCraneDone();
        }
    }
}
