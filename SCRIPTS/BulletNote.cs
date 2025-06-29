using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletNote : MonoBehaviour
{
    public float moveSpeed = 7f;

    Rigidbody2D rb;

    PlayerMovement target;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<PlayerMovement>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    /*void OnTriggerEnter2D(Collider col)
    {
        if(col.gameObject.name.Equals ("Player"))
        {
            Destroy(gameObject);
        }
    }
    */
}
