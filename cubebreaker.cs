using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubebreaker : MonoBehaviour
{



    public float radius = 5.0F;
    public float power = 10.0F;


    private void OnCollisionEnter(Collision collision)
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