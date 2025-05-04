using UnityEngine;

public class CameraFollowCub2 : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null) transform.position = target.position + offset;
    }
}
