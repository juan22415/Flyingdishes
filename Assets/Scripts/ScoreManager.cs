using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : Singleton<ScoreManager>
{
    public Text scoreText;
    private int score = 0;
    private int lifes = 3;
    private void Update()
    {
        if (Nolifes())
        {
            SceneManager.LoadScene(1);
        }
    }
    public void AddScore(int value)
    {
        score += value;

        scoreText.text = "" + score;
        switch (score)
        {
            case 100:
                Spawnermanager.Instance.maxtime = 3;
                break;
            case 200:
                Spawnermanager.Instance.maxtime = 2.8f;
                break;
            case 300:
                Spawnermanager.Instance.maxtime = 2.7f;
                break;
            case 400:
                Spawnermanager.Instance.maxtime = 2.6f;
                break;
            case 500:
                Spawnermanager.Instance.maxtime = 2.5f;
                break;
            default:
                break;
        }


      
    }
    public bool Nolifes()
    {
       
        if(lifes==0)
        {
            return true;
        }
        return false;
    }
    public void LoseLifes(int value)
    {
        lifes -= value;
    }
}
