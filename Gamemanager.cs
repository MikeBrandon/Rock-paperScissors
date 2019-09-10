using UnityEngine;
using UnityEngine.UI;
public class Gamemanager : MonoBehaviour
{
    // Start is called before the first frame update

    public int pcchoice;
    public void pcplay()
    {
        pcchoice = Random.Range(1, 4);
        PlayerPrefs.SetInt("choice", pcchoice);
    }
}
