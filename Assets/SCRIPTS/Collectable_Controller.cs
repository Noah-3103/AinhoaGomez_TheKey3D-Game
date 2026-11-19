using UnityEngine;

public class Collectable_Controller : MonoBehaviour
{
    public int coinsCollected = 0;

    public void AddCoin()
    {
        coinsCollected++;

        Debug.Log("Monedas recogidas: " + coinsCollected);
    }
}