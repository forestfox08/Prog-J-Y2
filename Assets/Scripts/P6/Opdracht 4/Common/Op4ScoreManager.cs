using UnityEngine;
public class Op4ScoreManager : MonoBehaviour
{
    private int score = 0;

    private void OnEnable()
    {
        Player.OnCoinCollected += AddScore;
    }

    private void OnDisable()
    {
        Player.OnCoinCollected -= AddScore;
    }

    private void AddScore(int number)
    {
        score += number;
        Debug.Log("Current Score: " + score);
    }
}
