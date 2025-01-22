using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public enum RoadPosition
{
    LEFT,
    MIDDLE,
    RIGHT
}

public class Car : MonoBehaviour
{
    [NonSerialized] public RoadPosition roadPosition;

    public int gas;

    void Awake()
    {
        gas = 100;
    }
    
    void Start()
    {
        StartCoroutine(UseGas());
    }

    void Update()
    {
        if (gas <= 0)
        {
            GameManager.Instance.gameOver = true;
            Destroy(gameObject);
        }
    }

    IEnumerator UseGas()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            gas -= 10;
            GameManager.Instance.gasText.text = $"Gas: {gas}";
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(1);
        if (other.CompareTag("Gas"))
        {
            gas += 30;
            Destroy(other.gameObject);
        }
    }
}


