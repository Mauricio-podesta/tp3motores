using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] float Speedvalue = 5f;
    public float hp = 10f;
    public Text hpplayerTXT;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   
    }
    void Update()
    { float movementbackfoward =  Input.GetAxis("Vertical") * Speedvalue;
        float movementrigthleft = Input.GetAxis("Horizontal") * Speedvalue;
        movementbackfoward *= Time.deltaTime;
        movementrigthleft *= Time.deltaTime;
        transform.Translate(movementrigthleft, 0, movementbackfoward);
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
        hpplayerTXT.text = "life" + hp.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bot"))
        {
            TakeDamage();
        }
    }
    public void TakeDamage()
    {
        hp = hp - 2f;
        if (hp == 0)
        {
            LoseMenssage.show();
            Time.timeScale = 0;
            LoseMenssage.Lose = true;
        }
    }
}
