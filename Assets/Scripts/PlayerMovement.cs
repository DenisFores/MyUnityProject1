using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float move = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * move * speed * Time.deltaTime);

        anim.SetBool("isMoving", move != 0);
    }
}