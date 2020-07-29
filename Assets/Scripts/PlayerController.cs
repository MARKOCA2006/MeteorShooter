using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private void Start()
    {
        transform.position = new Vector2(-8, 0);
    }

    private Vector2 pos;
    public float power;
    public float speed;
    public float height;
    public int health;
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, pos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < height)
            pos = new Vector2(transform.position.x, transform.position.y + power);
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > -height)
            pos = new Vector2(transform.position.x, transform.position.y - power);
        else if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < height)
            pos = new Vector2(transform.position.x, transform.position.y + power);
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > -height)
            pos = new Vector2(transform.position.x, transform.position.y - power);
    }
}
