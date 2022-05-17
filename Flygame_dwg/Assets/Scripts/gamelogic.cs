using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamelogic : MonoBehaviour
{

    public enum PlayerDirection {NONE=0, LEFT = 1, RIGHT = 2, UP = 3, DOWN=4 };

    public PlayerDirection PLAYER_DIR = PlayerDirection.NONE;

    public static gamelogic instance;
    public static  float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        switch ( PLAYER_DIR )
        {
            case PlayerDirection.LEFT:
                this.transform.position += new Vector3(-0.1f * speed * Time.fixedDeltaTime, 0,0);
                break;
            case PlayerDirection.RIGHT:
                this.transform.position += new Vector3(0.1f * speed * Time.fixedDeltaTime, 0, 0);
                break;
            case PlayerDirection.UP:
                this.transform.position += new Vector3(0, 0.1f * speed * Time.fixedDeltaTime, 0);
                break;
            case PlayerDirection.DOWN:
                this.transform.position += new Vector3(0, -0.1f * speed * Time.fixedDeltaTime,  0);
                break;
        }
    }
}
