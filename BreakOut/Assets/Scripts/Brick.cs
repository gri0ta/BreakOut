using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using DG.Tweening;


public class Brick : MonoBehaviour
{
    [SerializeField] int hp = 1;
    public int score = 100;

    public AudioSource source;
    public AudioClip brickDestroy;


    public void Start()
    {
        source = GetComponent<AudioSource>();

        transform.DOScale(Vector3.one,1f).ChangeStartValue(Vector3.zero).SetDelay(Random.Range(0f,1f)).SetEase(Ease.OutExpo);
        

        //transform.DORotate(new Vector3(0,0,90f),1f);
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
