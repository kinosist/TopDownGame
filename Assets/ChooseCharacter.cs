using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChooseCharacter : MonoBehaviour
{
    [SerializeField] GameObject player;
    public int gamepadId;
    private List<Transform> characters;
    private int _selected = 0;

    bool isRight = false;
    bool isLeft = false;
    bool isChange = false;

    // Start is called before the first frame update
    void Start()
    {
        characters = new List<Transform>();
        foreach (Transform childTransform in player.transform)
        {
            characters.Add(childTransform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamepad.all.Count > gamepadId) 
        {
            // gamepadIdのゲームパッドが存在
            var dpadValue = Gamepad.all[gamepadId].dpad.ReadValue();
            // 十字ボタンでキャラ選択
            if (dpadValue.normalized.x * dpadValue.magnitude > 0)
            {
                if (isChange)
                {
                    isRight = false;
                }
                else
                {
                    isRight = true;
                    isChange= true;
                }
            }
            else if (dpadValue.normalized.x * dpadValue.magnitude < 0)
            {
                if (isChange)
                {
                    isLeft = false;
                }
                else
                {
                    isLeft = true;
                    isChange = true;
                }
            }
            else
            {
                isRight = false;
                isLeft = false;
                isChange = false;
            }

            if (isRight)
            {
                characters[_selected].gameObject.SetActive(false);
                _selected++;
                if (_selected >= characters.Count)
                    _selected = 0;
                characters[_selected].gameObject.SetActive(true);
                PlayerPrefs.SetInt("Character" + gamepadId.ToString(), _selected);
            }
            if (isLeft)
            {
                characters[_selected].gameObject.SetActive(false);
                _selected--;
                if (_selected < 0)
                    _selected = characters.Count - 1;
                characters[_selected].gameObject.SetActive(true);
                PlayerPrefs.SetInt("Character" + gamepadId.ToString(), _selected);
            }

        }
    }

}
