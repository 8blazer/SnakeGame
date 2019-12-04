using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    System.Random rnd = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int tempPos = rnd.Next(1, 145);
        int posX = (int)Mathf.Floor(tempPos / 8);
        int posY = (int)Mathf.Floor(tempPos / 18);
        transform.position = new Vector3(posX, posY, 0);
    }
}
