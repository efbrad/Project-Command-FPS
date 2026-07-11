using UnityEngine;
using UnityEngine.InputSystem;

public class CLCameraController : MonoBehaviour
{
    public float Speed = 1.0f;
    public float ElevationSpeed = 1.0f;
    public Vector2 MinMaxElevation = new Vector2(10, 20);
    Vector2 movement;
    float zoom;
    bool clopen = false;


    private void FixedUpdate()
    {
        Move();
    }



    // Player Input Commands
    void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
    void OnOpenCommandLine()
    {
        clopen = !clopen;
    }
    void OnZoomIn()
    {
        zoom = -1;
        Zoom();
    }
    void OnZoomOut()
    {
        zoom = 1;
        Zoom();
    }




    // Movement
    void Move()
    {
        if (!clopen)
        {
            transform.position = new Vector3(transform.position.x + movement.x * Speed, transform.position.y, transform.position.z + movement.y * Speed);
        }
    }
    void Zoom()
    {
        if (!clopen)
        {
            if (zoom + transform.position.y < MinMaxElevation.y + 1 && zoom + transform.position.y > MinMaxElevation.x - 1)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + zoom, transform.position.z);
            }
        }
    }


}
