using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //lineRenderer.SetPosition(0, transform.position);
        RaycastHit hit;
        if (Physics.Raycast(transform.position,transform.forward, out hit))
        {
            if (hit.collider)
            {
                lineRenderer.SetPosition(0, transform.forward * hit.distance);
            }
        }
        else lineRenderer.SetPosition(0, transform.forward*5000);
    }
}
