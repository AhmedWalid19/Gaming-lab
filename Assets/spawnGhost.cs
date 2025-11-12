using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGhost : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform enemy;
    public Transform spawnpoint;    


    void RespawnEnemy()
    {
        Instantiate(enemy,spawnpoint.transform.position, spawnpoint.transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag =="Player")
        {
            RespawnEnemy()  ;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
