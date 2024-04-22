using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private MoveCounter m_MoveCounter;
    private void Awake()
    {
        m_MoveCounter = FindAnyObjectByType<MoveCounter>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            UnLockLevel();
            m_MoveCounter.StarsCounter();
            LoadNextLevel();            
        }
    }
    /*public void LoadNextLevel()
    {
        SceneManager.LoadScene("ChangeLevel");
    }   */ 
    public void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
    public void UnLockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels", currentLevel+1);
        }
    }
}
