using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buton2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YenidenBasla(){
       //SceneManager.LoadScene ("oyun");
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
