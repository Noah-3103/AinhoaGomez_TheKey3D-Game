using UnityEngine;
using UnityEngine.UI;

public class Collectable_Controller : MonoBehaviour
{
    public int coinsCollected = 0;
    public Transform collectableCount;
    public void AddCoin()
    {
        coinsCollected++;

        Debug.Log("Monedas recogidas: " + coinsCollected);

        if (coinsCollected < collectableCount.childCount)
        {
            Image coinImage = collectableCount.GetChild(coinsCollected - 1).GetComponent<Image>();

            coinImage.color = Color.white;
        }
    }
}