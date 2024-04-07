using UnityEngine;

public class CanvasRotate : MonoBehaviour
{
public Canvas canvas;

    public void RotateToTheLeft()
    {
        canvas.transform.Rotate(Vector3.forward, 90f);
    }
    public void RotateToTheRight() 
    {
        canvas.transform.Rotate(Vector3.forward, -90f);
    }
}
