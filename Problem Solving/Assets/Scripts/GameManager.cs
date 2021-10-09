using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject prefab;

    private Vector2 position;

    private float lineX = 7f;
    private float lineY = 3f;
    // Start is called before the first frame update
    void Start()
    {
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

            position = new Vector2(randomPosX, randomPosY);

            Instantiate(prefab, position, Quaternion.identity);
        }
    }
}
