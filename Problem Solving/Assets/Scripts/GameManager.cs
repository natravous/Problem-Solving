using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{//
    private static GameManager instance = null;//
    public static GameManager Instance//
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }


    public GameObject prefab;

    private Vector2 position;

    public bool check = true;

    public Transform ball;//

    private float lineX = 7f;
    private float lineY = 3f;
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Transform>();//
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        int randomSum = Random.Range(4, 8);
        

        for(int i = 0; i < randomSum; i++)
        {
            float randomPosX = Random.Range(-lineX, lineX);
            float randomPosY = Random.Range(-lineY, lineY);
            //
            position = Position();//

            Instantiate(prefab, position, Quaternion.identity);
        }
    }

    public Vector2 Position()//
    {

        Vector2 position = new Vector2();
        bool check = false;

        while(!check)
        {
            float randomPosX = Random.Range(-lineX, lineX);
            float randomPosY = Random.Range(-lineY, lineY);

            position = new Vector2(randomPosX, randomPosY);

            float dist = Vector2.Distance(position, ball.position);

            if(dist > 1)
            {
                check = true;
            }
        }

        return position;
    }
}
