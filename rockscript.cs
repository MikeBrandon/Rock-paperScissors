using UnityEngine;
using UnityEngine.UI;

public class rockscript : MonoBehaviour
{
    int varx;
    public Text result;
    public Text largy;
    public GameObject largystyle;
    public void rock()
    {
        varx = PlayerPrefs.GetInt("choice");
        Debug.Log(varx);
        if (varx == 1)
        {
            largystyle.SetActive(false);
            Debug.Log("Draw");
            result.text = "I also draw a Rock and Therefore its a";
            largy.text = "DRAW";
            largystyle.SetActive(true);
        }
        else
            if(varx == 2)
        {
            largystyle.SetActive(false);
            Debug.Log("Loss");
            result.text = "Draw Paper and Therefore You";
            largy.text = "LOST";
            largystyle.SetActive(true);
        }
        else
            if(varx == 3)
        {
            largystyle.SetActive(false);
            Debug.Log("win");
            result.text = "I draw Scissors and Therefore You";
            largy.text = "WIN";
            largystyle.SetActive(true);
        }
    }
}
