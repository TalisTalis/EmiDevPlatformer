using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.5f;
    public float force;
    public Rigidbody2D rg;

    // Update is called once per frame
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
    }
}
