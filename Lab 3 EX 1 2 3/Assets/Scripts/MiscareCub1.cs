using UnityEngine;

public class MiscareCub1 : MonoBehaviour
{
    public float viteza = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.Translate(Vector3.right * viteza);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * viteza);
    }
}
