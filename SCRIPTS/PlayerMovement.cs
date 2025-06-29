using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    Animator anim;
    public float speed = 6.0f;
    public TMP_Text uiText;
    public TMP_Text uiTextResult;
    public TMP_Text uiText2;
    int ringsCollected;
    public int ringsNeeded;
    public int livesLost = 20;
    public GameObject Player;
    public GameObject PlayerGun;
    public GameObject Rings;
    public GameObject Enemyy;
    public GameObject gameOverScreen;
    public GameObject GunDeploy;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        ringsCollected = 0;

    }

    void FixedUpdate()
    {

        rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);


    }
    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x * transform.localScale.x < 0.0f)
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        // if (rb.velocity.y * transform.localScale.y < 0.0f)
        //transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        float xSpeed = Mathf.Abs(rb.velocity.x);
        anim.SetFloat("xspeed", xSpeed);
        float ySpeed = Mathf.Abs(rb.velocity.y);
        anim.SetFloat("yspeed", ySpeed);

        string uiString = ringsCollected + "/" + ringsNeeded;
        uiText.text = uiString;

        string uiStringResult = " " + ringsCollected;
        uiTextResult.text = uiStringResult;

        string uiString2 = " " + livesLost;
        uiText2.text = uiString2;

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Collectible")
        {
            Destroy(coll.gameObject);
            ringsCollected++;
            if (ringsCollected == ringsNeeded)
            {
                GunDeploy.gameObject.SetActive(true);
            }
        }

        if (coll.gameObject.tag == "Bullets")
        {
            Destroy(coll.gameObject);
            livesLost--;
            if (livesLost == 0)
            {
                gameOverScreen.gameObject.SetActive(true);
                Player.gameObject.SetActive(false);
                PlayerGun.gameObject.SetActive(false);
                Enemyy.gameObject.SetActive(false);
                Rings.gameObject.SetActive(false);
            }
        }

        if (coll.gameObject.tag == "Gun")
        {
             Destroy(coll.gameObject);
             PlayerGun.gameObject.SetActive(true);
             Player.gameObject.SetActive(false);
        }
    }
}
