using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int targetScore = 3;
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        UpdateScoreText();
    }
    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
