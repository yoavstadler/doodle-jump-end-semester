using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_script : MonoBehaviour
{
    // הגדרת משתנים
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = Player.GetComponent<Rigidbody>();
        if (rb.velocity.y > 7) // במידה והשחקן עובר מהירות מסויימת (בעזרת פלטפורמת בוסט או יכולת בוסט)ץ
        {
            transform.position = new Vector3(Player.transform.position.x , Player.transform.position.y -1.2f , -0.3f); // שינוי מיקום האש כדי ליצור אפקט של הווצרות והעלמות
        }
        else
        {
            transform.position = new Vector3(Player.transform.position.x , Player.transform.position.y - 1.2f , 0.1f);
        }

      
    }
}
