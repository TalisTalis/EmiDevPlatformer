using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.5f;
    public float force;
    public Rigidbody2D rg;
    public float minimalHeight;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rg.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }

        if (transform.position.y < minimalHeight)
        {
            rg.velocity = new Vector2(0, 0);
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
