using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Script : MonoBehaviour
{
    static Pos right = new Pos(1, 0), left = new Pos(-1, 0), up = new Pos(0, 1), down = new Pos(0, -1);
    Snake snake;
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
        GameObject Head = GameObject.Find("Head"), Body = GameObject.Find("Body"), Bone = GameObject.Find("Bone"), Apple = GameObject.Find("Apple");
        GameObject[] alfa = { Instantiate(Head), Instantiate(Body), Instantiate(Body), Instantiate(Body) }, beta = { Instantiate(Bone), Instantiate(Bone), Instantiate(Bone) };//Add start position
        Pos[] gamma = { right, right, right };
        Pos delta = right;
        snake = new Snake(alfa, beta, gamma, delta);
        InvokeRepeating("Cadr", 0f, 0.250f);
    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            snake.futuredirection = up;
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            snake.futuredirection = down;
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            snake.futuredirection = right;
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            snake.futuredirection = left;
    }
    void Cadr()
    {
        for(int i = snake.body.Length - 1; i > 0; i--)
            snake.body[i].transform.position = snake.body[i - 1].transform.position;
        snake.body[0].transform.position = new Vector3(snake.body[0].transform.position.x + snake.futuredirection.x, snake.body[0].transform.position.y + snake.futuredirection.y, 0f);
        for (int i = snake.direction.Length - 1; i >= 0; i--)
            snake.spine[i].transform.position = new Vector3(snake.body[i].transform.position.x + snake.direction[i].x, snake.body[i].transform.position.y + snake.direction[i].y, 0f);
    }
}