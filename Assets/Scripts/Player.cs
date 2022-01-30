using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Vector3 _spawn;
    private int _wallet = 0;

    public Vector3 Die()
    {
        return _spawn;
    }

    public int TopUpWallet(int CountCoins)
    {
        _wallet += CountCoins;
        return _wallet;
    }
}
