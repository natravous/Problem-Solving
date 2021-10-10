using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    private float timeSpawn = 3f;
    private float timer = 0;

    private BoxCollider2D boxCol;

    private bool isCollide;

    private void Awake()//
    {
        Debug.Log(isCollide);
        isCollide = false;
        boxCol = GetComponent<BoxCollider2D>();//
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCollide)
        {

            if (timer <= 0)
            {
                if (GameManager.Instance.check)
                {
                    Respawn();  
                }
                timer = timeSpawn;
            }
            else
            {
                timer -= Time.deltaTime;
               
            }
            //Debug.Log(timer);


        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ball")
        {
            isCollide = true;
            Score.scoreValue++;
            Debug.Log(Score.scoreValue);
            //Destroy(collision.gameObject);
            Debug.Log(isCollide);
            //gameObject.SetActive(false);

            boxCol.enabled = false;
            transform.localScale = Vector3.zero;
        }
    }

    

    public void Respawn()
    {
        gameObject.transform.position = GameManager.Instance.Position();//
        Debug.Log(isCollide + " respawn");
        transform.localScale = Vector3.one;
        boxCol.enabled = true;
        
        //gameObject.SetActive(true);
        
        isCollide = false;
    }


}
