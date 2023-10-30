using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botmovement : MonoBehaviour
{
    private int hp = 9;
    private GameObject Player;
 [SerializeField] float speed;

void Start()
    {
        Player = GameObject.Find("Player"); 
    }
    void Update()
    {
        transform.LookAt(Player.transform);
        transform.Translate(speed* Vector3.forward * Time.deltaTime);   
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            TakeDamage();
            Destroy(collision.gameObject);
        }
    }
    public void TakeDamage()
    {   
        hp = hp - 3;
        if (hp == 0)
        {
            Destroy(gameObject);
        }
    }
}