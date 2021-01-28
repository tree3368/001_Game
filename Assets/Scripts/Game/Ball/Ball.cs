﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    private int _numberCoins = 0;

    public event UnityAction<int> NumberCoinsChanged;
    public event UnityAction Crashed;

    public void IncreaseCoinCount()
    {
        _numberCoins++;
        NumberCoinsChanged?.Invoke(_numberCoins);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Coin coin))
        {
            coin.gameObject.SetActive(false);
            IncreaseCoinCount();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Spike spike))
            Crashed?.Invoke();
    }
}
