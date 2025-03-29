using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Function to load a specific scene by name
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Function to load Scene 1
    public void LoadH2O()
    {
        SceneManager.LoadScene("H2O");
    }

    // Function to load Scene 2
    public void LoadNH3()
    {
        SceneManager.LoadScene("NH3");
    }

    // Function to load Scene 3
    public void LoadHCN()
    {
        SceneManager.LoadScene("HCN");
    }

    // Function to load Scene 4
    public void LoadCH4()
    {
        SceneManager.LoadScene("CH4");
    }

    // Function to load Scene 5
    public void LoadBoric()
    {
        SceneManager.LoadScene("Boric");
    }
}
