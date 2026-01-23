using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public static event Action<int> OnCoinCollected;

    private bool isGrounded;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            OnCoinCollected?.Invoke(10);

            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
