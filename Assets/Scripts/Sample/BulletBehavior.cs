using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float speed = 3f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Enemy>())
        {
            Debug.Log("Choque con un enemigo");
        }
        gameObject.SetActive(false);
    }

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
