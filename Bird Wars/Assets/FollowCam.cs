using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public GameObject subject;
    public Vector3 offset;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = subject.transform.position + offset;
    }
}
