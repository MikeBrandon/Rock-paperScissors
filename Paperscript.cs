using UnityEngine;
using UnityEngine.UI;

public class Paperscript : MonoBehaviour
{
    int varx;
    public Text result;
    public Text largy;
    public GameObject largystyle;
    public void paper()
    {
        varx = PlayerPrefs.GetInt("choice");
        Debug.Log(varx);
        if (varx == 1)
        {
            largystyle.SetActive(false);
            Debug.Log("Win");
            result.text = "I draw a Rock and Therefore You";
            largy.text = "WIN";
            largystyle.SetActive(true);
        }
        else
            if (varx == 2)
        {
            largystyle.SetActive(false);
            Debug.Log("Draw");
            result.text = "I also Draw Paper and Therefore Its A";
            largy.text = "DRAW";
            largystyle.SetActive(true);
        }
        else
            if (varx == 3)
        {
            largystyle.SetActive(false);
            Debug.Log("Loss");
            result.text = "I draw Scissors and Therefore You";
            largy.text = "LOST";
            largystyle.SetActive(true);
        }
    }
}
