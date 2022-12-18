using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _FollowAnchor : MonoBehaviour
{
    [SerializeField] private Transform objectToFollow;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        objectToFollow = GameObject.Find("Flame").transform;
        offset = transform.position - objectToFollow.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objectToFollow.position + offset;
    }
}
