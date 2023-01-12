using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierController : MonoBehaviour
{
    private BezierFollowLantern script;
    public Transform lanternPosition;
    private float tiltAngle = 0f;
    public Transform resetPosition;

    // Start is called before the first frame update
    void Start()
    {
        script = GetComponent<BezierFollowLantern>();
        //resetPosition.rotation = new Vector3(0,0,0);
    }

    public void ActivateBezier()
    {
        script.enabled = true;
        Vector3 newRotation = new Vector3(resetPosition.transform.eulerAngles.x, resetPosition.transform.eulerAngles.y, resetPosition.transform.eulerAngles.z);
        lanternPosition.transform.eulerAngles = newRotation;
        //lanternPosition.rotation = Quaternion.Euler(resetPosition.localRotation.eulerAngles.x, resetPosition.localRotation.eulerAngles.y, resetPosition.localRotation.eulerAngles.z); //Quaternion.Slerp(resetPosition.rotation, resetPosition.rotation, resetPosition.rotation);
    }

    public void DisactivateBezier()
    {
        script.enabled = false;
    }
}