using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AsinLoad : MonoBehaviour
{
    public Slider slider;
    public string Scene = "";
    void Start()
    {
        //StartCoroutine(LoadNextScene());
        LoadNextScene();
    }

    private void LoadNextScene() //IEnumerator
    {
        SceneManager.LoadScene(Scene, LoadSceneMode.Single);
        /*
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        
        AsyncOperation oper = SceneManager.LoadSceneAsync(nextSceneIndex);

        while (!oper.isDone)
        {
            float progress = oper.progress / 0.9f;
            slider.value = progress;
            yield return null;
        }*/
    }
}
