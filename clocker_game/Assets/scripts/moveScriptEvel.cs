using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScriptEvel : MonoBehaviour
{
    bool InTrigger = false;
    public float live;
    public float speed;
    private clicker click; 
   
   private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // float movement = Input.GetAxis("Horizontal");
        // transform.position -= new Vector3(speed,0 ,0);
        rb.velocity = new Vector2(speed, 0);
        if (InTrigger){
            live -= 1;
            if (live < 0){
            Destroy(gameObject);
            click = FindObjectOfType<clicker>();
            click.addNum(7);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D player){
        
        if (player.CompareTag("Player")){
            InTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D player ){
         if (player.CompareTag("Player")){
             InTrigger = false;
        }
       
    }
}
