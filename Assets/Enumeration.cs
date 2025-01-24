using UnityEngine;

public class Enumeration : MonoBehaviour
{
 
    public enum Direction
    {
        Left,
        Right,
        Up,
        Down,
        Front,
        Back
    }

    [SerializeField] private Direction direction;

    [SerializeField] private float speed;

    void Update()
    {
        Vector3 movement = Vector3.zero;

        switch (direction)
        {
            case Direction.Left:
                movement = Vector3.left; 
                break;
            case Direction.Right:
                movement = Vector3.right;
                break;
            case Direction.Up:
                movement = Vector3.up; 
                break;
            case Direction.Down:
                movement = Vector3.down;
                break;
            case Direction.Front:
                movement = Vector3.forward; 
                break;
            case Direction.Back:
                movement = Vector3.back; 
                break;
        }

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
