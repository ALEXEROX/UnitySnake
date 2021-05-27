using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text text;
    Color color;
    public GameObject Window, wasd, arrows, gamepad1, gamepad2, button1, button2, button3, button4, greenwindow, redwindow, bluewindow, yellowwindow, start, remove1, remove2, remove3, remove4;
    bool check1, check2, check3, check4;
    void Update()
    {
        if (check1)
        {
            if (Input.GetAxis("Ver1") != 0 || Input.GetAxis("Hor1") != 0)
            {
                Script.snake1.control = Script.Controls[0];
                if (Script.snake1.control[0] != Script.snake2.control[0] && Script.snake1.control[0] != Script.snake3.control[0] && Script.snake1.control[0] != Script.snake4.control[0])
                {
                    arrows.transform.position = new Vector3(4f, 9f, 82f);
                    if (wasd.transform.position.y != 9)
                        wasd.transform.position += Vector3.down * 19;
                    if (gamepad1.transform.position.y != 9)
                        gamepad1.transform.position += Vector3.down * 19;
                    if (gamepad2.transform.position.y != 9)
                        gamepad2.transform.position += Vector3.down * 19;
                    Set1();
                }
            }
            else if (Input.GetAxis("Ver2") != 0 || Input.GetAxis("Hor2") != 0)
            {
                Script.snake1.control = Script.Controls[1];
                if (Script.snake1.control[0] != Script.snake2.control[0] && Script.snake1.control[0] != Script.snake3.control[0] && Script.snake1.control[0] != Script.snake4.control[0])
                {
                    wasd.transform.position = new Vector3(4f, 9f, 82f);
                    if (arrows.transform.position.y != 9)
                        arrows.transform.position += Vector3.down * 19;
                    if (gamepad2.transform.position.y != 9)
                        gamepad2.transform.position += Vector3.down * 19;
                    if (gamepad1.transform.position.y != 9)
                        gamepad1.transform.position += Vector3.down * 19;
                    Set1();
                }
            }
            else if (Input.GetAxis("Ver3") != 0 || Input.GetAxis("Hor3") != 0)
            {
                Script.snake1.control = Script.Controls[2];
                if (Script.snake1.control[0] != Script.snake2.control[0] && Script.snake1.control[0] != Script.snake3.control[0] && Script.snake1.control[0] != Script.snake4.control[0])
                {
                    gamepad1.transform.position = new Vector3(4f, 9f, 82f);
                    if (wasd.transform.position.y != 9)
                        wasd.transform.position += Vector3.down * 19;
                    if (arrows.transform.position.y != 9)
                        arrows.transform.position += Vector3.down * 19;
                    if (gamepad2.transform.position.y != 9)
                        gamepad2.transform.position += Vector3.down * 19;
                    Set1();
                }
            }
            else if (Input.GetAxis("Ver4") != 0 || Input.GetAxis("Hor4") != 0)
            {
                Script.snake1.control = Script.Controls[3];
                if (Script.snake1.control[0] != Script.snake2.control[0] && Script.snake1.control[0] != Script.snake3.control[0] && Script.snake1.control[0] != Script.snake4.control[0])
                {
                    gamepad2.transform.position = new Vector3(4f, 9f, 82f);
                    if (arrows.transform.position.y != 9)
                        arrows.transform.position += Vector3.down * 19;
                    if (wasd.transform.position.y != 9)
                        wasd.transform.position += Vector3.down * 19;
                    if (gamepad1.transform.position.y != 9)
                        gamepad1.transform.position += Vector3.down * 19;
                    Set1();
                }
            }
        }
        else if (check2)
        {
            if (Input.GetAxis("Ver1") != 0 || Input.GetAxis("Hor1") != 0)
            {
                Script.snake2.control = Script.Controls[0];
                if (Script.snake2.control[0] != Script.snake1.control[0] && Script.snake2.control[0] != Script.snake3.control[0] && Script.snake2.control[0] != Script.snake4.control[0])
                {
                    arrows.transform.position = new Vector3(11f, 9f, 82f);
                    if (wasd.transform.position.y != 9)
                        wasd.transform.position += Vector3.down * 19;
                    if (gamepad1.transform.position.y != 9)
                        gamepad1.transform.position += Vector3.down * 19;
                    if (gamepad2.transform.position.y != 9)
                        gamepad2.transform.position += Vector3.down * 19;
                    Set2();
                }
            }
            else if (Input.GetAxis("Ver2") != 0 || Input.GetAxis("Hor2") != 0)
            {
                Script.snake2.control = Script.Controls[1];
                if (Script.snake2.control[0] != Script.snake1.control[0] && Script.snake2.control[0] != Script.snake3.control[0] && Script.snake2.control[0] != Script.snake4.control[0])
                {
                    wasd.transform.position = new Vector3(11f, 9f, 82f);
                    if (arrows.transform.position.y != 9)
                        arrows.transform.position += Vector3.down * 19;
                    if (gamepad2.transform.position.y != 9)
                        gamepad2.transform.position += Vector3.down * 19;
                    if (gamepad1.transform.position.y != 9)
                        gamepad1.transform.position += Vector3.down * 19;
                    Set2();
                }
            }
            else if (Input.GetAxis("Ver3") != 0 || Input.GetAxis("Hor3") != 0)
            {
                Script.snake2.control = Script.Controls[2];
                if (Script.snake2.control[0] != Script.snake1.control[0] && Script.snake2.control[0] != Script.snake3.control[0] && Script.snake2.control[0] != Script.snake4.control[0])
                {
                    gamepad1.transform.position = new Vector3(11f, 9f, 82f);
                    if (wasd.transform.position.y != 9)
                        wasd.transform.position += Vector3.down * 19;
                    if (arrows.transform.position.y != 9)
                        arrows.transform.position += Vector3.down * 19;
                    if (gamepad2.transform.position.y != 9)
                        gamepad2.transform.position += Vector3.down * 19;
                    Set2();
                }
            }
            else if (Input.GetAxis("Ver4") != 0 || Input.GetAxis("Hor4") != 0)
            {
                Script.snake2.control = Script.Controls[3];
                if (Script.snake2.control[0] != Script.snake1.control[0] && Script.snake2.control[0] != Script.snake3.control[0] && Script.snake2.control[0] != Script.snake4.control[0])
                {
                    gamepad2.transform.position = new Vector3(11f, 9f, 82f);
                    if (arrows.transform.position.y != 9)
                        arrows.transform.position += Vector3.down * 19;
                    if (wasd.transform.position.y != 9)
                        wasd.transform.position += Vector3.down * 19;
                    if (gamepad1.transform.position.y != 9)
                        gamepad1.transform.position += Vector3.down * 19;
                    Set2();
                }
            }
        }
        else if (check3)
        {
            if (Input.GetAxis("Ver1") != 0 || Input.GetAxis("Hor1") != 0)
            {
                Script.snake3.control = Script.Controls[0];
                if (Script.snake3.control[0] != Script.snake1.control[0] && Script.snake3.control[0] != Script.snake2.control[0] && Script.snake3.control[0] != Script.snake4.control[0])
                {
                    arrows.transform.position = new Vector3(18f, 9f, 82f);
                    if (wasd.transform.position.y != 9)
                        wasd.transform.position += Vector3.down * 19;
                    if (gamepad1.transform.position.y != 9)
                        gamepad1.transform.position += Vector3.down * 19;
                    if (gamepad2.transform.position.y != 9)
                        gamepad2.transform.position += Vector3.down * 19;
                    Set3();
                }
            }
            else if (Input.GetAxis("Ver2") != 0 || Input.GetAxis("Hor2") != 0)
            {
                Script.snake3.control = Script.Controls[1];
                if (Script.snake3.control[0] != Script.snake1.control[0] && Script.snake3.control[0] != Script.snake2.control[0] && Script.snake3.control[0] != Script.snake4.control[0])
                {
                    wasd.transform.position = new Vector3(18f, 9f, 82f);
                    if (arrows.transform.position.y != 9)
                        arrows.transform.position += Vector3.down * 19;
                    if (gamepad2.transform.position.y != 9)
                        gamepad2.transform.position += Vector3.down * 19;
                    if (gamepad1.transform.position.y != 9)
                        gamepad1.transform.position += Vector3.down * 19;
                    Set3();
                }
            }
            else if (Input.GetAxis("Ver3") != 0 || Input.GetAxis("Hor3") != 0)
            {
                Script.snake3.control = Script.Controls[2];
                if (Script.snake3.control[0] != Script.snake1.control[0] && Script.snake3.control[0] != Script.snake2.control[0] && Script.snake3.control[0] != Script.snake4.control[0])
                {
                    gamepad1.transform.position = new Vector3(18f, 9f, 82f);
                    if (wasd.transform.position.y != 9)
                        wasd.transform.position += Vector3.down * 19;
                    if (arrows.transform.position.y != 9)
                        arrows.transform.position += Vector3.down * 19;
                    if (gamepad2.transform.position.y != 9)
                        gamepad2.transform.position += Vector3.down * 19;
                    Set3();
                }
            }
            else if (Input.GetAxis("Ver4") != 0 || Input.GetAxis("Hor4") != 0)
            {
                Script.snake3.control = Script.Controls[3];
                if (Script.snake3.control[0] != Script.snake1.control[0] && Script.snake3.control[0] != Script.snake2.control[0] && Script.snake3.control[0] != Script.snake4.control[0])
                {
                    gamepad2.transform.position = new Vector3(18f, 9f, 82f);
                    if (arrows.transform.position.y != 9)
                        arrows.transform.position += Vector3.down * 19;
                    if (wasd.transform.position.y != 9)
                        wasd.transform.position += Vector3.down * 19;
                    if (gamepad1.transform.position.y != 9)
                        gamepad1.transform.position += Vector3.down * 19;
                    Set3();
                }
            }
        }
        else if (check4)
        {
            if (Input.GetAxis("Ver1") != 0 || Input.GetAxis("Hor1") != 0)
            {
                Script.snake4.control = Script.Controls[0];
                if (Script.snake4.control[0] != Script.snake2.control[0] && Script.snake4.control[0] != Script.snake3.control[0] && Script.snake4.control[0] != Script.snake1.control[0])
                {
                    arrows.transform.position = new Vector3(25f, 9f, 82f);
                    if (wasd.transform.position.y != 9)
                        wasd.transform.position += Vector3.down * 19;
                    if (gamepad1.transform.position.y != 9)
                        gamepad1.transform.position += Vector3.down * 19;
                    if (gamepad2.transform.position.y != 9)
                        gamepad2.transform.position += Vector3.down * 19;
                    Set4();
                }
            }
            else if (Input.GetAxis("Ver2") != 0 || Input.GetAxis("Hor2") != 0)
            {
                Script.snake4.control = Script.Controls[1];
                if (Script.snake4.control[0] != Script.snake2.control[0] && Script.snake4.control[0] != Script.snake3.control[0] && Script.snake4.control[0] != Script.snake1.control[0])
                {
                    wasd.transform.position = new Vector3(25f, 9f, 82f);
                    if (arrows.transform.position.y != 9)
                        arrows.transform.position += Vector3.down * 19;
                    if (gamepad2.transform.position.y != 9)
                        gamepad2.transform.position += Vector3.down * 19;
                    if (gamepad1.transform.position.y != 9)
                        gamepad1.transform.position += Vector3.down * 19;
                    Set4();
                }
            }
            else if (Input.GetAxis("Ver3") != 0 || Input.GetAxis("Hor3") != 0)
            {
                Script.snake4.control = Script.Controls[2];
                if (Script.snake4.control[0] != Script.snake2.control[0] && Script.snake4.control[0] != Script.snake3.control[0] && Script.snake4.control[0] != Script.snake1.control[0])
                {
                    gamepad1.transform.position = new Vector3(25f, 9f, 82f);
                    if (wasd.transform.position.y != 9)
                        wasd.transform.position += Vector3.down * 19;
                    if (arrows.transform.position.y != 9)
                        arrows.transform.position += Vector3.down * 19;
                    if (gamepad2.transform.position.y != 9)
                        gamepad2.transform.position += Vector3.down * 19;
                    Set4();
                }
            }
            else if (Input.GetAxis("Ver4") != 0 || Input.GetAxis("Hor4") != 0)
            {
                Script.snake4.control = Script.Controls[3];
                if (Script.snake4.control[0] != Script.snake2.control[0] && Script.snake4.control[0] != Script.snake3.control[0] && Script.snake4.control[0] != Script.snake1.control[0])
                {
                    gamepad2.transform.position = new Vector3(25f, 9f, 82f);
                    if (arrows.transform.position.y != 9)
                        arrows.transform.position += Vector3.down * 19;
                    if (wasd.transform.position.y != 9)
                        wasd.transform.position += Vector3.down * 19;
                    if (gamepad1.transform.position.y != 9)
                        gamepad1.transform.position += Vector3.down * 19;
                    Set4();
                }
            }
        }
        if((Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.JoystickButton1)) && (check1 || check2 || check3 || check4))
        {
            Window.transform.position += Vector3.down * 19;
            if (!Script.snake1.work)
                button1.GetComponent<Button>().interactable = true;
            if (!Script.snake2.work)
                button2.GetComponent<Button>().interactable = true;
            if (!Script.snake3.work)
                button3.GetComponent<Button>().interactable = true;
            if (!Script.snake4.work)
                button4.GetComponent<Button>().interactable = true;
            check1 = check2 = check3 = check4 = false;
            text.text = "";
            if (arrows.transform.position.y != 9)
                arrows.transform.position += Vector3.down * 19;
            if (wasd.transform.position.y != 9)
                wasd.transform.position += Vector3.down * 19;
            if (gamepad1.transform.position.y != 9)
                gamepad1.transform.position += Vector3.down * 19;
            if (gamepad2.transform.position.y != 9)
                gamepad2.transform.position += Vector3.down * 19;
        }
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.JoystickButton3))
        {
            button1.GetComponent<Image>().enabled = button2.GetComponent<Image>().enabled = button3.GetComponent<Image>().enabled = button4.GetComponent<Image>().enabled = start.GetComponent<Image>().enabled = true;
            if (!Script.snake1.work)
                button1.GetComponent<Button>().interactable = true;
            if (!Script.snake2.work)
                button2.GetComponent<Button>().interactable = true;
            if (!Script.snake3.work)
                button3.GetComponent<Button>().interactable = true;
            if (!Script.snake4.work)
                button4.GetComponent<Button>().interactable = true;
            if (greenwindow.transform.position.y > 25)
                greenwindow.transform.position -= Vector3.up * 19;
            if (redwindow.transform.position.y > 25)
                redwindow.transform.position -= Vector3.up * 19;
            if (bluewindow.transform.position.y > 25)
                bluewindow.transform.position -= Vector3.up * 19;
            if (yellowwindow.transform.position.y > 25)
                yellowwindow.transform.position -= Vector3.up * 19;
            if (arrows.transform.position.y > 25)
                arrows.transform.position -= Vector3.up * 19;
            if (wasd.transform.position.y > 25)
                wasd.transform.position -= Vector3.up * 19;
            if (gamepad1.transform.position.y > 25)
                gamepad1.transform.position -= Vector3.up * 19;
            if (gamepad2.transform.position.y > 25)
                gamepad2.transform.position -= Vector3.up * 19;
        }
    }

    public void AddSnake1()
    {
        color = new Color(0, 255, 0);
        check1 = true;
        Check();
    }
    public void AddSnake2()
    {
        color = new Color(255, 0, 0);
        check2 = true;
        Check();
    }
    public void AddSnake3()
    {
        color = new Color(0, 0, 255);
        check3 = true;
        Check();
    }
    public void AddSnake4()
    {
        color = new Color(255, 255, 0);
        check4 = true;
        Check();
    }

    void Set1()
    {
        Script.snake1.work = true;
        Window.transform.position += Vector3.down * 19;
        greenwindow.transform.position += Vector3.up * 19;
        if (!Script.snake2.work)
            button2.GetComponent<Button>().interactable = true;
        if (!Script.snake3.work)
            button3.GetComponent<Button>().interactable = true;
        if (!Script.snake4.work)
            button4.GetComponent<Button>().interactable = true;
        check1 = false;
        remove1.transform.position += Vector3.up * 19;
        text.text = "";
        start.GetComponent<Button>().interactable = true;
    }

    void Set2()
    {
        Script.snake2.work = true;
        Window.transform.position += Vector3.down * 19;
        redwindow.transform.position += Vector3.up * 19;
        if (!Script.snake1.work)
            button1.GetComponent<Button>().interactable = true;
        if (!Script.snake3.work)
            button3.GetComponent<Button>().interactable = true;
        if (!Script.snake4.work)
            button4.GetComponent<Button>().interactable = true;
        check2 = false;
        remove2.transform.position += Vector3.up * 19;
        text.text = "";
        start.GetComponent<Button>().interactable = true;
    }

    void Set3()
    {
        Script.snake3.work = true;
        Window.transform.position += Vector3.down * 19;
        bluewindow.transform.position += Vector3.up * 19;
        if (!Script.snake2.work)
            button2.GetComponent<Button>().interactable = true;
        if (!Script.snake1.work)
            button1.GetComponent<Button>().interactable = true;
        if (!Script.snake4.work)
            button4.GetComponent<Button>().interactable = true;
        check3 = false;
        remove3.transform.position += Vector3.up * 19;
        text.text = "";
        start.GetComponent<Button>().interactable = true;
    }

    void Set4()
    {
        Script.snake4.work = true;
        Window.transform.position += Vector3.down * 19;
        yellowwindow.transform.position += Vector3.up * 19;
        if (!Script.snake2.work)
            button2.GetComponent<Button>().interactable = true;
        if (!Script.snake3.work)
            button3.GetComponent<Button>().interactable = true;
        if (!Script.snake1.work)
            button1.GetComponent<Button>().interactable = true;
        check4 = false;
        remove4.transform.position += Vector3.up * 19;
        text.text = "";
        start.GetComponent<Button>().interactable = true;
    }

    void Check()
    {
        Window.transform.position += Vector3.up * 19;
        if (wasd.transform.position.y < 0)
        {
            wasd.transform.position += Vector3.up * 19;
            wasd.GetComponent<SpriteRenderer>().color = color;
        }
        if (arrows.transform.position.y < 0)
        {
            arrows.transform.position += Vector3.up * 19;
            arrows.GetComponent<SpriteRenderer>().color = color;
        }
        if (gamepad1.transform.position.y < 0)
        {
            gamepad1.transform.position += Vector3.up * 19;
            gamepad1.GetComponent<SpriteRenderer>().color = color;
        }
        if (gamepad2.transform.position.y < 0)
        {
            gamepad2.transform.position += Vector3.up * 19;
            gamepad2.GetComponent<SpriteRenderer>().color = color;
        }
        Window.GetComponent<SpriteRenderer>().color = text.color = color;
        text.text = "Use one of the these buttons or sticks";
        button1.GetComponent<Button>().interactable = button2.GetComponent<Button>().interactable = button3.GetComponent<Button>().interactable = button4.GetComponent<Button>().interactable = start.GetComponent<Button>().interactable = false;
    }

    public void Remove1()
    {
        Script.snake1 = new Script.Snake(Script.nullcontrol, false);
        remove1.transform.position += Vector3.down * 19;
        greenwindow.transform.position += Vector3.down * 19;
        if(arrows.transform.position.x == 4)
            arrows.transform.position = new Vector3(17.25f, -9.9f, 80);
        else if(wasd.transform.position.x == 4)
                wasd.transform.position = new Vector3(11.75f, -9.9f, 80);
        else if (gamepad1.transform.position.x == 4)
            gamepad1.transform.position = new Vector3(11.75f, -13.6f, 80);
        else
            gamepad1.transform.position = new Vector3(17.25f, -13.6f, 80);
        button1.GetComponent<Button>().interactable = true;
        if (!Script.snake1.work && !Script.snake2.work && !Script.snake3.work && !Script.snake4.work)
            start.GetComponent<Button>().interactable = false;
    }

    public void Remove2()
    {
        Script.snake2 = new Script.Snake(Script.nullcontrol, false);
        remove2.transform.position += Vector3.down * 19;
        redwindow.transform.position += Vector3.down * 19;
        if (arrows.transform.position.x == 11)
            arrows.transform.position = new Vector3(17.25f, -9.9f, 80);
        else if (wasd.transform.position.x == 11)
            wasd.transform.position = new Vector3(11.75f, -9.9f, 80);
        else if (gamepad1.transform.position.x == 11)
            gamepad1.transform.position = new Vector3(11.75f, -13.6f, 80);
        else
            gamepad1.transform.position = new Vector3(17.25f, -13.6f, 80);
        button2.GetComponent<Button>().interactable = true;
        if (!Script.snake1.work && !Script.snake2.work && !Script.snake3.work && !Script.snake4.work)
            start.GetComponent<Button>().interactable = false;
    }

    public void Remove3()
    {
        Script.snake3 = new Script.Snake(Script.nullcontrol, false);
        remove3.transform.position += Vector3.down * 19;
        bluewindow.transform.position += Vector3.down * 19;
        if (arrows.transform.position.x == 18)
            arrows.transform.position = new Vector3(17.25f, -9.9f, 80);
        else if (wasd.transform.position.x == 18)
            wasd.transform.position = new Vector3(11.75f, -9.9f, 80);
        else if (gamepad1.transform.position.x == 18)
            gamepad1.transform.position = new Vector3(11.75f, -13.6f, 80);
        else
            gamepad1.transform.position = new Vector3(17.25f, -13.6f, 80);
        button3.GetComponent<Button>().interactable = true;
        if (!Script.snake1.work && !Script.snake2.work && !Script.snake3.work && !Script.snake4.work)
            start.GetComponent<Button>().interactable = false;
    }

    public void Remove4()
    {
        Script.snake4 = new Script.Snake(Script.nullcontrol, false);
        remove4.transform.position += Vector3.down * 19;
        yellowwindow.transform.position += Vector3.down * 19;
        if (arrows.transform.position.x == 25)
            arrows.transform.position = new Vector3(17.25f, -9.9f, 80);
        else if (wasd.transform.position.x == 25)
            wasd.transform.position = new Vector3(11.75f, -9.9f, 80);
        else if (gamepad1.transform.position.x == 25)
            gamepad1.transform.position = new Vector3(11.75f, -13.6f, 80);
        else
            gamepad1.transform.position = new Vector3(17.25f, -13.6f, 80);
        button4.GetComponent<Button>().interactable = true;
        if (!Script.snake1.work && !Script.snake2.work && !Script.snake3.work && !Script.snake4.work)
            start.GetComponent<Button>().interactable = false;
    }

    public void StartGame()
    {
        button1.GetComponent<Image>().enabled = button2.GetComponent<Image>().enabled = button3.GetComponent<Image>().enabled = button4.GetComponent<Image>().enabled = start.GetComponent<Image>().enabled = remove1.GetComponent<Image>().enabled = remove2.GetComponent<Image>().enabled = remove3.GetComponent<Image>().enabled = remove4.GetComponent<Image>().enabled = false;
        if (greenwindow.transform.position.y == 11.5)
            greenwindow.transform.position += Vector3.up * 19;
        if (redwindow.transform.position.y == 11.5)
            redwindow.transform.position += Vector3.up * 19;
        if (bluewindow.transform.position.y == 11.5)
            bluewindow.transform.position += Vector3.up * 19;
        if (yellowwindow.transform.position.y == 11.5)
            yellowwindow.transform.position += Vector3.up * 19;
        if (arrows.transform.position.y == 9)
            arrows.transform.position += Vector3.up * 19;
        if (wasd.transform.position.y == 9)
            wasd.transform.position += Vector3.up * 19;
        if (gamepad1.transform.position.y == 9)
            gamepad1.transform.position += Vector3.up * 19;
        if (gamepad2.transform.position.y == 9)
            gamepad2.transform.position += Vector3.up * 19;
    }
}