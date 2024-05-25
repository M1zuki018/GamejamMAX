using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float speed = 9.0f;

    void Update()
    {

        // Dキー（右移動）
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))

        {
            transform.position += speed * transform.right * Time.deltaTime;
        }

        // Aキー（左移動）
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))

        {
            transform.position -= speed * transform.right * Time.deltaTime;
        }
        transform.position = new Vector2(
     //エリア指定して移動する
     Mathf.Clamp(transform.position.x, -13.0f, 12.0f),
     Mathf.Clamp(transform.position.y, -10.8f, 10.5f)
     );
    }
}