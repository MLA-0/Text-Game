using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textgame : MonoBehaviour
{
    int min = 1;
    int max = 100;
    int guess = min + max / 2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Witaj w liczbowym czarodzieju");
        Debug.Log("Pomyśl o liczbie od 1 do 100 ale nie wypowiadaj jej na głos");
        Debug.Log("Czy twoja liczba jest większa czy mniejsza od 50?");
        Debug.log("Jeżeli twoja liczba jest większa naciśnij strzałkę w górę, jeżeli mniejsza w dół");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Czy twoja liczba to " + guess "?");
            min = guess;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Czy twoja liczba to " + guess "?");
            max = guess;
        }

        if (input.GetKeyDown(KeyCode.Return))
        {
            print("Odgadłem twoją liczbę");
        }

    }
}