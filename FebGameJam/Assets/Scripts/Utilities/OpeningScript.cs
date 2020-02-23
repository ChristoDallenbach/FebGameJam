using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningScript : MonoBehaviour
{
    private float counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;

        if(counter > 26)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Gameplay");
        }
    }
}
