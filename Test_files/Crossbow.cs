using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    [SerializeField] private LayerMask layers;
    [SerializeField] private GameObject Arrow;
    [SerializeField] private Transform FirePoint;
    [SerializeField] private float fireDelay = 3f;
    private Collider2D target;

    private void Start()
    {
        InvokeRepeating("Fire",0f, fireDelay);
    }
    private void Fire()
    {
        if (target != null)
        {
            Instantiate(Arrow, FirePoint.position, FirePoint.rotation);
        }
    }
}