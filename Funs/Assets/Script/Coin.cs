using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    private int coin = 0;

    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Coin")
        {
            coin ++;
            textCoins.text = coin.ToString();
            Destroy(other.gameObject);
        }

    }

}
