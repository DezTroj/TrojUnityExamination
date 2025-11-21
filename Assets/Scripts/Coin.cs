using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            CoinManager.instance.AddCoin(1);
            Destroy(gameObject);
        }
    }
}
