using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wayfinder : MonoBehaviour
{
    [SerializeField]
    protected float debugDrawRadius = 1.0f;

    public virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, debugDrawRadius);
    }
}