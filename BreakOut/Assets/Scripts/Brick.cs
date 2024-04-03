using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] int hp = 1;
    public int score = 100;

    public AudioSource source;
    public AudioClip brickDestroy;


    public void Start()
    {
        source = GetComponent<AudioSource>();
    }
    public void Damage()
    {
        hp --;
        source.clip = brickDestroy;
        source.Play();
        if (hp<=0)
        {
            Destroy(gameObject);
            GameManager.score += score;
        }
    }
}
