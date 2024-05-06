using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamageFromFireball();
      print("Player health:" + y);
        int y = TakeDamageFromFireball(25);
        print("Player health: " + z);
        int z = TakeDamageFromFireball(30, 50);
        print("player health: " + z);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
