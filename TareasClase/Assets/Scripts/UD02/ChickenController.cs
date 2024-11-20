using UnityEngine;

public class ChickenController : MonoBehaviour
{
    public GameObject eggPrefab; // Prefab del huevo
    public float moveSpeed = 1.5f; // Velocidad de la gallina

    void Update()
    {
        // Movimiento de la gallina 
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(moveX, 0, moveY);

        // Poner un huevo al hacer clic izquierdo
        if (Input.GetMouseButtonDown(0))
        {
            LayEgg();
        }
    }

    void LayEgg()
    {
        // Posición del huevo detrás de la gallina
        Vector3 eggPosition = transform.position + transform.forward * -0.22f + Vector3.down * -0.2f;

        // Crear una instancia del huevo en la posición calculada y con rotación estándar
        GameObject egg = Instantiate(eggPrefab, eggPosition, Quaternion.identity);

        // Rigidbody para que caiga al suelo
        Rigidbody eggRigidbody = egg.GetComponent<Rigidbody>();
        if (eggRigidbody == null)
        {
            eggRigidbody = egg.AddComponent<Rigidbody>();
        }

        // Ajustar propiedades del Rigidbody para evitar rebotes
        eggRigidbody.mass = 1f;            // Masa para estabilidad
        eggRigidbody.drag = 0.5f;          // Resistencia al movimiento
        eggRigidbody.angularDrag = 0.5f;   // Control del giro al caer
    }
}