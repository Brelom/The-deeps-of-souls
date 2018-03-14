using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float MoveSpeed = 10f;
    Vector3 newPosition;

    void Start()
    {
        newPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                //  Creating new postion by mouse button Click.
                //  Then moving player towards that position while mouse button is pressed
                newPosition = hit.point;
                transform.position = Vector3.MoveTowards(transform.position, newPosition, MoveSpeed * Time.deltaTime);
            }
        }
    }
}
