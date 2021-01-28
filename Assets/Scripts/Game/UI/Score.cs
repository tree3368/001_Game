using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _score;
    [SerializeField] private Ball _ball;

    private void OnEnable()
    {
        _ball.NumberCoinsChanged += OnCoinsAdded;
    }

    private void OnDisable()
    {
        _ball.NumberCoinsChanged -= OnCoinsAdded;
    }

    private void OnCoinsAdded(int numberCoins)
    {
        _score.text = numberCoins.ToString();
    }
}
