using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    [SerializeField] private Camera MainCamera;
    void Start()
    {
        MainCamera = Camera.main;
        MainCamera.GetComponent<CameraController>().AddTargetReference(gameObject);
    }
}
