using UnityEngine;
using System;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    static Pos right = new Pos(1, 0), left = new Pos(-1, 0), up = new Pos(0, 1), down = new Pos(0, -1);
    public Text text;
    byte count = 1;
    Snake snake1, snake2, snake3, snake4;
    GameObject Apple, Head1, Body1, Bone1, Head2, Body2, Bone2, Head3, Body3, Bone3, Head4, Body4, Bone4;
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
        Application.targetFrameRate = 4;
        Head1 = GameObject.Find("Head1");
        Body1 = GameObject.Find("Body1");
        Bone1 = GameObject.Find("Bone1");
        GameObject[] alfa = { Instantiate(Head1, new Vector3(0f, 3f, 0f), Head1.transform.rotation), Instantiate(Body1, new Vector3(0f, 2f, 0f), Body1.transform.rotation), Instantiate(Body1, new Vector3(0f, 1f, 0f), Body1.transform.rotation), Instantiate(Body1, new Vector3(0f, 0f, 0f), Body1.transform.rotation) },
            beta = { Instantiate(Bone1, new Vector3(0f, 2.5f, 0f), Bone1.transform.rotation), Instantiate(Bone1, new Vector3(0f, 1.5f, 0f), Bone1.transform.rotation), Instantiate(Bone1, new Vector3(0f, 0.5f, 0f), Bone1.transform.rotation) };
        Pos[] gamma = { up, up, up };
        Pos delta = up;
        snake1 = new Snake(alfa, beta, gamma, delta);
        Apple = GameObject.Find("Apple");
        DrawApple();
        InvokeRepeating("Cadr", 0f, 0.25f);
    }
    void StartGame()
    {
    }
    void DrawSnakes(byte a)
    {
        if(a > 0)
        {
            Head1 = GameObject.Find("Head1");
            Body1 = GameObject.Find("Body1");
            Bone1 = GameObject.Find("Bone1");
            GameObject[] alfa = { Instantiate(Head1, new Vector3(0f, 3f, 0f), Head1.transform.rotation), Instantiate(Body1, new Vector3(0f, 2f, 0f), Body1.transform.rotation), Instantiate(Body1, new Vector3(0f, 1f, 0f), Body1.transform.rotation), Instantiate(Body1, new Vector3(0f, 0f, 0f), Body1.transform.rotation) },
                beta = { Instantiate(Bone1, new Vector3(0f, 2.5f, 0f), Bone1.transform.rotation), Instantiate(Bone1, new Vector3(0f, 1.5f, 0f), Bone1.transform.rotation), Instantiate(Bone1, new Vector3(0f, 0.5f, 0f), Bone1.transform.rotation) };
            Pos[] gamma = { up, up, up };
            Pos delta = up;
            snake1 = new Snake(alfa, beta, gamma, delta);
        }
        if(a > 1)
        {
            Head2 = GameObject.Find("Head2");
            Body2 = GameObject.Find("Body2");
            Bone2 = GameObject.Find("Bone2");
            GameObject[] alfa = { Instantiate(Head1, new Vector3(0f, 16f, 0f), Head1.transform.rotation), Instantiate(Body1, new Vector3(0f, 17f, 0f), Body1.transform.rotation), Instantiate(Body1, new Vector3(0f, 18f, 0f), Body1.transform.rotation), Instantiate(Body1, new Vector3(0f, 19f, 0f), Body1.transform.rotation) },
                beta = { Instantiate(Bone1, new Vector3(0f, 16.5f, 0f), Bone1.transform.rotation), Instantiate(Bone1, new Vector3(0f, 17.5f, 0f), Bone1.transform.rotation), Instantiate(Bone1, new Vector3(0f, 18.5f, 0f), Bone1.transform.rotation) };
            Pos[] gamma = { down, down, down };
            Pos delta = down;
            snake2 = new Snake(alfa, beta, gamma, delta);
        }
        if (a > 2)
        {
            Head3 = GameObject.Find("Head3");
            Body3 = GameObject.Find("Body3");
            Bone3 = GameObject.Find("Bone3");
            GameObject[] alfa = { Instantiate(Head1, new Vector3(29f, 16f, 0f), Head1.transform.rotation), Instantiate(Body1, new Vector3(29f, 17f, 0f), Body1.transform.rotation), Instantiate(Body1, new Vector3(29f, 18f, 0f), Body1.transform.rotation), Instantiate(Body1, new Vector3(29f, 19f, 0f), Body1.transform.rotation) },
                beta = { Instantiate(Bone1, new Vector3(29f, 16.5f, 0f), Bone1.transform.rotation), Instantiate(Bone1, new Vector3(29f, 17.5f, 0f), Bone1.transform.rotation), Instantiate(Bone1, new Vector3(29f, 18.5f, 0f), Bone1.transform.rotation) };
            Pos[] gamma = { down, down, down };
            Pos delta = down;
            snake3 = new Snake(alfa, beta, gamma, delta);
        }
        if (a > 3)
        {
            Head4 = GameObject.Find("Head4");
            Body4 = GameObject.Find("Body4");
            Bone4 = GameObject.Find("Bone4");
            GameObject[] alfa = { Instantiate(Head1, new Vector3(29f, 3f, 0f), Head1.transform.rotation), Instantiate(Body1, new Vector3(29f, 2f, 0f), Body1.transform.rotation), Instantiate(Body1, new Vector3(29f, 1f, 0f), Body1.transform.rotation), Instantiate(Body1, new Vector3(29f, 0f, 0f), Body1.transform.rotation) },
                beta = { Instantiate(Bone1, new Vector3(29f, 2.5f, 0f), Bone1.transform.rotation), Instantiate(Bone1, new Vector3(29f, 1.5f, 0f), Bone1.transform.rotation), Instantiate(Bone1, new Vector3(29f, 0.5f, 0f), Bone1.transform.rotation) };
            Pos[] gamma = { up, up, up };
            Pos delta = up;
            snake4 = new Snake(alfa, beta, gamma, delta);
        }
    }
    void Update()
    {
        if (Input.GetAxis("Hor3") > 0)
            if(snake1.direction[0] != left)
            snake1.futuredirection = right;
        if (Input.GetAxis("Hor3") < 0)
            if (snake1.direction[0] != right)
                snake1.futuredirection = left;
        if (Input.GetAxis("Ver3") > 0)
            if (snake1.direction[0] != down)
                snake1.futuredirection = up;
        if (Input.GetAxis("Ver3") < 0)
            if (snake1.direction[0] != up)
                snake1.futuredirection = down;
        if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.JoystickButton5) || Input.GetKeyDown(KeyCode.JoystickButton3))
        {
            for (int i = 0; i < snake1.body.Length; i++)
                Destroy(snake1.body[i]);
            for (int i = 0; i < snake1.spine.Length; i++)
                Destroy(snake1.spine[i]);
            CancelInvoke("Cadr");
            text.text = "";
            Start();
        }
    }
    void Cadr()
    {
        if (snake1.body[0].transform.position.x + snake1.futuredirection.x == Apple.transform.position.x && snake1.body[0].transform.position.y + snake1.futuredirection.y == Apple.transform.position.y)
        {
            Array.Resize(ref snake1.body, snake1.body.Length + 1);
            Array.Resize(ref snake1.spine, snake1.spine.Length + 1);
            Array.Resize(ref snake1.direction, snake1.direction.Length + 1);
            snake1.body[snake1.body.Length - 1] = Instantiate(Body1, snake1.body[snake1.body.Length - 2].transform.position, Head1.transform.rotation);
            snake1.spine[snake1.spine.Length - 1] = Instantiate(Bone1, snake1.spine[snake1.spine.Length - 2].transform.position, snake1.spine[snake1.spine.Length - 2].transform.rotation);
            snake1.direction[snake1.direction.Length - 1] = snake1.direction[snake1.direction.Length - 2];
            for (int i = snake1.direction.Length - 2; i > 0; i--)
                snake1.direction[i] = snake1.direction[i - 1];
            snake1.direction[0] = snake1.futuredirection;
            for (int i = snake1.body.Length - 2; i > 0; i--)
                snake1.body[i].transform.position = snake1.body[i - 1].transform.position;
            snake1.body[0].transform.position = new Vector3(snake1.body[0].transform.position.x + snake1.futuredirection.x, snake1.body[0].transform.position.y + snake1.futuredirection.y, 0f);
            for (int i = snake1.direction.Length - 2; i >= 0; i--)
            {
                snake1.spine[i].transform.position = new Vector3(snake1.body[i + 1].transform.position.x + snake1.direction[i].x / 2, snake1.body[i + 1].transform.position.y + snake1.direction[i].y / 2, 0f);
                snake1.spine[i].transform.rotation = new Quaternion(0f, 0f, Math.Abs(snake1.direction[i].y) * 90f, Math.Abs(snake1.direction[i].y) * 90f);
            }
            DrawApple();
        }
        else
        {
            for (int i = snake1.direction.Length - 1; i > 0; i--)
                snake1.direction[i] = snake1.direction[i - 1];
            snake1.direction[0] = snake1.futuredirection;
            for (int i = snake1.body.Length - 1; i > 0; i--)
                snake1.body[i].transform.position = snake1.body[i - 1].transform.position;
            snake1.body[0].transform.position = new Vector3(snake1.body[0].transform.position.x + snake1.futuredirection.x, snake1.body[0].transform.position.y + snake1.futuredirection.y, 0f);
            for (int i = snake1.direction.Length - 1; i >= 0; i--)
            {
                snake1.spine[i].transform.position = new Vector3(snake1.body[i + 1].transform.position.x + snake1.direction[i].x / 2, snake1.body[i + 1].transform.position.y + snake1.direction[i].y / 2, 0f);
                snake1.spine[i].transform.rotation = new Quaternion(0f, 0f, Math.Abs(snake1.direction[i].y) * 90f, Math.Abs(snake1.direction[i].y) * 90f);
            }
        }
        for (int i = snake1.body.Length - 1; i > 1; i--)
            if (snake1.body[i].transform.position == snake1.body[0].transform.position)
                Death();
        if (snake1.body[0].transform.position.x < 0 || snake1.body[0].transform.position.x > 29 || snake1.body[0].transform.position.y < 0 || snake1.body[0].transform.position.y > 19)
            Death();
        if (snake1.body.Length == 599)
        {
            CancelInvoke("Cadr");
            text.text = "You win";
        }
    }
    void Death()
    {
        CancelInvoke("Cadr");
        text.text = "You died.\n" + snake1.body.Length + " points";
        snake1.body[0].transform.position += Vector3.back;
    }
    void DrawApple()
    {
        Apple.transform.position = new Vector3(r.Next(0, 29), r.Next(0, 19), 0f);
        for (int i = snake1.body.Length - 1; i >= 0; i--)
        {
            if (snake1.body[i].transform.position == Apple.transform.position)
            {
                i = snake1.body.Length - 1;
                Apple.transform.position = new Vector3(r.Next(0, 29), r.Next(0, 19), 0f);
            }
        }
    }
}