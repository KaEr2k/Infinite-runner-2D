using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 newPosition, lerpStartPos;
    public float lerpTime = .5f;
    public float cooldownv2 = 0f;
    [SerializeField] private float cooldown = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update() {
        cooldownv2 -= Time.deltaTime;

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && 0 >= cooldownv2) {
            lerpStartPos = transform.position;
            newPosition = transform.position + -Vector3.right * 10;
            lerpTime = 0f;
            cooldownv2 = cooldown;
        }
        if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && 0 >= cooldownv2) {
            lerpStartPos = transform.position;
            newPosition = transform.position + Vector3.right * 10;
            lerpTime = 0f;
            cooldownv2 = cooldown;
        }
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && 0 >= cooldownv2) {
            newPosition = transform.position + Vector3.up * 10;
            lerpStartPos = transform.position;
           lerpTime = 0f;
           cooldownv2 = cooldown;
        }
        if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && 0 >= cooldownv2) {
            newPosition = transform.position + -Vector3.up * 10;
            lerpStartPos = transform.position;
            lerpTime = 0f;
            cooldownv2 = cooldown;
        }

        if (lerpTime < .1f) {
            lerpTime += Time.deltaTime;
        }
        
        transform.position = Vector3.Lerp(lerpStartPos, newPosition, lerpTime);
    }
}
