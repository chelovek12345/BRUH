using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //Здоровье НПС
    int health = 4;

    //Уровень НПс
    int level = 2;

    //Скорость НПС
    int speed = 3;

    Vector3 newPosition;
    


    // Start is called before the first frame update
    void Start()
    {
        health += level;

        print(health);
       
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.x += speed * Time.deltaTime;
        transform.position = newPosition;

    }
}

,klknlknlknlnkn