using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clicker : MonoBehaviour
{
    public int score;
    public Text textNum;
    // private spavn spavn_evel;
    // Start is called before the first frame update
    public void addNum(int addNum){
        score += addNum;
        textNum.text = "счет "+ score.ToString();
    }
}
