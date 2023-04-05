using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    public PlayerController player;
    public float moveSpeed = 10f;
    public float rotateSpeed = 120f;
    public GameObject onObtainKey;
    int keyNumber;
    public TextMeshProUGUI keyNoText;
    public TextMeshProUGUI feedbackText;
    public GameObject goldKey;
    public GameObject silverKey;
    public GameObject goldKeyhole;
    public GameObject silverKeyhole;
    public GameObject GoldKeyInfo;
    public GameObject SilverKeyInfo;
    public GameObject goldKeyholeInfo;
    public GameObject silverKeyholeInfo;
    public Animator anim1;
    public Animator anim2;
    bool insert1;
    bool insert2;
    public GameObject gameOverText; 

    public void GetGoldenKey()
    {
        onObtainKey.SetActive(true);
        keyNumber += 1;
        keyNoText.text = keyNumber.ToString();
        anim1.SetTrigger("Set");
        goldKey.SetActive(false);
        GoldKeyInfo.SetActive(false);
    }

    public void GetSilverKey()
    {        
        keyNumber += 1;
        keyNoText.text = keyNumber.ToString();
        onObtainKey.SetActive(true);
        silverKey.SetActive(false);
        SilverKeyInfo.SetActive(false);
    }

    public void InsertGoldKeyhole()
    {
        if(keyNumber == 0)
        {
            feedbackText.text = "You don't have the key.";
            feedbackText.enabled = true;
            anim2.SetTrigger("Active");
        }
        else
        {
            feedbackText.text = "You opened the keyhole.";
            feedbackText.enabled = true;
            anim2.SetTrigger("Active");
            goldKeyholeInfo.SetActive(false);
            goldKeyhole.SetActive(false);
            keyNumber -= 1;
            keyNoText.text = keyNumber.ToString();
            onObtainKey.SetActive(true);
            anim1.SetTrigger("Set");
            insert1 = true; 
        }
    }

    public void InsertSilverKeyhole()
    {
        if (keyNumber == 0)
        {
            feedbackText.text = "You don't have the key.";
            feedbackText.enabled = true;
            anim2.SetTrigger("Active");
        }
        else
        {
            feedbackText.text = "You opened the keyhole.";
            feedbackText.enabled = true;
            anim2.SetTrigger("Active");
            silverKeyholeInfo.SetActive(false);
            silverKeyhole.SetActive(false);
            keyNumber -= 1;
            keyNoText.text = keyNumber.ToString();
            onObtainKey.SetActive(true);
            anim1.SetTrigger("Set");
            insert2 = true; 
        }
    }

    private void Update()
    {
        if (insert1 && insert2)
        {
            gameOverText.SetActive(true);
        }
    }
}
