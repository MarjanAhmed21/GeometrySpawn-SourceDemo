using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployClouds : MonoBehaviour
{
    public GameObject cloudPrefab;
    public GameObject cloudPrefab2;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(cloudWave());
    }

    private void spawnCloud()
    {
        GameObject a = Instantiate(cloudPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 3.5f, Random.Range(-screenBounds.y, screenBounds.y));
        GameObject b = Instantiate(cloudPrefab2) as GameObject;
        b.transform.position = new Vector2(screenBounds.x * 4.5f, Random.Range (-screenBounds.y, screenBounds.y));
    }
    
    IEnumerator cloudWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnCloud();
        }
    }
}
