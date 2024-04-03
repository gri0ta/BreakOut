using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static int score;

    public GameObject winScreen;
    public GameObject loseScreen;

    public TMP_Text hpText;
    public TMP_Text scoreText;

    public AudioSource source;
    public AudioClip winSound;

    public void Start()
    {
        source = GetComponent<AudioSource>();
    }
    public void Update()
    {
        hpText.text = "Lives: " + lives;
        scoreText.text = "Score : " + score;

        var count = FindObjectsOfType<Brick>().Length;

        if (count<=0)
        {
            winScreen.SetActive(true);
            source.clip = winSound;
            source.Play();
            hpText.enabled= false;
            scoreText.enabled= false;
            enabled= false;
        }

        if (lives<=0)
        {
            loseScreen.SetActive(true);
            hpText.enabled = false;
            scoreText.enabled = false;
            enabled = false;
        }
    }
}
