using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinScriptFunction : MonoBehaviour
{
    public int Collected = 0;
    [SerializeField] TextMeshProUGUI Collected_Value;
    public UnityEvent CoinFunction;

    private void OnTriggerEnter(Collider other)
    {
        CoinFunction.Invoke();
        Collected = Collected + 1;
        Collected_Value.text = Collected.ToString();
        if (Collected > 6)
        {
            SceneManager.LoadScene(2);
        }
    }
}
