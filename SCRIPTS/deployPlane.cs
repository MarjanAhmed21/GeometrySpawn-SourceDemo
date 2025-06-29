using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployPlane : MonoBehaviour
{
    public GameObject planePrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(planeWave());
    }

    private void spawnPlane()
    {
        GameObject a = Instantiate(planePrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 2.5f, Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator planeWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnPlane();
        }
    }
}
