using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int correctAnswers = 0;
    int _questionsSeen = 0;
    public int mCA;

    private void Update()
    {
        if (PlayerPrefs.HasKey("high"))
        {
            mCA = PlayerPrefs.GetInt("high");
        }
    }

    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }

    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
    }

    public int GetQuestionSeen()
    {
        return _questionsSeen;
    }

    public void IncrementQuestionsSeen()
    {
        _questionsSeen++;
    }

    public int CalculateScore()
    {
        return correctAnswers;
    }

    public int MaxCorrectAnswers()
    {
        if (correctAnswers > mCA)
        {
            PlayerPrefs.SetInt("high", correctAnswers);
            PlayerPrefs.Save();
        }
        return PlayerPrefs.GetInt("high");
    }
}

