using UnityEngine;

public class SomethingActivate : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            ActivatePlatform();
        }
    }
    public void ActivatePlatform()
    {
        ActivePlatform activePlatform = FindObjectOfType<ActivePlatform>();
        if (activePlatform != null)
        {
            Animator animator = activePlatform.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetTrigger("Activate");
            }
        }
    }
}
