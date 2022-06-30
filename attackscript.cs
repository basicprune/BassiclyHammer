using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackscript : MonoBehaviour
{

    public Animator anim;
    public float radius = 5.0F;
    public float power = 10.0F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


       if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("hit");
        } 
    }

    public void goboom()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)

        {
            if (hit.CompareTag("brickfeace"))
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                rb.isKinematic = false;

                if (rb != null)
                    rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
            }
            
        }
    }
}


