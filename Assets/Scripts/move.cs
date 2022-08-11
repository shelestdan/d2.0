using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    private Vector3 TPosition;
    private bool isMoving = false;
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            TPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            TPosition.z = transform.position.z;
            isMoving = true;
        }
        else if (Input.GetMouseButton(1))
        {
            isMoving = false;
        }
        if (isMoving)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, TPosition);
            transform.position = Vector3.MoveTowards(transform.position, TPosition, speed * Time.fixedDeltaTime);
            if (transform.position == TPosition)
                isMoving = false;
        }
    }
}