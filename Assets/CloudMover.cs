using UnityEngine;

public class CloudMover : MonoBehaviour
{

    public float moveSpeed = 2f;
    public float deadZone = -15f; //Adjust accordingly

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
