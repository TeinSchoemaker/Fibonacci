using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence : MonoBehaviour
{
    public Text fibonacciText;

    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    public Image image6;
    public Image image7;
    public Image image8;

    public AudioSource mario;
    
    public int n = 1;

    private void Update()
    {
        switch (n)
        {
            case 1:
                fibonacciText.transform.position = image1.transform.position;
                break;
            case 2:
                fibonacciText.transform.position = image2.transform.position;
                break;
            case 3:
                fibonacciText.transform.position = image3.transform.position;
                break;
            case 4:
                fibonacciText.transform.position = image4.transform.position;
                break;
            case 5:
                fibonacciText.transform.position = image5.transform.position;
                break;
            case 6:
                fibonacciText.transform.position = image6.transform.position;
                break;
            case 7:
                fibonacciText.transform.position = image7.transform.position;
                break;
            case 8:
                fibonacciText.transform.position = image8.transform.position;
                break;
        }
    }

    public void ButtonPress()
    {
        fibonacciText.enabled = true;
        int number = Fib(n);
        fibonacciText.text = number.ToString();
        n++;

        StartCoroutine(musicalNote());
    }

    public static int Fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fib(n - 1) + Fib(n - 2);
        }
    }

    IEnumerator musicalNote()
    {
        mario.Play();
        yield return new WaitForSeconds(0.4f);
        mario.Pause();
    }
}
