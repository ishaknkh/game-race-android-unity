using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Header("Timer")]
    public float countDownTimer = 5f;

    [Header("Things To Stop")]
    public PlayerCarController playerCarController;
    public PlayerCarController playerCarController1;
    public PlayerCarController playerCarController2;
    public PlayerCarController playerCarController3;
    public PlayerCarController playerCarController4;
    public PlayerCarController playerCarController5;
    public PlayerCarController playerCarController6;
    public PlayerCarController playerCarController7;
    public OpponentCar opponentCar;
    public OpponentCar opponentCar1;
    //public OpponentCar opponentCar2;
    //public OpponentCar opponentCar2;
    //public OpponentCar opponentCar3;
    public Text countDownText;

    void Start()
    {
        StartCoroutine(TimeCount()); 
    }

    void Update()
    {
        if(countDownTimer > 1)
        {
            playerCarController.accelerationForce = 0f;
            playerCarController1.accelerationForce = 0f;
            playerCarController2.accelerationForce = 0f;
            playerCarController3.accelerationForce = 0f;
            playerCarController4.accelerationForce = 0f;
            playerCarController5.accelerationForce = 0f;
            playerCarController6.accelerationForce = 0f;
            playerCarController7.accelerationForce = 0f;
            opponentCar.movingSpeed = 0f;
            opponentCar1.movingSpeed = 0f;
            //opponentCar2.movingSpeed = 0f;
            //opponentCar2.movingSpeed = 0f;
            //opponentCar3.movingSpeed = 0f;
        }
        else if(countDownTimer == 0)
        {
            playerCarController.accelerationForce = 250f;
            playerCarController1.accelerationForce = 250f;
            playerCarController2.accelerationForce = 250f;
            playerCarController3.accelerationForce = 250f;
            playerCarController4.accelerationForce = 250f;
            playerCarController5.accelerationForce = 250f;
            playerCarController6.accelerationForce = 250f;
            playerCarController7.accelerationForce = 250f;
            opponentCar.movingSpeed = 10f;
            opponentCar1.movingSpeed = 10f;
            //opponentCar2.movingSpeed = 10f;
            //opponentCar2.movingSpeed = 10f;
            //opponentCar3.movingSpeed = 10f;
        }
    }

    IEnumerator TimeCount()
    {
        while(countDownTimer > 0)
        {
            countDownText.text = countDownTimer.ToString();
            yield return new WaitForSeconds(1f);
            countDownTimer--;
        }
        countDownText.text = "GO!!!";
        yield return new WaitForSeconds(1f);
        countDownText.gameObject.SetActive(false);
    }
}
