using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Script : MonoBehaviour
{
    public GameObject Head, Body, Bone, Apple;
    static Pos right = new Pos(1, 0), left = new Pos(-1, 0), up = new Pos(0, 1), down = new Pos(0, -1);
    static Pos[] alfa = { new Pos(2f, 3f), new Pos(3f, 3f), new Pos(4f, 3f), new Pos(5f, 3f) },
        beta = { new Pos(2.5f, 3f), new Pos(3.5f, 3f), new Pos(4.5f, 3f) },
        gamma = { right, right, right, right };
    static Pos delta = right;
    Snake snake = new Snake(alfa, beta, gamma, delta);
    Timer timer = new Timer(250);
    class Snake
    {
        public Pos[] body;
        public Pos[] spine;
        public Pos[] direction;
        public Pos futuredirection;
        public Snake(Pos[] body, Pos[] spine, Pos[] direction, Pos futuredirection)
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
    private void Start()
    {
        timer.AutoReset = true;
        timer.Enabled = true;
        timer.Start();
        GameObject apple = Instantiate(Apple, Apple.transform.position, Apple.transform.rotation);
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
            snake.futuredirection = up;
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
            snake.futuredirection = down;
        if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
            snake.futuredirection = right;
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
            snake.futuredirection = left;
    }
    void moveSnake()
    {

    }
    void drawSnake()
    {

    }
}
