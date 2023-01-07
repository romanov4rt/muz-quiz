using TMPro;
using UnityEngine;

public class BestScoreText: MonoBehaviour
{
    [Header("BestScoring")]
    [SerializeField] TextMeshProUGUI bestScoreText;
    ScoreKeeper scoreKeeper;



    private void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        GetBestScoreText();
    }

    void GetBestScoreText()
    {
        bestScoreText.text = "Best score: " + scoreKeeper.MaxCorrectAnswers();
    }
}
