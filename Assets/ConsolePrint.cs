using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    private int counter = 3; 

    private void Update()
    {
        counter++; 

        Debug.Log(gameObject.name + ":" + counter);
    }
}