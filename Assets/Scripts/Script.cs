using UnityEngine;
using System;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    public static string[][] Controls = { new string[]{ "Hor1", "Ver1" }, new string[] { "Hor2", "Ver2" }, new string[] { "Hor3", "Ver3" }, new string[] { "Hor4", "Ver4" } };
    public static string[] nullcontrol = { "", "" };
    static Pos right = new Pos(1, 0), left = new Pos(-1, 0), up = new Pos(0, 1), down = new Pos(0, -1);
    public static Snake snake1, snake2, snake3, snake4;
    static Snake[] Snakes;
    static GameObject[] Bodys, Spine;
    bool startgame = false;
    GameObject Apple, Head1, Body1, Bone1, Head2, Body2, Bone2, Head3, Body3, Bone3, Head4, Body4, Bone4;
    System.Random r = new System.Random();
    public class Snake
    {
        public GameObject[] body;
        public GameObject[] spine;
        public Pos[] direction;
        public Pos futuredirection;
        public bool work;
        public bool life;
        public string[] control;
        public Snake(GameObject[] body, GameObject[] spine, Pos[] direction, Pos futuredirection, bool work, bool life, string[] control)
        {
            this.body = body;
            this.spine = spine;
            this.direction = direction;
            this.futuredirection = futuredirection;
            this.work = work;
            this.life = life;
            this.control = control;
        }
        public Snake(string[] control, bool work)
        {
            this.control = control;
            this.work = work;
        }
    }
    public class Pos
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
        Application.targetFrameRate = 300;
        snake1 = new Snake(nullcontrol, false);
        snake2 = new Snake(nullcontrol, false);
        snake3 = new Snake(nullcontrol, false);
        snake4 = new Snake(nullcontrol, false);
        Snakes = new Snake[]{ snake1, snake2, snake3, snake4 };
        Head1 = GameObject.Find("Head1");
        Body1 = GameObject.Find("Body1");
        Bone1 = GameObject.Find("Bone1");
        Head2 = GameObject.Find("Head2");
        Body2 = GameObject.Find("Body2");
        Bone2 = GameObject.Find("Bone2");
        Head3 = GameObject.Find("Head3");
        Body3 = GameObject.Find("Body3");
        Bone3 = GameObject.Find("Bone3");
        Head4 = GameObject.Find("Head4");
        Body4 = GameObject.Find("Body4");
        Bone4 = GameObject.Find("Bone4");
        Apple = GameObject.Find("Apple");
        Bodys = new GameObject[] { Body1, Body2, Body3, Body4 };
        Spine = new GameObject[] { Bone1, Bone2, Bone3, Bone4 };
    }
    public void StartGame()
    {
        DrawSnakes();
        DrawApple();
        startgame = true;
        InvokeRepeating("Cadr", 0f, 0.25f);
    }
    void DrawSnakes()
    {
        if (snake1.work)
        {
            snake1.body = new GameObject[] {Instantiate(Head1, new Vector3(0f, 3f, 0f), Quaternion.identity), Instantiate(Body1, new Vector3(0f, 2f, 0f), Quaternion.identity), Instantiate(Body1, new Vector3(0f, 1f, 0f), Quaternion.identity), Instantiate(Body1, new Vector3(0f, 0f, 0f), Quaternion.identity) };
            snake1.spine = new GameObject[] {Instantiate(Bone1, new Vector3(0f, 2.5f, -1f), new Quaternion(0f, 0f, 90f, 90f)), Instantiate(Bone1, new Vector3(0f, 1.5f, -1f), new Quaternion(0f, 0f, 90f, 90f)), Instantiate(Bone1, new Vector3(0f, 0.5f, -1f), new Quaternion(0f, 0f, 90f, 90f)) };
            snake1.direction = new Pos[] { up, up, up };
            snake1.futuredirection = up;
            snake1.life = true;
        }
        if (snake2.work)
        {
            snake2.body = new GameObject[] { Instantiate(Head2, new Vector3(0f, 16f, 0f), Quaternion.identity), Instantiate(Body2, new Vector3(0f, 17f, 0f), Quaternion.identity), Instantiate(Body2, new Vector3(0f, 18f, 0f), Quaternion.identity), Instantiate(Body2, new Vector3(0f, 19f, 0f), Quaternion.identity) };
            snake2.spine = new GameObject[] { Instantiate(Bone2, new Vector3(0f, 16.5f, -1f), new Quaternion(0f, 0f, 90f, 90f)), Instantiate(Bone2, new Vector3(0f, 17.5f, -1f), new Quaternion(0f, 0f, 90f, 90f)), Instantiate(Bone2, new Vector3(0f, 18.5f, -1f), new Quaternion(0f, 0f, 90f, 90f)) };
            snake2.direction = new Pos[] { down, down, down };
            snake2.futuredirection = down;
            snake2.life = true;
        }
        if (snake3.work)
        {
            snake3.body = new GameObject[] { Instantiate(Head3, new Vector3(29f, 16f, 0f), Quaternion.identity), Instantiate(Body3, new Vector3(29f, 17f, 0f), Quaternion.identity), Instantiate(Body3, new Vector3(29f, 18f, 0f), Quaternion.identity), Instantiate(Body3, new Vector3(29f, 19f, 0f), Quaternion.identity) };
            snake3.spine = new GameObject[] { Instantiate(Bone3, new Vector3(29f, 16.5f, -1f), new Quaternion(0f, 0f, 90f, 90f)), Instantiate(Bone3, new Vector3(29f, 17.5f, -1f), new Quaternion(0f, 0f, 90f, 90f)), Instantiate(Bone3, new Vector3(29f, 18.5f, -1f), new Quaternion(0f, 0f, 90f, 90f)) };
            snake3.direction = new Pos[] { down, down, down };
            snake3.futuredirection = down;
            snake3.life = true;
        }
        if (snake4.work)
        {
            snake4.body = new GameObject[] { Instantiate(Head4, new Vector3(29f, 3f, 0f), Quaternion.identity), Instantiate(Body4, new Vector3(29f, 2f, 0f), Quaternion.identity), Instantiate(Body4, new Vector3(29f, 1f, 0f), Quaternion.identity), Instantiate(Body4, new Vector3(29f, 0f, 0f), Quaternion.identity) };
            snake4.spine = new GameObject[] { Instantiate(Bone4, new Vector3(29f, 2.5f, -1f), new Quaternion(0f, 0f, 90f, 90f)), Instantiate(Bone4, new Vector3(29f, 1.5f, -1f), new Quaternion(0f, 0f, 90f, 90f)), Instantiate(Bone4, new Vector3(29f, 0.5f, -1f), new Quaternion(0f, 0f, 90f, 90f)) };
            snake4.direction = new Pos[] { up, up, up };
            snake4.futuredirection = up;
            snake4.life = true;
        }
    }
    void DeleteSnakes()
    {
        foreach (Snake snake in Snakes)
        {
            if (snake.work)
            {
                for (int i = 0; i < snake.body.Length; i++)
                    Destroy(snake.body[i]);
                for (int i = 0; i < snake.spine.Length; i++)
                    Destroy(snake.spine[i]);
            }
        }
    }
    void Update()
    {
        if (startgame)
        {
            if (snake1.life)
            {
                if (Input.GetAxis(snake1.control[0]) > 0)
                    if (snake1.direction[0] != left)
                        snake1.futuredirection = right;
                if (Input.GetAxis(snake1.control[0]) < 0)
                    if (snake1.direction[0] != right)
                        snake1.futuredirection = left;
                if (Input.GetAxis(snake1.control[1]) > 0)
                    if (snake1.direction[0] != down)
                        snake1.futuredirection = up;
                if (Input.GetAxis(snake1.control[1]) < 0)
                    if (snake1.direction[0] != up)
                        snake1.futuredirection = down;
            }
            if (snake2.life)
            {
                if (Input.GetAxis(snake2.control[0]) > 0)
                    if (snake2.direction[0] != left)
                        snake2.futuredirection = right;
                if (Input.GetAxis(snake2.control[0]) < 0)
                    if (snake2.direction[0] != right)
                        snake2.futuredirection = left;
                if (Input.GetAxis(snake2.control[1]) > 0)
                    if (snake2.direction[0] != down)
                        snake2.futuredirection = up;
                if (Input.GetAxis(snake2.control[1]) < 0)
                    if (snake2.direction[0] != up)
                        snake2.futuredirection = down;
            }
            if (snake3.life)
            {
                if (Input.GetAxis(snake3.control[0]) > 0)
                    if (snake3.direction[0] != left)
                        snake3.futuredirection = right;
                if (Input.GetAxis(snake3.control[0]) < 0)
                    if (snake3.direction[0] != right)
                        snake3.futuredirection = left;
                if (Input.GetAxis(snake3.control[1]) > 0)
                    if (snake3.direction[0] != down)
                        snake3.futuredirection = up;
                if (Input.GetAxis(snake3.control[1]) < 0)
                    if (snake3.direction[0] != up)
                        snake3.futuredirection = down;
            }
            if (snake4.life)
            {
                if (Input.GetAxis(snake4.control[0]) > 0)
                    if (snake4.direction[0] != left)
                        snake4.futuredirection = right;
                if (Input.GetAxis(snake4.control[0]) < 0)
                    if (snake4.direction[0] != right)
                        snake4.futuredirection = left;
                if (Input.GetAxis(snake4.control[1]) > 0)
                    if (snake4.direction[0] != down)
                        snake4.futuredirection = up;
                if (Input.GetAxis(snake4.control[1]) < 0)
                    if (snake4.direction[0] != up)
                        snake4.futuredirection = down;
            }
            if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.JoystickButton1))
            {
                DeleteSnakes();
                CancelInvoke("Cadr");
                StartGame();
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.JoystickButton3))
        {
            DeleteSnakes();
            CancelInvoke("Cadr");
            startgame = false;
            Apple.transform.position = new Vector3(-1f, -1f, 0f);
        }
    }
    void Cadr()
    {
        for (int i = 0; i < 4; i++)
        {
            if (Snakes[i].life)
            {
                if (Snakes[i].body[0].transform.position.x + Snakes[i].futuredirection.x == Apple.transform.position.x && Snakes[i].body[0].transform.position.y + Snakes[i].futuredirection.y == Apple.transform.position.y)
                {
                    Array.Resize(ref Snakes[i].body, Snakes[i].body.Length + 1);
                    Array.Resize(ref Snakes[i].spine, Snakes[i].spine.Length + 1);
                    Array.Resize(ref Snakes[i].direction, Snakes[i].direction.Length + 1);
                    Snakes[i].body[Snakes[i].body.Length - 1] = Instantiate(Bodys[i], Snakes[i].body[Snakes[i].body.Length - 2].transform.position, Head1.transform.rotation);
                    Snakes[i].spine[Snakes[i].spine.Length - 1] = Instantiate(Spine[i], Snakes[i].spine[Snakes[i].spine.Length - 2].transform.position, Snakes[i].spine[Snakes[i].spine.Length - 2].transform.rotation);
                    Snakes[i].direction[Snakes[i].direction.Length - 1] = Snakes[i].direction[Snakes[i].direction.Length - 2];
                    for (int j = Snakes[i].direction.Length - 2; j > 0; j--)
                        Snakes[i].direction[j] = Snakes[i].direction[j - 1];
                    Snakes[i].direction[0] = Snakes[i].futuredirection;
                    for (int j = Snakes[i].body.Length - 2; j > 0; j--)
                        Snakes[i].body[j].transform.position = Snakes[i].body[j - 1].transform.position;
                    Snakes[i].body[0].transform.position = new Vector3(Snakes[i].body[0].transform.position.x + Snakes[i].futuredirection.x, Snakes[i].body[0].transform.position.y + Snakes[i].futuredirection.y, 0f);
                    for (int j = Snakes[i].direction.Length - 2; j >= 0; j--)
                    {
                        Snakes[i].spine[j].transform.position = new Vector3(Snakes[i].body[j + 1].transform.position.x + Snakes[i].direction[j].x / 2, Snakes[i].body[j + 1].transform.position.y + Snakes[i].direction[j].y / 2, -1f);
                        Snakes[i].spine[j].transform.rotation = new Quaternion(0f, 0f, Math.Abs(Snakes[i].direction[j].y) * 90f, Math.Abs(Snakes[i].direction[j].y) * 90f);
                    }
                    DrawApple();
                }
                else
                {
                    for (int j = Snakes[i].direction.Length - 1; j > 0; j--)
                        Snakes[i].direction[j] = Snakes[i].direction[j - 1];
                    Snakes[i].direction[0] = Snakes[i].futuredirection;
                    for (int j = Snakes[i].body.Length - 1; j > 0; j--)
                        Snakes[i].body[j].transform.position = Snakes[i].body[j - 1].transform.position;
                    Snakes[i].body[0].transform.position = new Vector3(Snakes[i].body[0].transform.position.x + Snakes[i].futuredirection.x, Snakes[i].body[0].transform.position.y + Snakes[i].futuredirection.y, 0f);
                    for (int j = Snakes[i].direction.Length - 1; j >= 0; j--)
                    {
                        Snakes[i].spine[j].transform.position = new Vector3(Snakes[i].body[j + 1].transform.position.x + Snakes[i].direction[j].x / 2, Snakes[i].body[j + 1].transform.position.y + Snakes[i].direction[j].y / 2, -1f);
                        Snakes[i].spine[j].transform.rotation = new Quaternion(0f, 0f, Math.Abs(Snakes[i].direction[j].y) * 90f, Math.Abs(Snakes[i].direction[j].y) * 90f);
                    }
                }
            }
        }
        foreach (Snake snake in Snakes)
        {
            if (snake.life)
            {
                foreach(Snake snak in Snakes)
                if(snak.life)
                        for (int j = snak.body.Length - 1; j > 0; j--)
                            if (snak.body[j].transform.position.x == snake.body[0].transform.position.x && snak.body[j].transform.position.y == snake.body[0].transform.position.y)
                                Death(snake);
                if (snake.body[0].transform.position.x < 0 || snake.body[0].transform.position.x > 29 || snake.body[0].transform.position.y < 0 || snake.body[0].transform.position.y > 19)
                    Death(snake);
            }
        }
    }
    void Death(Snake snake)
    {
        snake.life = false;
        snake.body[0].transform.position -= Vector3.forward;
        foreach (GameObject body in snake.body)
        {
            body.GetComponent<SpriteRenderer>().color = new Color(body.GetComponent<SpriteRenderer>().color.r / 2, body.GetComponent<SpriteRenderer>().color.g / 2, body.GetComponent<SpriteRenderer>().color.b / 2);
            body.transform.position += Vector3.forward * 2;
        }
        foreach (GameObject bone in snake.spine)
        {
            bone.GetComponent<SpriteRenderer>().color = new Color(bone.GetComponent<SpriteRenderer>().color.r / 2, bone.GetComponent<SpriteRenderer>().color.g / 2, bone.GetComponent<SpriteRenderer>().color.b / 2);
            bone.transform.position += Vector3.forward * 2;
        }
    }
    void DrawApple()
    {
        Apple.transform.position = new Vector3(Convert.ToSingle(r.Next(0, 29)), Convert.ToSingle(r.Next(0, 19)), 0f);
        foreach(Snake snake in Snakes)
        {
            if (snake.work)
                for (int i = 0; i < snake.body.Length; i++)
                    if (snake.body[i].transform.position.x == Apple.transform.position.x && snake.body[i].transform.position.y == Apple.transform.position.y)
                        DrawApple();
        }
    }
}