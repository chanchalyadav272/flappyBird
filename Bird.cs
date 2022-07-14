using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour

{
    //animation

    private SpriteRenderer spriteRenderer;
    private int BirdIndex;
    public Sprite[] birds;

    private void Awake()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void BirdFlap()
    {
        BirdIndex++;

        if(BirdIndex >= birds.Length)
        {
            BirdIndex = 0;
        }

        spriteRenderer.sprite = birds[BirdIndex];

    }

    private void Start()
    {
        InvokeRepeating(nameof(BirdFlap), 0.1f, 0.1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().GameOver();
        }
       else if(collision.gameObject.tag == "Score" ){
        FindObjectOfType<GameManager>().IncreaseScore();
       }
    }














    // velocity
    private Vector3 v;

    //force 
    public float F = 5f;

    //gravity

    public float g = -9.8f;








    private void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            v = Vector3.up * F;
        }

        v.y += g * Time.deltaTime;
        transform.position += v * Time.deltaTime;
    }











}
