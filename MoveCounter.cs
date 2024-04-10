using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveCounter : MonoBehaviour
{
    public int moveCount = 0;
    public TextMeshProUGUI move_count;
    public int maxMove;
    private void Awake()
    {
        CanvasRotate.OnMoveCount += IncrementMoveCount;
    }
    private void IncrementMoveCount()
    {
        moveCount += 1;
        move_count.text = moveCount.ToString();
    }
    public void StarsCounter () 
    {
        if (moveCount >= maxMove + 2 && !PlayerPrefs.HasKey("stars" + SceneManager.GetActiveScene().buildIndex))
            PlayerPrefs.SetInt("stars" + SceneManager.GetActiveScene().buildIndex, 1);

        else if ((moveCount <= maxMove + 2 && moveCount > maxMove)
            && (!PlayerPrefs.HasKey("stars" + SceneManager.GetActiveScene().buildIndex)
            || (PlayerPrefs.GetInt("stars" + SceneManager.GetActiveScene().buildIndex) < 2 )))
            PlayerPrefs.SetInt("stars" + SceneManager.GetActiveScene().buildIndex, 2);

        else if ((moveCount <= maxMove)
            && (!PlayerPrefs.HasKey("stars" + SceneManager.GetActiveScene().buildIndex)
            || (PlayerPrefs.GetInt("stars" + SceneManager.GetActiveScene().buildIndex) < 3)))
            PlayerPrefs.SetInt("stars" + SceneManager.GetActiveScene().buildIndex, 3);

        Debug.Log(PlayerPrefs.GetInt("stars" + SceneManager.GetActiveScene().buildIndex));
    }
}
