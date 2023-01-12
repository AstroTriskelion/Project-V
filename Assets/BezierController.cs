using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierController : MonoBehaviour
{
    private BezierFollowLantern script;
    public Transform lanternPosition;
    private float tiltAngle = 0f;
    public Transform resetPosition;
    public Rigidbody laternRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        script = GetComponent<BezierFollowLantern>();
        //resetPosition.rotation = new Vector3(0,0,0);
    }

    public void ActivateBezier()
    {
        script.enabled = true;
        laternRigidBody.freezeRotation = true;
        lanternPosition.transform.position = resetPosition.position;
        lanternPosition.transform.rotation = resetPosition.rotation;
    }

    public void DisactivateBezier()
    {
        script.enabled = false;
    }
}