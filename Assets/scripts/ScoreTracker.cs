using UnityEngine;using UnityEngine.UI;using System.Collections;public class ScoreTracker : MonoBehaviour{    private int score;    public Text text;    void Start()   {        score = 0;        }    void OnTriggerEnter(Collider other)  {        if (other.gameObject.CompareTag("Pick Up"))        {            other.gameObject.SetActive(false);            score++;            setCountText();        }    }    void setCountText()  {        if (score < 12) {
            text.text = score.ToString();
        }
        else
        {
            text.text = "You WIN!";
        }    }}