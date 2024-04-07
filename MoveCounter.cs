using TMPro;
using UnityEngine;

public class MoveCounter : MonoBehaviour
{
    public int moveCount = 0;
    public TextMeshProUGUI move_count;
    private void Awake()
    {
        CanvasRotate.OnMoveCount += IncrementMoveCount;
    }
    private void IncrementMoveCount()
    {
        moveCount += 1;
        move_count.text = moveCount.ToString();
    }
}
