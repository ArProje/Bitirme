using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KarikaturManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuGeriDon()
    {
        SceneManager.LoadScene("MenuLevel");
    }

    public void ArGerceklik()
    {
        SceneManager.LoadScene("ArGerceklikLevel");
    }
}
