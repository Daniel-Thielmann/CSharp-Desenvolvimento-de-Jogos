using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 2f;
    public float maxDistance = 5f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float offset = Mathf.PingPong(Time.time * speed, maxDistance);
        transform.position = startPos + new Vector3(offset, 0, 0);
    }
}
