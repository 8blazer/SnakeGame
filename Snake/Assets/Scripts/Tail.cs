using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Tail : MonoBehaviour
{
    float timer = 0;
    int length;
    // Start is called before the first frame update
    void Start()
    {
        length = Snake.snakeLength;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > (length / 3))
        {
            Destroy(gameObject);
        }
        if (Snake.snakeLength != length)
        {
            length = Snake.snakeLength;
        }
    }
}
