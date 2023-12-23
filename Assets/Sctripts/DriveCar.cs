using UnityEngine;

public class DriveCar : MonoBehaviour
{
    [SerializeField] private Rigidbody2D FrontWheel;
    [SerializeField] private Rigidbody2D BackWheel;
    [SerializeField] private float Speed = 150f;
    
    private float MoveInput;
    
    private void FixedUpdate()
    {
        FrontWheel.AddTorque(-MoveInput * Speed * Time.fixedDeltaTime);
        BackWheel.AddTorque(-MoveInput * Speed * Time.fixedDeltaTime);
    }
    
    public void Brake() 
    {
        MoveInput = -1f;
    }
    
    public void Gus()
    {
        MoveInput = 1f;
    }

    public void Released()
    {
        MoveInput = 0f;
    }
}
