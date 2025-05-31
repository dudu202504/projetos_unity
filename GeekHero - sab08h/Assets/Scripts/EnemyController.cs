using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public int Vida = 3;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vida <=0)
        {
            Destroy(this.gameObject);
        }
    }




    private void OnTriggerEnter2D(Collider2D collision )
    {
        if(collision.gameObject.tag == "AttackHitBox")
        {
            Debug.Log("Dano no Inimigo");
            Vida = Vida - 1;
            Debug.Log (Vida);  
            
        }
        else if (collision.gameObject.tag == "DamageHitBox")
        {
            collision.GetComponentInParent<PlayerController>().hp -= 10; //causa dano no player
        }
               
        
    }
    
    
}
