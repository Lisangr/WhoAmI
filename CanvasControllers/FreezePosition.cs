using UnityEngine;

public class FreezePosition : MonoBehaviour
{
    private bool isFrozen = false;
    private Rigidbody2D rigidbodyPlayer, rigidbodySupport;

    private void Awake()
    {
        rigidbodyPlayer = FindObjectOfType<Player>().GetComponent<Rigidbody2D>();
        rigidbodySupport = FindObjectOfType<PlayerSupport>().GetComponent<Rigidbody2D>();
    }
    public void ToggleFreezePlayer()
    {
        Freeze(rigidbodyPlayer);
    }
    public void ToggleFreezeSupport()
    {
        Freeze(rigidbodySupport);
    }

    private void Freeze(Rigidbody2D rigidbody)
    {
        isFrozen = !isFrozen;
        if (isFrozen)
        {
            rigidbody.gravityScale = 0f;
            rigidbody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        }
        else
        {
            rigidbody.constraints = RigidbodyConstraints2D.None;
            rigidbody.constraints = RigidbodyConstraints2D.FreezePositionX;
            rigidbody.constraints &= ~RigidbodyConstraints2D.FreezePositionY;
            rigidbody.gravityScale = 1f;
        }
    }
}
