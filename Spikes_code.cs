using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes_code : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject laser;
    void Start()
    {
        StartCoroutine(ShowAndHide(3.0f));
    }
    IEnumerator ShowAndHide(float delay)
    {
        laser.SetActive(true);
        yield return new WaitForSeconds(delay);
        laser.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
