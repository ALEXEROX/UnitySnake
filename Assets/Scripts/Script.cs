using UnityEngine;
using System;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    static Pos right = new Pos(1, 0), left = new Pos(-1, 0), up = new Pos(0, 1), down = new Pos(0, -1);
    public Text text;
    ushort pos = 0;
    Snake snake;
    GameObject Apple, Head, Body, Bone;
    Pos[] route = {up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up,
        right, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down,
        right, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up,
        right, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down,
        right, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up,
        right, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down,
        right, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up,
        right, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down,
        right, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up,
        right, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down,
        right, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up,
        right, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down,
        right, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up,
        right, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down,
        right, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up,
        right, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down,
        right, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up,
        right, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down,
        right, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up,
        right, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down,
        right, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up,
        right, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down,
        right, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up,
        right, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down,
        right, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up,
        right, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down,
        right, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up,
        right, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down,
        right, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up, up,
        right, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down, down,
        left, left, left, left, left, left, left, left, left, left, left, left, left, left,
        left, left, left, left, left, left, left, left, left, left, left, left, left, left, left,
        up, up, up};
    System.Random r = new System.Random();
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
        Application.targetFrameRate = 60;
        Head = GameObject.Find("Head");
        Body = GameObject.Find("Body");
        Bone = GameObject.Find("Bone");
        Apple = GameObject.Find("Apple");
        GameObject[] alfa = { Instantiate(Head, new Vector3(0f, 3f, 0f), Head.transform.rotation) , Instantiate(Body, new Vector3(0f, 2f, 0f), Body.transform.rotation), Instantiate(Body, new Vector3(0f, 1f, 0f), Body.transform.rotation), Instantiate(Body, new Vector3(0f, 0f, 0f), Body.transform.rotation) },
            beta = { Instantiate(Bone, new Vector3(0f, 2.5f, 0f), new Quaternion(0f, 0f, 90f, 90f)), Instantiate(Bone, new Vector3(0f, 1.5f, 0f), new Quaternion(0f, 0f, 90f, 90f)), Instantiate(Bone, new Vector3(0f, 0.5f, 0f), new Quaternion(0f, 0f, 90f, 90f)) };
        Pos[] gamma = { up, up, up };
        Pos delta = up;
        snake = new Snake(alfa, beta, gamma, delta);
        DrawApple();
        InvokeRepeating("Cadr", 0f, 0.025f);
    }
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        //    if(snake.direction[0]!=down)
        //    snake.futuredirection = up;
        //if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        //    if (snake.direction[0] != up)
        //        snake.futuredirection = down;
        //if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        //    if (snake.direction[0] != left)
        //        snake.futuredirection = right;
        //if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        //    if (snake.direction[0] != right)
        //        snake.futuredirection = left;
        if (Input.GetKeyDown(KeyCode.R))
        {
            for(int i = 0; i < snake.body.Length; i++)
                Destroy(snake.body[i]);
            for (int i = 0; i < snake.spine.Length; i++)
                Destroy(snake.spine[i]);
            CancelInvoke("Cadr");
            text.text = "";
            Start();
        }
    }
    void Cadr()
    {
        snake.futuredirection = route[pos];
        if (snake.body[0].transform.position.x + snake.futuredirection.x == Apple.transform.position.x && snake.body[0].transform.position.y + snake.futuredirection.y == Apple.transform.position.y)
        {
            Array.Resize(ref snake.body, snake.body.Length + 1);
            Array.Resize(ref snake.spine, snake.spine.Length + 1);
            Array.Resize(ref snake.direction, snake.direction.Length + 1);
            snake.body[snake.body.Length - 1] = Instantiate(Body, snake.body[snake.body.Length - 2].transform.position, Head.transform.rotation);
            snake.spine[snake.spine.Length - 1] = Instantiate(Bone, snake.spine[snake.spine.Length - 2].transform.position, snake.spine[snake.spine.Length - 2].transform.rotation);
            snake.direction[snake.direction.Length - 1] = snake.direction[snake.direction.Length - 2];
            for (int i = snake.direction.Length - 2; i > 0; i--)
                snake.direction[i] = snake.direction[i - 1];
            snake.direction[0] = snake.futuredirection;
            for (int i = snake.body.Length - 2; i > 0; i--)
                snake.body[i].transform.position = snake.body[i - 1].transform.position;
            snake.body[0].transform.position = new Vector3(snake.body[0].transform.position.x + snake.futuredirection.x, snake.body[0].transform.position.y + snake.futuredirection.y, 0f);
            for (int i = snake.direction.Length - 2; i >= 0; i--)
            {
                snake.spine[i].transform.position = new Vector3(snake.body[i + 1].transform.position.x + snake.direction[i].x / 2, snake.body[i + 1].transform.position.y + snake.direction[i].y / 2, 0f);
                snake.spine[i].transform.rotation = new Quaternion(0f, 0f, Math.Abs(snake.direction[i].y) * 90f, Math.Abs(snake.direction[i].y) * 90f);
            }
            DrawApple();
        }
        else
        {
            for (int i = snake.direction.Length - 1; i > 0; i--)
                snake.direction[i] = snake.direction[i - 1];
            snake.direction[0] = snake.futuredirection;
            for (int i = snake.body.Length - 1; i > 0; i--)
                snake.body[i].transform.position = snake.body[i - 1].transform.position;
            snake.body[0].transform.position = new Vector3(snake.body[0].transform.position.x + snake.futuredirection.x, snake.body[0].transform.position.y + snake.futuredirection.y, 0f);
            for (int i = snake.direction.Length - 1; i >= 0; i--)
            {
                snake.spine[i].transform.position = new Vector3(snake.body[i + 1].transform.position.x + snake.direction[i].x / 2, snake.body[i + 1].transform.position.y + snake.direction[i].y / 2, 0f);
                snake.spine[i].transform.rotation = new Quaternion(0f, 0f, Math.Abs(snake.direction[i].y) * 90f, Math.Abs(snake.direction[i].y) * 90f);
            }
            //for (int i = snake.body.Length - 1; i > 1; i--)
            //    if (snake.body[i].transform.position == snake.body[0].transform.position)
            //        Death();
            //if (snake.body[0].transform.position.x < 0 || snake.body[0].transform.position.x > 29 || snake.body[0].transform.position.y < 0 || snake.body[0].transform.position.y > 19)
            //    Death();
        }
        if (pos != 599)
            pos++;
        else
            pos = 0;
    }
    void Death()
    {
        CancelInvoke("Cadr");
        text.text = "You died.\n" + snake.body.Length + " points";
    }
    void DrawApple()
    {
        Apple.transform.position = new Vector3(r.Next(0, 29), r.Next(0, 19), 0f);
        for (int i = snake.body.Length - 1; i >= 0; i--)
        {
            if (snake.body[i].transform.position == Apple.transform.position)
            {
                i = snake.body.Length - 1;
                Apple.transform.position = new Vector3(r.Next(0, 29), r.Next(0, 19), 0f);
            }
        }
    }
}