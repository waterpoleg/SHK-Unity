using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private EnemyCounter _enemyCounter;
    [SerializeField] private GameObject _endScreen;

    private void ShowEndScreen()
    {
        _endScreen.SetActive(true);
    }

    private void OnEnable()
    {
        _enemyCounter.AllEnemiesDied += ShowEndScreen;
    }

    private void OnDisable()
    {
        _enemyCounter.AllEnemiesDied -= ShowEndScreen;
    }
}
