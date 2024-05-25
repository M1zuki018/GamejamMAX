using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float speed = 7.0f;

    void Update()
    {

        // D�L�[�i�E�ړ��j
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))

        {
            transform.position += speed * transform.right * Time.deltaTime;
        }

        // A�L�[�i���ړ��j
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))

        {
            transform.position -= speed * transform.right * Time.deltaTime;
        }
        transform.position = new Vector2(
     //�G���A�w�肵�Ĉړ�����
     Mathf.Clamp(transform.position.x, -7.0f, 7.0f),
     Mathf.Clamp(transform.position.y, -3.35f, 3.35f)
     );
    }
}