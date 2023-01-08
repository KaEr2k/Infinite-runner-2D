using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes_spawm : MonoBehaviour
{
    [SerializeField] private GameObject Spikes;
    [SerializeField] private float fireDelay = 10f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spike",0f, fireDelay);
    }

    // Update is called once per frame
    private void Update()
    {

    }

    private void Spike()
    {
        Instantiate(Spikes);
    }
}
