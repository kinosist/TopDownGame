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
            // Aボタンでキャラ選択
            if (Gamepad.all[gamepadId].aButton.wasPressedThisFrame)
            {
                characters[_selected].gameObject.SetActive(false);
                _selected++;
                if (_selected >= characters.Count)
                    _selected = 0;
                characters[_selected].gameObject.SetActive(true);
                PlayerPrefs.SetInt("Character" + gamepadId.ToString(), _selected);
            }
        }
    }

}
