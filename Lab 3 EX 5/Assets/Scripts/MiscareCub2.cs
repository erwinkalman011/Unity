using UnityEngine;

public class MiscareCub2 : MonoBehaviour
{
    public float viteza = 2f;
    public float distantaMaxima = 3f;

    private Vector3 pozInitiala;
    private int directie = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pozInitiala = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * viteza * directie * Time.deltaTime);
        float distantaCurenta = Vector3.Distance(transform.position, pozInitiala);

        if (distantaCurenta >= distantaMaxima)
        {
            directie *= -1;
        }
    }
}
