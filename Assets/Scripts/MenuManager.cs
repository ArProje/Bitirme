using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SinifBes()
    {
        SceneManager.LoadScene("Sınıf5Level");
    }

    public void SinifAlti()
    {
        SceneManager.LoadScene("Sınıf6Level");
    }

    public void SinifYedi()
    {
        SceneManager.LoadScene("Sınıf7Level");
    }

    public void SinifSekiz()
    {
        SceneManager.LoadScene("Sınıf8Level");
    }

    public void BaslaGeriDon()
    {
        SceneManager.LoadScene("BaslaLevel");
    }


}
