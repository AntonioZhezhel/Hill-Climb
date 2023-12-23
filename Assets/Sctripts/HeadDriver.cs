using UnityEngine;

public class HeadDriver : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D  collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            GameManager.RestartGame();
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            GameManager.RestartGame();
        }
    }
}
