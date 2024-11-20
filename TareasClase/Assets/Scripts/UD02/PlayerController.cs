using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3f;        // Velocidad de movimiento
    public float jumpForce = 5.5f;      // Fuerza del salto
    private Rigidbody rb;               // Referencia al Rigidbody
    private Animator animator;          // Referencia al Animator
    private bool isGrounded = true;     // Verifica si el jugador está en el suelo

    public GameObject flowerPrefab;     // Prefab de la flor
    public Transform shootPoint;        // Punto desde donde se dispara
    public float shootForce = 15f;      // Fuerza del disparo

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimiento horizontal y vertical 
        float moveX = Input.GetAxis("Horizontal") * moveSpeed;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed;

        // Aplicar movimiento
        Vector3 movement = new Vector3(moveX, rb.velocity.y, moveZ);
        rb.velocity = movement;

        // Actualiza animación de "Speed"
        float speed = new Vector3(moveX, moveZ).magnitude;
        animator.SetFloat("MoveSpeed", speed);

        // Detectar si está en el suelo
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1f);
        animator.SetBool("Grounded", isGrounded);

        // Saltar con la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; // Bloquea más saltos hasta que vuelva a tocar el suelo
            animator.SetBool("Grounded", false);
        }


        // Disparo al presionar clic izquierdo
        if (Input.GetMouseButtonDown(0))
        {
            ShootFlower();
        }

    }

    void ShootFlower()
    {
         // Instanciar la flor en el punto de disparo
         GameObject flower = Instantiate(flowerPrefab, shootPoint.position, Quaternion.identity);

         // Aplicar una fuerza en dirección parabólica
         Rigidbody rb = flower.GetComponent<Rigidbody>();
         Vector3 shootDirection = (transform.forward + Vector3.up * 0.25f).normalized; // Ajusta la parábola
         rb.AddForce(shootDirection * shootForce, ForceMode.Impulse);

         // Evitar acumulación
         Destroy(flower, 5f);
    }

        // Detectar si está en el suelo
        private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("Grounded", true);
        }

        // Detectar daño al chocar con enemigos
        if (collision.gameObject.CompareTag("Zombie"))
        {
            animator.SetTrigger("TakeDamage");
        }
    }

    // Detectar cuando el jugador deja de estar en contacto con el suelo
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false; // El jugador ya no está en el suelo
            animator.SetBool("Grounded", false); // Activar animación de estar en el aire
        }
    }
}