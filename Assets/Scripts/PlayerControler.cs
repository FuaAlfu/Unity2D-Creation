using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2020.2.1
/// created by www.github.com/FuaAlfu
/// </summary>
public class PlayerControler : MonoBehaviour
{
    [SerializeField] 
    private float speed = 2.0f;

    [SerializeField]
    private float bounceY = 6.5f;


    private int count = 1;

    Rigidbody2D rb2D;
    GameSession gameSession;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        gameSession = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag == "terrine")
        {
            //  rb2D.AddForce(transform.up * 60f, ForceMode2D.Impulse);
            rb2D.velocity = new Vector2(0f,bounceY);
            gameSession.BounceCounter(count);
        }
    }
}
