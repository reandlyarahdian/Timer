using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coin : MonoBehaviour
{
    public int coin = 100;
    [SerializeField] TextMeshProUGUI coinText;
    [SerializeField] Button coinButton;
    [SerializeField] Timer timer;
    [SerializeField] Demo demo;

    public void Start()
    {
        coinText.text = coin.ToString();
    }

    public void Coins()
    {
        if (demo.A1)
        {
            UsedCoin(5);
        }
        else if (demo.A2)
        {
            UsedCoin(10);
        }
        else if (demo.B1)
        {
            UsedCoin(15);
        }
        else if (demo.B2)
        {
            UsedCoin(20);
        }
    }

    public void UsedCoin(int c)
    {
        coin -= c;
        timer.SetRemainDuration(0);
        coinText.text = coin.ToString();
        if (coin == 0)
        {
            coinButton.interactable = false;
        }
    }
}
