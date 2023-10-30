using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenssage : MonoBehaviour
{
    public GameObject VictoryText;
    public static GameObject VictoryStatic;
    public static bool Victory;
    public GameObject VictoryImage;
    public static GameObject VictoryImageStatic;
    void Start()
    {
        Victory = false;
        VictoryMenssage.VictoryStatic = VictoryText;
        VictoryMenssage.VictoryStatic.gameObject.SetActive(false);
        VictoryMenssage.VictoryImageStatic= VictoryImage;
        VictoryMenssage.VictoryImageStatic.gameObject.SetActive(false);

    }
    private void Update()
    {
        if (Victory == true)
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1;
            }
    }
    public static void show()
    {
        VictoryMenssage.VictoryStatic.gameObject.SetActive(true);
        VictoryMenssage.VictoryImageStatic.gameObject.SetActive(true);

    }
}
