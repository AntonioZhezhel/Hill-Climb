using UnityEngine;
using UnityEngine.U2D;

public class GroundGenerator : MonoBehaviour
{
    [SerializeField] private SpriteShapeController SpriteShapeController;
    
    [Range(3f, 100f)] [SerializeField] private int Lenght = 50;
    [Range(1f, 50f)] [SerializeField] private float xMultiplier = 2f;
    [Range(1f, 50f)] [SerializeField] private float yMultiplier = 2f;
    [Range(0f, 1f)] [SerializeField] private float CurveGroud = 50;
    [Range(0.2f, 2f)] [SerializeField] private float Scale = 1f;
    
    [SerializeField] private float Step = 0.5f;
    [SerializeField] private float Bottom = 10f;

    private Vector3 LastPoint;

    public void OnValidate()
    {
        SpriteShapeController.spline.Clear();

        for (int i = 0; i < Lenght; i++)
        {
            LastPoint = transform.position + new Vector3(i * xMultiplier, Mathf.PerlinNoise(0,i * Step) * yMultiplier, 0);
            SpriteShapeController.spline.InsertPointAt(i, LastPoint);

            if (i == 0 || i == Lenght - 1) continue;
            SpriteShapeController.spline.SetTangentMode(i, ShapeTangentMode.Continuous);
            SpriteShapeController.spline.SetLeftTangent(i, Vector3.left * xMultiplier * CurveGroud);
            SpriteShapeController.spline.SetRightTangent(i, Vector3.right * xMultiplier * CurveGroud);
        }
        
        SpriteShapeController.spline.InsertPointAt(Lenght, new Vector3(LastPoint.x, transform.position.y - Bottom, 0));
        SpriteShapeController.spline.InsertPointAt(Lenght +1, new Vector3(transform.position.x, transform.position.y - Bottom, 0));
        
        transform.localScale = Scale * Vector3.one;
    }
}
