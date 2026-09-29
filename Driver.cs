using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float rotationSpeed = 720f;

    public Rigidbody2D rb;
    
    private float steerInput;
    private float moveInput;

    void Start()
    {
        //Memanggil rb
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //ini adalah bagian dimana mobil dapat bergerak setelah menekan tombol wasd atau panah
        //menggunakan GetAxis daripada GetAxisRaw agar pergerakan menjadi lebih smooth
        steerInput = Input.GetAxis("Horizontal");
        moveInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        //ini adalah code yang dipanggil berdasarkan waktu interval tetap, cocok untuk physics objek
        rb.linearVelocity = transform.up * moveInput * moveSpeed;

        if(moveInput != 0)
        {
            float rotation = -steerInput * rotationSpeed * Time.fixedDeltaTime;

            transform.Rotate(0f, 0f, rotation);
        }
    }

}
