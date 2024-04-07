using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartSceneOnChangeLevelScene : MonoBehaviour
{ 
/*public TextMeshProUGUI buttonNameText;
    public void StartScene()
    {
        string buttonName = buttonNameText.text;
        int indexStartingScene = int.Parse(buttonName);

        SceneManager.LoadScene(indexStartingScene, LoadSceneMode.Single);
    }*/
    public void StartScene()
    {
        TextMeshProUGUI buttonNameText = GetComponentInChildren<TextMeshProUGUI>();
        if (buttonNameText != null)
        {
            string buttonName = buttonNameText.text;
            int indexStartingScene;
            if (int.TryParse(buttonName, out indexStartingScene))
            {
                SceneManager.LoadScene(indexStartingScene+2);
            }
            else
            {
                Debug.LogError("Невозможно преобразовать текст кнопки в целое число.");
            }
        }
        else
        {
            Debug.LogError("Компонент TextMeshProUGUI не найден в дочерних объектах кнопки.");
        }
    }
}