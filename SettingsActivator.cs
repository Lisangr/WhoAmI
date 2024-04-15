using UnityEngine;

public class SettingsActivator : MonoBehaviour
{
    public GameObject panel;

    public void OnClick()
    { 
        panel.SetActive(true);
    }
}
