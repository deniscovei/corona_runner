using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilula : MonoBehaviour
{
    public float initialSpeed = 20.0f;
    public float speed = 0.0f;
    private Rigidbody2D rb;
    private ParticleSystem particle;
    private SpriteRenderer sr;
    private CircleCollider2D cc;
    private AudioSource audioSource;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        speed = initialSpeed;
        rb.velocity = new Vector2(-speed, 0);
    }

    private void Awake()
    {
        particle = GetComponentInChildren<ParticleSystem>();
        sr = GetComponent<SpriteRenderer>();
        cc = GetComponent<CircleCollider2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (transform.position.x < -10f || transform.position.y < -100f || transform.position.y > 100f)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Score.imunitate += 7;
            StartCoroutine(Break());
        }
    }

    private IEnumerator Break()
    {
        cc.enabled = false;
        sr.enabled = false;
        particle.Play();
        audioSource.Play();
        yield return new WaitForSeconds(particle.main.startLifetime.constantMax);
        Destroy(gameObject);
    }
}
