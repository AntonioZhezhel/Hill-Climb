using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform Target;
    private Vector3 Offset;

    void Start()
    {
        Offset = transform.position - Target.position;
    }

    void Update()
    {
        transform.position = Target.position + Offset; 
    }
}
