using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject[] players;
    [SerializeField] TMP_Dropdown playersSelect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Select Player Number
        if (playersSelect.value == 0)
        {
            // 2 Players
            players[1].SetActive(true);
            players[2].SetActive(false);
            players[3].SetActive(false);
            PlayerPrefs.SetInt("PlayerNumber", 2);
        }
        else if (playersSelect.value == 1)
        {
            // 3 Players
            players[1].SetActive(true);
            players[2].SetActive(true);
            players[3].SetActive(false);
            PlayerPrefs.SetInt("PlayerNumber", 3);
        }
        else if (playersSelect.value == 2)
        {
            // 4 Players
            players[1].SetActive(true);
            players[2].SetActive(true);
            players[3].SetActive(true);
            PlayerPrefs.SetInt("PlayerNumber", 4);
        }
    }
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("GameScene");
    }
}
