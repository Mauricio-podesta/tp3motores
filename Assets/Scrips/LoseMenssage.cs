using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenssage : MonoBehaviour
{
    public GameObject LoseText;
    public static GameObject LoseStatic;
    public static bool Lose;
    public GameObject LoseImage;
    public static GameObject LoseImageStatic;
    void Start()
    {
        Lose = false;
        LoseMenssage.LoseStatic = LoseText;
        LoseMenssage.LoseStatic.gameObject.SetActive(false);
        LoseMenssage.LoseImageStatic = LoseImage;
        LoseMenssage.LoseImageStatic.gameObject.SetActive(false);

    }
    private void Update()
    {
        if (Lose == true)
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1;
            }
    }
    public static void show()
    {
        LoseMenssage.LoseStatic.gameObject.SetActive(true);
        LoseMenssage.LoseImageStatic.gameObject.SetActive(true);

    }
}
