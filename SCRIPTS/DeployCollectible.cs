using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployCollectible : MonoBehaviour
{
    public GameObject collectiblePrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(collectibleWave());
    }

    private void spawnCollectible()
    {
        GameObject a = Instantiate(collectiblePrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x* 3.5f, Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator collectibleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnCollectible();
        }
    }
}
