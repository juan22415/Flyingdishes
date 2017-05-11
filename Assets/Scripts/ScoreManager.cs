using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : Singleton<ScoreManager>
{
    public Text scoreText;
    private int score = 0;
    private int lifes = 3;

    public void AddScore(int value)
    {
        score += value;

        scoreText.text = "Score:" + score;

        if (score == 100)
        {
            Spawnermanager.Instance.maxtime = 3;
        }
        if (score == 200)
        {
            Spawnermanager.Instance.maxtime = 2;
        }
        if (score == 300)
        {
            Spawnermanager.Instance.maxtime = 1;
        }

        if (lifes == 0)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void LoseLifes(int value)
    {
        lifes -= value;
    }
}
