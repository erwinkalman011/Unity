using UnityEngine;

public class MiscareSfera : MonoBehaviour
{
    public float fortaDeImpuls = 10f;
    private Rigidbody rb;
    private float miscareOrizontala;
    private float miscareVerticala;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        miscareOrizontala = Input.GetAxis("Horizontal");
        miscareVerticala = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector3 directie = new Vector3(miscareOrizontala, 0f, miscareVerticala);
        rb.AddForce(directie * fortaDeImpuls);
    }
}
