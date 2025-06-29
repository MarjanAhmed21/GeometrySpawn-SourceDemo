using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounds : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "myBullets")
        {
            Destroy(coll.gameObject);
        }
    }
}
