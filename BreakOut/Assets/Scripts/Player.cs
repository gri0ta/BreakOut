using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //builder pattern - per taskeli
        transform.DOScale(Vector3.one *1.5f,0.1f).SetEase(Ease.OutBounce).SetDelay(1f); //tween
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") *speed,0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.DOScale(new Vector3(1.5f,1.5f,1.5f),0.1f).SetEase(Ease.OutBounce).SetLoops(2,LoopType.Yoyo).ChangeStartValue(Vector3.one);
    }
}
