using UnityEngine;
using TMPro;
public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;

    public int coins = 0;
    public TMP_Text coinText;

    private void Awake()
    {
        instance = this;
    }

    public void AddCoin(int amount)
    {
        coins += amount;
        coinText.text = coins.ToString();
    }
}

