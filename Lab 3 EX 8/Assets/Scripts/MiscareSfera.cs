using UnityEngine;

public class MiscareSfera : MonoBehaviour
{
    public float fortaDeImpuls = 100;
    public Transform cameraTransform;
    public float fortaDeSaritura = 50;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float miscareOrizontala = Input.GetAxis("Horizontal");
        float miscareVerticala = Input.GetAxis("Vertical");

        // Obținem direcțiile camerei pe planul XZ
        Vector3 camFata = cameraTransform.forward;
        camFata.y = 0;
        camFata.Normalize();

        Vector3 camDreapta = cameraTransform.right;
        camDreapta.y = 0;
        camDreapta.Normalize();

        // Direcția finală combinată
        Vector3 directie = camFata * miscareVerticala + camDreapta * miscareOrizontala;

        rb.AddForce(directie * fortaDeImpuls);

        // Verificare dacă este pe pământ
        bool estePePamant = Physics.Raycast(transform.position, Vector3.down, 1.1f);

        // Săritură
        if (Input.GetKeyDown(KeyCode.Space) && estePePamant)
        {
            rb.AddForce(Vector3.up * fortaDeSaritura, ForceMode.Impulse);
        }
    }
}
