﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirection;
    // 1 ----> need bottom door
    // 2 ----> need top door
    // 3 ----> need left door
    // 4 ----> need right door


     void Update()
    {
        if (openingDirection == 1)
        {
            // need to spawn a room with a Bottom door
        }
        else if (openingDirection ==2)
        {
            // need to spawn a room with a Top door
        }
        else if (openingDirection == 3)
        {
            // need to spawn a room with a left door
        }
        else if (openingDirection == 4)
        {
            // need to spawn a room with a right door
        }
    }
}
