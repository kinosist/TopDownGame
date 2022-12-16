using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerDisplay : MonoBehaviour
{
    [SerializeField] GameObject[] player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Player1
        if (Gamepad.all.Count >= 1)
        {
            if (Gamepad.all[0].aButton.isPressed)
            {
                //ゲームオブジェクト非表示→表示
                player[0].SetActive(true);
            }
        }
        // Player2
        if (Gamepad.all.Count >= 2)
        {
            if (Gamepad.all[1].aButton.isPressed)
            {
                //ゲームオブジェクト非表示→表示
                player[1].SetActive(true);
            }
        }
        // Player3
        if (Gamepad.all.Count >= 3)
        {
            if (Gamepad.all[2].aButton.isPressed)
            {
                //ゲームオブジェクト非表示→表示
                player[2].SetActive(true);
            }
        }
        // Player4
        if (Gamepad.all.Count >= 4)
        {
            if (Gamepad.all[3].aButton.isPressed)
            {
                //ゲームオブジェクト非表示→表示
                player[3].SetActive(true);
            }
        }

    }
}
