using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int maxNumber;
    [SerializeField] int minNumber;
    [SerializeField] TextMeshProUGUI guessNumberField;
    int guessNumber;
    private int tryCount;

    // Start is called before the first frame update
    void Start() {
        //maxNumber += 1;
        tryCount = 0;
        NextGuess();
    }

    public void OnPressHigh() {
        minNumber = guessNumber;
        NextGuess();
    }

    public void OnPressLow() {
        maxNumber = guessNumber;
        NextGuess();
    }

    void NextGuess() {

        if (maxNumber <= minNumber) {
            return;
        }

        //guessNumber = (maxNumber + minNumber) / 2;
        guessNumber = Random.Range(minNumber, maxNumber + 1);
        guessNumberField.text = guessNumber.ToString();

        tryCount++;
        Debug.Log("Max and Min numbers are " + maxNumber + " / " + minNumber);
        Debug.Log("User tries it " + tryCount + " time(s). The guess number is " + guessNumber);
    }

}