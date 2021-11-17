using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Animator anim;
    Vector2 lastClickedPos;
    bool moving;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                moving = true;
        }
        if (moving && (Vector2)transform.position != lastClickedPos)
        {
            float step = moveSpeed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
            anim.SetBool("Walk", true);
        }
        else
        {
            moving = false;
            anim.SetBool("Walk", false);

        }
    }
}
