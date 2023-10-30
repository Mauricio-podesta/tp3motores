using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Bot;
    [SerializeField] Transform Spawnbotposition;
    [SerializeField] Transform Spawnbotposition2;
    [SerializeField] Transform Spawnbotposition3;
    [SerializeField] Transform Spawnbotposition4;
    public Text TimeTXT;
    public float TimeGame = 30f;
    void Start()
    {
        Startgame();
        InvokeRepeating( "Spawn", 4f, 3f);
        InvokeRepeating("Spawn2", 8f, 3f);
        InvokeRepeating("Spawn3", 12f, 3f);
        InvokeRepeating("Spawn4", 16f, 3f);
    }
    void Update()
    {
        if(TimeGame == 0)
        {
            VictoryMenssage.show();
            Time.timeScale = 0;
            VictoryMenssage.Victory = true;
        }
        TimeTXT.text = "Survive: " + TimeGame.ToString();
    }
    void Startgame()
    {
        Player.transform.position = new Vector3(0f, 0f, 0f);
        StartCoroutine(Comenzarcronometro(30));
     
    }
    public IEnumerator Comenzarcronometro (float valorcronometro = 30) { 
        TimeGame = valorcronometro;
        while (TimeGame > 0)
        {
            yield return new WaitForSeconds(1.0f);
            TimeGame--;
        }
    }   
    void Spawn()
    {
        GameObject NewBOT =Instantiate(Bot, Spawnbotposition.position, Quaternion.identity);     
    }
    void Spawn2()
    {
        GameObject NewBOT = Instantiate(Bot, Spawnbotposition2.position, Quaternion.identity);
    }
    void Spawn3()
    {
        GameObject NewBOT = Instantiate(Bot, Spawnbotposition3.position, Quaternion.identity);
    }
    void Spawn4()
    {
        GameObject NewBOT = Instantiate(Bot, Spawnbotposition4.position, Quaternion.identity);
    }
}