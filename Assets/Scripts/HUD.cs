using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] private AlienController alienController;
    [SerializeField] private TextMeshProUGUI coinCounter;

    private void Awake()
    {
        alienController.OnCoinCollected += CollectCoin;
    }

    public void CollectCoin(int curCoins)
    {
        coinCounter.text = "Coins Collected: " + curCoins.ToString();
    }
}