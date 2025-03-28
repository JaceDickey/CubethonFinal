using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 1.8f;
    public GameObject completeLevelUI;
    
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        BackgroundSound.offRun = true;
        BackgroundSound.offEnemy = true;
        BackgroundSound.offBuzz = true;
        BackgroundSound.onEnd = true;
    }
    
    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;

            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
