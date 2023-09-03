using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int counter = 3; 

    private void Update()
    {
        counter++; 

        Debug.Log(gameObject.name + ":" + counter);
    }
}