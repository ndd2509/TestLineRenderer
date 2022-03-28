using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeTut : MonoBehaviour
{
    public Camera cam;
public LineRenderer linerenderer;
public Transform firePoint;
    public float speed = 5f;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        DisableRope();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
		{
			Shoot();
		}
        if(Input.GetButtonDown("Fire1")){
EnableRope();
        }
        if(Input.GetButton("Fire1")){
UpdateRope();
        }
        if(Input.GetButtonUp("Fire1")){
DisableRope();
        }
        RotatedMouse();
    }

    void EnableRope(){
        linerenderer.enabled = true;
    }

    void UpdateRope(){
        var mousePos = (Vector2)cam.ScreenToWorldPoint(Input.mousePosition);
        linerenderer.SetPosition(0, firePoint.position);
        linerenderer.SetPosition(1,mousePos);
// Vector2 direction = mousePos - (Vector2)transform.position;
// RaycastHit2D hit = Physics
    }

    void DisableRope(){
        linerenderer.enabled = false;
    }

void RotatedMouse(){
     Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);

}
void Shoot ()
	{
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
	}
}
