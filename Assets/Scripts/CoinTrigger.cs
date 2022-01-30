using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    private int Coin = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            ScoreCountCoins.Score = player.TopUpWallet(Coin);
            Destroy(gameObject);
        }
    }
}
