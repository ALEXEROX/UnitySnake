using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Script : MonoBehaviour
{
    public GameObject Head, Body, Bone, Apple;

    class Snake
    {
        public Pos[] body;
        public Pos[] spine;
        public Pos[] direction;
        public Pos[] futuredirection;
        public Snake(Pos[] body, Pos[] spine, Pos[] direction, Pos[] futuredirection)
        {
            this.body = body;
            this.spine = spine;
            this.direction = direction;
            this.futuredirection = futuredirection;
        }
    }
    class Pos
    {
        public int x;
        public int y;
        public Pos(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    private void Start()
    {

    }
}
