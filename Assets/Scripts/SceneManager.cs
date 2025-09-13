using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This class handles loading all the different scenes in the project.
/// Attach this script to a GameObject in your scene (like a GameManager or UI Canvas).
/// Then, you can link UI buttons' OnClick() events to the public functions below.
/// </summary>
public class SceneController : MonoBehaviour
{
    /// <summary>
    /// A generic function to load any scene by its name.
    /// </summary>
    /// <param name="sceneName">The exact name of the scene to load.</param>
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // --- Functions to load specific scenes ---

    public void LoadBoric()
    {
        SceneManager.LoadScene("Boric");
    }

    public void LoadCO2()
    {
        SceneManager.LoadScene("CO2");
    }

    public void LoadCube()
    {
        SceneManager.LoadScene("Cube");
    }

    public void LoadCyclohexane()
    {
        SceneManager.LoadScene("Cyclohexane");
    }

    public void LoadDifluoroDiazene()
    {
        SceneManager.LoadScene("DiflouroDiazene");
    }

    public void LoadEth_ChloBro()
    {
        SceneManager.LoadScene("Eth_ChloBro");
    }

    public void LoadFullerene()
    {
        SceneManager.LoadScene("Fullerene");
    }

    public void LoadH2O()
    {
        SceneManager.LoadScene("H2O");
    }

    public void LoadHCN()
    {
        SceneManager.LoadScene("HCN");
    }

    public void LoadMethane()
    {
        SceneManager.LoadScene("Methane");
    }

    public void LoadNH3()
    {
        SceneManager.LoadScene("NH3");
    }

    public void LoadSOCL()
    {
        SceneManager.LoadScene("SOCL");
    }

    public void LoadTetraCobalt()
    {
        SceneManager.LoadScene("TetraCobalt");
    }
}