using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    float maxDistance = 100;
    public LayerMask layerMask;

    
    void Update()
    {
        Ray ray = new Ray(transform.position, Vector3.forward);
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo, maxDistance))
        {
            if(hitInfo.collider.gameObject.CompareTag("Target"))
            {
                hitInfo.collider.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
        }
    }
}
