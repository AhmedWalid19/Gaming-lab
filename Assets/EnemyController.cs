using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float maxSpeed = 2;
    public int damage = 1;
    public SpriteRenderer sr;
    void Start()
    {

        sr = GetComponent<SpriteRenderer>();
     
    }

    public void Flip(){
        sr.flipX=!sr.flipX;
    }

    void OnTriggerEnter2D(Collider2D other){

        if(other.tag == "Player"){
            FindObjectOfType<playerState>().Takedamage(damage);
            Flip();
        }
        else if (other.tag == "Wall"){
            Flip();
        }
    }
    void Update()
    {
        
    }
}



