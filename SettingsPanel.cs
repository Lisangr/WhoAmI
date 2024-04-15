using UnityEngine;

public class SettingsPanel : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0 || Input.GetKey("Escape"))    
        {
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // ��� ��������� ��������� ����������� Input.GetTouch(0).position
            if (!RectTransformUtility.RectangleContainsScreenPoint(GetComponent<RectTransform>(), clickPosition))
            {
                gameObject.SetActive(false);
            }
        }
    }
}

