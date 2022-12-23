using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerDisplay : MonoBehaviour
{
    [SerializeField] GameObject[] characters;

    // Start is called before the first frame update
    void Start()
    {
        var playerNumber = PlayerPrefs.GetInt("PlayerNumber", 2);

        GameObject go;
        for (int i = 1; i <= playerNumber; i++)
        {
            int select = PlayerPrefs.GetInt("Character" + (i-1).ToString(), 0);
            if (i == 1)
            {
                characters[select].GetComponent<Character>().PlayerID = "Player1";
                characters[select].GetComponentInChildren<InputManager>().PlayerID = "Player1";
                go = Instantiate(characters[select]);
                go.transform.position = new Vector3(-10, 3, 0);
            }
            if (i == 2)
            {
                characters[select].GetComponent<Character>().PlayerID = "Player2";
                characters[select].GetComponentInChildren<InputManager>().PlayerID = "Player2";
                go = Instantiate(characters[select]);
                go.transform.position = new Vector3(10, -3, 0);
            }
            if (i == 3)
            {
                characters[select].GetComponent<Character>().PlayerID = "Player3";
                characters[select].GetComponentInChildren<InputManager>().PlayerID = "Player3";
                go = Instantiate(characters[select]);
                go.transform.position = new Vector3(10, 3, 0);
            }
            if (i == 4)
            {
                characters[select].GetComponent<Character>().PlayerID = "Player4";
                characters[select].GetComponentInChildren<InputManager>().PlayerID = "Player4";
                go = Instantiate(characters[select]);
                go.transform.position = new Vector3(-10, -3, 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
