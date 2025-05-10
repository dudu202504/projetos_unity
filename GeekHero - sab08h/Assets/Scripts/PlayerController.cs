using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public Rigidbody2D Rb;
    public Animator anim;

    public float MoveX, MoveY;
    private bool isMoving;
  
    // Start is called before the first frame update
    void Start()
    {
       anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveX = Input. GetAxisRaw("Horizontal"); 
         MoveY = Input.GetAxisRaw("Vertical");
        
        
        Move();
        Animation();
    }


    void Move()
    {
        Vector3 Direcao = new Vector3(MoveX,MoveY, 0);
        Rb.MovePosition(transform.position + Direcao * MoveSpeed * Time.deltaTime);

    }   

    void Animation()
    {

        
        if (MoveX== 0 && MoveY == 0)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }

    
        anim.SetBool("isMoving", isMoving);

        anim.SetFloat("HORIZONTAL", MoveX);
        anim.SetFloat("VERTICAL",MoveY);
    }


}
