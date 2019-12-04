using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Snake : MonoBehaviour
{
    int moveDir = 2; //1 = up, 2 = right
    public static int snakeLength = 3;
    public GameObject prefab;
    public float moveTick = .25f;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > moveTick)
        {
            timer = 0;
            if (moveDir == 1)
            {
                Instantiate(prefab, transform.position, Quaternion.identity);
                transform.position = transform.position + new Vector3(0, 1, 0);
            }
            else if (moveDir == 2)
            {
                Instantiate(prefab, transform.position, Quaternion.identity);
                transform.position = transform.position + new Vector3(1, 0, 0);
            }
            else if (moveDir == 3)
            {
                Instantiate(prefab, transform.position, Quaternion.identity);
                transform.position = transform.position + new Vector3(0, -1, 0);
            }
            else if (moveDir == 4)
            {
                Instantiate(prefab, transform.position, Quaternion.identity);
                transform.position = transform.position + new Vector3(-1, 0, 0);
            }
        }
        if (Input.GetKeyDown("w") || Input.GetKeyDown("up"))
        {
            moveDir = 1;
        }
        if (Input.GetKeyDown("d") || Input.GetKeyDown("right"))
        {
            moveDir = 2;
        }
        if (Input.GetKeyDown("s") || Input.GetKeyDown("down"))
        {
            moveDir = 3;
        }
        if (Input.GetKeyDown("a") || Input.GetKeyDown("left"))
        {
            moveDir = 4;
        }
    }
}
