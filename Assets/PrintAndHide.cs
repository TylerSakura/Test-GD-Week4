using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int counter = 3; 

    private void Update()
    {
        counter++;

        if (gameObject.CompareTag("Red") && counter == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.CompareTag("Blue"))
        {
            int randomValue = Random.Range(150, 251);

            if (counter == randomValue)
            {
                rend.enabled = false;
            }
        }

        Debug.Log(gameObject.name + ":" + counter);
    }
}