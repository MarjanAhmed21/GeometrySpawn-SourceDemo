using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullets : MonoBehaviour
{
    public int enemyLives;
    public int enemyLivesEnd = 0;
    public GameObject enemy;
    public GameObject levelComplete;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            enemyLives--;
            if (enemyLives == enemyLivesEnd)
            {
                enemy.gameObject.SetActive(false);
                levelComplete.gameObject.SetActive(true);
            }
        }

        if (coll.gameObject.tag == "bounds")
        {
            Destroy(gameObject);
        }
    }
}
