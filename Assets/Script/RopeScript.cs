using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeScript : MonoBehaviour
{
    private LineRenderer lineRenderer;
    [SerializeField]
    private Transform start;
 public float speed = 3f;
    Vector3 vStart;
 void Start() {
    vStart = start.position;

    lineRenderer = GetComponent<LineRenderer>();
    lineRenderer.SetPosition(0,vStart);
    lineRenderer.SetPosition(1,transform.position);
}
 void Update() {
lineRenderer.SetPosition(1,transform.position);    
if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            transform.Translate(Vector3.down* speed * Time.deltaTime);
            if (Mathf.Abs(transform.position.x) > 8 || transform.position.y <-4)
            {
                            transform.Translate(Vector3.up* speed * Time.deltaTime);

            }
           
        }
}
  
}
