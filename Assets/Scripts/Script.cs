using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Script : MonoBehaviour
{
    static Pos right = new Pos(1, 0), left = new Pos(-1, 0), up = new Pos(0, 1), down = new Pos(0, -1);
    class Snake
    {
        public GameObject[] body;
        public GameObject[] spine;
        public Pos[] direction;
        public Pos futuredirection;
        public Snake(GameObject[] body, GameObject[] spine, Pos[] direction, Pos futuredirection)
        {
            this.body = body;
            this.spine = spine;
            this.direction = direction;
            this.futuredirection = futuredirection;
        }
    }
    class Pos
    {
        public float x;
        public float y;
        public Pos(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
    void Start()
    {
        InvokeRepeating("Cadr", 0f, 0.25f);
        GameObject Head = GameObject.Find("Head"), Body = GameObject.Find("Body"), Bone = GameObject.Find("Bone"), Apple = GameObject.Find("Apple");
    }
    void FixedUpdate()
    {
        //if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        //    snake.futuredirection = up;
        //if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        //    snake.futuredirection = down;
        //if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        //    snake.futuredirection = right;
        //if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        //    snake.futuredirection = left;
    }
    void moveSnake()
    {

    }
    void drawSnake()
    {

    }
    void Cadr()
    {
        moveSnake();
        drawSnake();
    }
}
