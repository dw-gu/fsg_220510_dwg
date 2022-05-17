using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace dwg
{
    public class InpCtrl : MonoBehaviour
    {
        public GameObject player;

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                gamelogic.instance.PLAYER_DIR = gamelogic.PlayerDirection.LEFT;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                gamelogic.instance.PLAYER_DIR = gamelogic.PlayerDirection.RIGHT;
            }
            else if(Input.GetKeyUp(KeyCode.LeftArrow))
            {
                gamelogic.instance.PLAYER_DIR = gamelogic.PlayerDirection.NONE;
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                gamelogic.instance.PLAYER_DIR = gamelogic.PlayerDirection.NONE;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                gamelogic.instance.PLAYER_DIR = gamelogic.PlayerDirection.UP;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                gamelogic.instance.PLAYER_DIR = gamelogic.PlayerDirection.DOWN;
            }
            else if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                gamelogic.instance.PLAYER_DIR = gamelogic.PlayerDirection.NONE;
            }
            else if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                gamelogic.instance.PLAYER_DIR = gamelogic.PlayerDirection.NONE;
            }

        }
    }
}