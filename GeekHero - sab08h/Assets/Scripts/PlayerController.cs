using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public Rigidbody2D Rb;
    public Animator anim;
    public Image Heart; 
    public float hp;
    public float maxHp = 100f;
    public float MoveX, MoveY;
    private bool isMoving;
  
    // Start is called before the first frame update
    void Start()
    {
       anim = GetComponent<Animator>();
        
        hp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        MoveX = Input. GetAxisRaw("Horizontal"); 
         MoveY = Input.GetAxisRaw("Vertical");
    
        
        Move();
        Animation();
        Attack();
        Debug.Log(hp);
    
    
    }
    void UpdateUI()
    {
        Heart.fillAmount = hp / maxHp;
    }

    void Move()
    {
        Vector3 Direcao = new Vector3(MoveX,MoveY, 0);
        Rb.MovePosition(transform.position + Direcao * MoveSpeed * Time.deltaTime);

    }   



    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("isAttack");
        }
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
