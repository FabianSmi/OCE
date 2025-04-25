using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody m_rb;
    [SerializeField][Range(0,10)] private float speed;

    private void Awake()
    {
        m_rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        m_rb.linearVelocity = new Vector3(direction.x, 0, direction.y) * speed;
    }

}
