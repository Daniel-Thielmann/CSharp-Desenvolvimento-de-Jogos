using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("Game Over!");
            Destroy(player);
        }
    }
}
