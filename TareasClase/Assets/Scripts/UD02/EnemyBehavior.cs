using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public void TakeHit()
    {
        Destroy(gameObject); // Destruir enemigo al ser golpeado
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Flower"))
        {
            TakeHit();
        }
    }
}