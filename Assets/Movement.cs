using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 7f;
    public LayerMask obstacleLayers;
    public Transform movePoint;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movePoint.position) <= 0.05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"),0f), .2f, obstacleLayers))
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"),0f);
                }
        
            }
            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) > 0)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical")), .2f, obstacleLayers))
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"));
                }
            }
        }
    }
}
