using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides 
/// </summary>
public class EulerRotationController : MonoBehaviour
{
    GameObject rotatedObject;

    /// <summary>
    /// Finds the object to rotate
    /// </summary>
    void Start()
    {
        rotatedObject = GameObject.FindGameObjectWithTag("RotatedObject");
    }

    void Update(){}

    public void ResetRotation()
    {
        Debug.Log("Reset");
        rotatedObject.transform.eulerAngles = Vector3.zero;
    }
}
