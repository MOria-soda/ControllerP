using UnityEngine;


public class UIController : MonoBehaviour
{
    public GameObject Panel;
    public GameObject QuitButton;

    public void QuitApplication()
    {
        print("you have quit!");
        Panel.SetActive(false);
        Application.Quit();

    }

    public void QuitButtonApplication()
    {
        Panel.SetActive(true);
        Application.Quit();
    }

    public void CancelQuit()
    {
        Panel.SetActive(false);
    }


void Update()
    {
       if (Input.GetKeyDown("escape"))
       {
        Panel.SetActive(true);
       }

    }
}
