using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject car;
    
    public bool gameOver;
    public int score;
    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gasText;
    
    void Awake()
    {
        Instance = this;
    }
    
    
    void Start()
    {
        StartCoroutine(Scoring());
    }

    void Update()
    {

    }

    public IEnumerator Scoring()
    {
        while (!gameOver)
        {
            yield return new WaitForSeconds(1f);
            score += 1;
            scoreText.text = $"Score: {score}";
        }
    }
}
