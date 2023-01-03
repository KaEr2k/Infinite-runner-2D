using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    [SerializeField] private float scanRadius = 8f;
    [SerializeField] private LayerMask layers;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private Transform FirePoint;
    [SerializeField] private float fireDelay = 3f;
    private Collider2D target;

    private void Start()
    {
        InvokeRepeating("Fire",0f, fireDelay);
    }

    private void Update()
    {
        CheckEnviroment();
        LookAtTarget();
    }

    private void CheckEnviroment()
    {
        target = Physics2D.OverlapCircle(transform.position, scanRadius, layers);
        if (target != null)Debug.Log(target.gameObject.name);
    }

    private void LookAtTarget()
    {
        if (target != null)
        {
            Vector2 direction = target.transform.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    private void Fire()
    {
        if (target != null)
        {
            Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, scanRadius);
    }
}