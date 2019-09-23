using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    [SerializeField] AudioClip sfx;
    [SerializeField] int score = 10;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().addToScore(score);
        AudioSource.PlayClipAtPoint(sfx, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
