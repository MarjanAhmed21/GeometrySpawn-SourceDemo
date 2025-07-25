using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class UIImageAnimate : MonoBehaviour
{
    public float duration;

    [SerializeField] private Sprite[] sprites;

    private Image image;
    private int index = 0;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((timer += Time.deltaTime) >= (duration / sprites.Length))
        {
            timer = 0;
            image.sprite = sprites[index];
            index = (index + 1) % sprites.Length;
        }
    }
}