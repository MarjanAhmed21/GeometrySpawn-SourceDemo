using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int enemyLives;
    public GameObject enemy;
    public GameObject levelComplete;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "myBullets")
        {
            Destroy(coll.gameObject);
            enemyLives--;
            if (enemyLives == 0)
            {
                enemy.gameObject.SetActive(false);
                levelComplete.gameObject.SetActive(true);
            }
        }
    }
}
