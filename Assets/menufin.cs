using UnityEngine;
using System.Collections;

public class menufin : MonoBehaviour
{
    // Charge la scene principale
    public void Commencer()
    {
        Application.LoadLevel("Dance");
    }

    // Charge la scene du menu
    public void Menu()
    {
        Application.LoadLevel("Menu");
    }
}