using UnityEngine;

public class CanvasRotate : MonoBehaviour
{
    public Canvas canvas;

    public delegate void MoveAction();
    public static event MoveAction OnMoveCount;

    public void RotateToTheLeft()
    {
        canvas.transform.Rotate(Vector3.forward, 90f);
        OnMoveCount?.Invoke();
    }
    public void RotateToTheRight() 
    {
        canvas.transform.Rotate(Vector3.forward, -90f);
        OnMoveCount?.Invoke();
    }

}
