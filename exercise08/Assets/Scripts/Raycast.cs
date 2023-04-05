using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    RaycastHit outInfo;
    LayerMask LM;
    public GameObject GoldKeyInfo;
    public GameObject SilverKeyInfo;
    public GameObject KeyholeInfo;
    public GameObject goldKeyholeInfo;
    public GameObject silverKeyholeInfo;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "fancyGoldKey")
        {
            GoldKeyInfo.SetActive(true);
        }
        else
        {
            GoldKeyInfo.SetActive(false);
        }

        if (other.gameObject.tag == "fancySilverKey")
        {
            SilverKeyInfo.SetActive(true);
        }
        else
        {
            SilverKeyInfo.SetActive(false);
        }

        if (other.gameObject.tag == "ironKeyhole")
        {
            silverKeyholeInfo.SetActive(true);
        }
        else
        {
            silverKeyholeInfo.SetActive(false);
        }

        if (other.gameObject.tag == "finalKeyhole")
        {
            goldKeyholeInfo.SetActive(true);
        }
        else
        {
            goldKeyholeInfo.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "fancyGoldKey")
        {
            GoldKeyInfo.SetActive(false);
        }

        if (other.gameObject.tag == "fancySilverKey")
        {
            SilverKeyInfo.SetActive(false);
        }

        if (other.gameObject.tag == "ironKeyhole")
        {
            silverKeyholeInfo.SetActive(false);
        }

        if (other.gameObject.tag == "finalKeyhole")
        {
            goldKeyholeInfo.SetActive(false);
        }
    }
}
