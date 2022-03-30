using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Image coat;
    public Image collar;
    public Image nose;
    public Image eyes;
    public Image ears;
    public Image tails;
    public Image fluff;
    public Image barkingDobie;
    public Image barkingHusky;

    public GameObject warning;
    public GameObject screenshotButton;
    public GameObject sidePanel;
    public GameObject sidePanel2;
    public GameObject normalMusic;

    public GameObject christmasDog;
    public GameObject snow;
    public GameObject christmasMusic;
    public GameObject christmasBkg;

    public GameObject halloweenDog;
    public GameObject spiders;
    public GameObject halloweenMusic;
    public GameObject halloweenBkg;

    public AudioSource bark;

    public BlueVersion blue;

    public Toggle fluffButton;

    [SerializeField]
    private Sprite[] aCoats;
    [SerializeField]
    private Sprite[] aCollar;
    [SerializeField]
    private Sprite[] aNose;
    [SerializeField]
    private Sprite[] aEyes;
    [SerializeField]
    private Sprite[] aDobieEars;
    [SerializeField]
    private Sprite[] aHuskyEars;
    [SerializeField]
    private Sprite[] aDobieTails;
    [SerializeField]
    private Sprite[] aHuskyTails;
    [SerializeField]
    private Sprite[] aFluff;
    [SerializeField]
    private GameObject[] aButtonsNormal;
    [SerializeField]
    private GameObject[] aButtonsBlue;

    private void Update()
    {
        if (coat.sprite == aCoats[1])
        {
            if(ears.sprite == aHuskyEars[0])
            {
                ears.sprite = aDobieEars[0];
            }
            else if (ears.sprite == aHuskyEars[1])
            {
                ears.sprite = aDobieEars[1];
            }
            else if (ears.sprite == aHuskyEars[2])
            {
                ears.sprite = aDobieEars[2];
            }

            if (tails.sprite == aHuskyTails[0])
            {
                tails.sprite = aDobieTails[0];
            }
            else if (tails.sprite == aHuskyTails[1])
            {
                tails.sprite = aDobieTails[1];
            }
            if (fluff.IsActive() == true)
            {
                fluff.sprite = aFluff[0];
            }

        }
        else if (coat.sprite == aCoats[2])
        {
            if (ears.sprite == aDobieEars[0])
            {
                ears.sprite = aHuskyEars[0];
            }
            else if (ears.sprite == aDobieEars[1])
            {
                ears.sprite = aHuskyEars[1];
            }
            else if (ears.sprite == aDobieEars[2])
            {
                ears.sprite = aHuskyEars[2];
            }

            if (tails.sprite == aDobieTails[0])
            {
                tails.sprite = aHuskyTails[0];
            }
            else if (tails.sprite == aDobieTails[1])
            {
                tails.sprite = aHuskyTails[1];
            }

            if(fluff.IsActive() == true)
            {
                fluff.sprite = aFluff[1];
            }
        }
    }

    public void ChangeCoat()
    {
        if(coat.sprite == aCoats[0])
        {
            coat.sprite = aCoats[1];
            screenshotButton.SetActive(true);
        }
        else if(coat.sprite == aCoats[1])
        {
            coat.sprite = aCoats[2];
            screenshotButton.SetActive(true);
        }
        else if (coat.sprite == aCoats[2])
        {
            coat.sprite = aCoats[1];
            screenshotButton.SetActive(true);
        }
    }

    public void ChangeNoseF()
    {
        if(nose.IsActive() == false)
        {
            nose.gameObject.SetActive(true);
        }

        if (nose.sprite == aNose[0])
        {
            nose.sprite = aNose[1];
        }
        else if (nose.sprite == aNose[1])
        {
            nose.sprite = aNose[2];
        }
        else if (nose.sprite == aNose[2])
        {
            nose.sprite = aNose[0];
        }
    }

    public void ChangeNoseB()
    {
        if (nose.IsActive() == false)
        {
            nose.gameObject.SetActive(true);
        }

        if (nose.sprite == aNose[0])
        {
            nose.sprite = aNose[2];
        }
        else if (nose.sprite == aNose[1])
        {
            nose.sprite = aNose[0];
        }
        else if (nose.sprite == aNose[2])
        {
            nose.sprite = aNose[1];
        }
    }

    public void ChangeEyes()
    {
        if (eyes.IsActive() == false)
        {
            eyes.gameObject.SetActive(true);
        }

        if (eyes.sprite == aEyes[0])
        {
            eyes.sprite = aEyes[1];
        }
        else if (eyes.sprite == aEyes[1])
        {
            eyes.sprite = aEyes[0];
        }

    }

    public void ChangeCollarF()
    {
        if (collar.IsActive() == false)
        {
            collar.gameObject.SetActive(true);
        }

        if (collar.sprite == aCollar[0])
        {
            collar.sprite = aCollar[1];
        }
        else if (collar.sprite == aCollar[1])
        {
            collar.sprite = aCollar[2];
        }
        else if (collar.sprite == aCollar[2])
        {
            collar.sprite = aCollar[3];
        }
        else if (collar.sprite == aCollar[3])
        {
            collar.sprite = aCollar[4];
        }
        else if (collar.sprite == aCollar[4])
        {
            collar.sprite = aCollar[5];
        }
        else if (collar.sprite == aCollar[5])
        {
            collar.sprite = aCollar[6];
        }
        else if (collar.sprite == aCollar[6])
        {
            collar.sprite = aCollar[7];
        }
        else if (collar.sprite == aCollar[7])
        {
            collar.sprite = aCollar[8];
        }
        else if (collar.sprite == aCollar[8])
        {
            collar.sprite = aCollar[0];
        }

    }

    public void ChangeCollarB()
    {
        if (collar.IsActive() == false)
        {
            collar.gameObject.SetActive(true);
        }

        if (collar.sprite == aCollar[0])
        {
            collar.sprite = aCollar[8];
        }
        else if (collar.sprite == aCollar[1])
        {
            collar.sprite = aCollar[0];
        }
        else if (collar.sprite == aCollar[2])
        {
            collar.sprite = aCollar[1];
        }
        else if (collar.sprite == aCollar[3])
        {
            collar.sprite = aCollar[2];
        }
        else if (collar.sprite == aCollar[4])
        {
            collar.sprite = aCollar[3];
        }
        else if (collar.sprite == aCollar[5])
        {
            collar.sprite = aCollar[4];
        }
        else if (collar.sprite == aCollar[6])
        {
            collar.sprite = aCollar[5];
        }
        else if (collar.sprite == aCollar[7])
        {
            collar.sprite = aCollar[6];
        }
        else if (collar.sprite == aCollar[8])
        {
            collar.sprite = aCollar[7];
        }

    }

    public void ChangeEarsF()
    {
        if(coat.sprite == aCoats[0])
        {
            StartCoroutine(ShowWarning());
        }
        else if(coat.sprite == aCoats[1])
        {
            DobieEarChangeF();
        }
        else if (coat.sprite == aCoats[2])
        {
            HuskyEarChangeF();
        }
    }
    public void ChangeEarsB()
    {
        if (coat.sprite == aCoats[0])
        {
            StartCoroutine(ShowWarning());
        }
        else if (coat.sprite == aCoats[1])
        {
            DobieEarChangeB();
        }
        else if (coat.sprite == aCoats[2])
        {
            HuskyEarChangeB();
        }
    }

    private void HuskyEarChangeF()
    {
        if (ears.IsActive() == false)
        {
            ears.gameObject.SetActive(true);
            ears.sprite = aHuskyEars[0];
        }

        if (ears.sprite == aHuskyEars[0])
        {
            ears.sprite = aHuskyEars[1];
        }
        else if (ears.sprite == aHuskyEars[1])
        {
            ears.sprite = aHuskyEars[2];
        }
        else if (ears.sprite == aHuskyEars[2])
        {
            ears.sprite = aHuskyEars[0];
        }
    }

    private void DobieEarChangeF()
    {
        if (ears.IsActive() == false)
        {
            ears.gameObject.SetActive(true);
            ears.sprite = aDobieEars[0];
        }

        if (ears.sprite == aDobieEars[0])
        {
            ears.sprite = aDobieEars[1];
        }
        else if (ears.sprite == aDobieEars[1])
        {
            ears.sprite = aDobieEars[2];
        }
        else if (ears.sprite == aDobieEars[2])
        {
            ears.sprite = aDobieEars[0];
        }
    }

    private void HuskyEarChangeB()
    {
        if (ears.IsActive() == false)
        {
            ears.gameObject.SetActive(true);
            ears.sprite = aHuskyEars[0];
        }

        if (ears.sprite == aHuskyEars[0])
        {
            ears.sprite = aHuskyEars[2];
        }
        else if (ears.sprite == aHuskyEars[1])
        {
            ears.sprite = aHuskyEars[0];
        }
        else if (ears.sprite == aHuskyEars[2])
        {
            ears.sprite = aHuskyEars[1];
        }
    }

    private void DobieEarChangeB()
    {
        if (ears.IsActive() == false)
        {
            ears.gameObject.SetActive(true);
            ears.sprite = aDobieEars[0];
        }

        if (ears.sprite == aDobieEars[0])
        {
            ears.sprite = aDobieEars[2];
        }
        else if (ears.sprite == aDobieEars[1])
        {
            ears.sprite = aDobieEars[0];
        }
        else if (ears.sprite == aDobieEars[2])
        {
            ears.sprite = aDobieEars[1];
        }
    }

    public void ChangeTails()
    {
        if (coat.sprite == aCoats[0])
        {
            StartCoroutine(ShowWarning());
        }
        else if (coat.sprite == aCoats[1])
        {
            DobieTailChange();
        }
        else if (coat.sprite == aCoats[2])
        {
            HuskyTailChange();
        }
    }

    private void HuskyTailChange()
    {
        if (tails.IsActive() == false)
        {
            tails.gameObject.SetActive(true);
            tails.sprite = aHuskyTails[0];
        }

        if (tails.sprite == aHuskyTails[0])
        {
            tails.sprite = aHuskyTails[1];
        }
        else if (tails.sprite == aHuskyTails[1])
        {
            StartCoroutine(Bark2());
            tails.sprite = aHuskyTails[0];
        }

    }

    private void DobieTailChange()
    {
        if (tails.IsActive() == false)
        {
            tails.gameObject.SetActive(true);
            tails.sprite = aDobieTails[0];
        }

        if (tails.sprite == aDobieTails[0])
        {
            StartCoroutine(Bark1());
            tails.sprite = aDobieTails[1];
        }
        else if (tails.sprite == aDobieTails[1])
        {
            tails.sprite = aDobieTails[0];
        }
    }

    public void AddFluff()
    {
        if (coat.sprite == aCoats[0])
        {
            StartCoroutine(ShowWarning());
        }
        else if (coat.sprite == aCoats[1])
        {
            if (fluff.IsActive() == false)
            {
                fluff.gameObject.SetActive(true);
                fluff.sprite = aFluff[0];
            }
            else if (fluff.IsActive() == true)
            {
                fluff.gameObject.SetActive(false);
            }

        }
        else if (coat.sprite == aCoats[2])
        {
            if (fluff.IsActive() == false)
            {
                fluff.gameObject.SetActive(true);
                fluff.sprite = aFluff[1];
            }
            else if (fluff.IsActive() == true)
            {
                fluff.gameObject.SetActive(false);
            }
        }
    }

   public void ResetDog()
    {
        bark.Play();

        fluffButton.isOn = false;

        nose.gameObject.SetActive(false);
        eyes.gameObject.SetActive(false);
        ears.gameObject.SetActive(false);
        tails.gameObject.SetActive(false);
        fluff.gameObject.SetActive(false);
        collar.gameObject.SetActive(false);

        normalMusic.SetActive(true);
        christmasMusic.SetActive(false);
        snow.SetActive(false);
        christmasDog.SetActive(false);
        christmasBkg.SetActive(false);

        halloweenMusic.SetActive(false);
        spiders.SetActive(false);
        halloweenDog.SetActive(false);
        halloweenBkg.SetActive(false);

        coat.sprite = aCoats[0];
        nose.sprite = aNose[0];
        eyes.sprite = aEyes[0];
        collar.sprite = aCollar[0];
        ears.sprite = null;
        tails.sprite = null;
        fluff.sprite = null;

        screenshotButton.SetActive(false);

        foreach (GameObject n in aButtonsNormal)
        {
            n.gameObject.SetActive(true);
        }
        foreach (GameObject b in aButtonsBlue)
        {
            b.gameObject.SetActive(false);
        }
    }

   public void BlueButton()
    {
        ResetDog();
        blue.coat.sprite = blue.aCoatsBlue[0];
        foreach(GameObject n in aButtonsNormal)
        {
            n.gameObject.SetActive(false);
        }
        foreach (GameObject b in aButtonsBlue)
        {
            b.gameObject.SetActive(true);
        }
    }

    public void ChangePage()
    {
        if(sidePanel.activeSelf == true)
        {
            sidePanel.SetActive(false);
            sidePanel2.SetActive(true);
        }
        else if (sidePanel2.activeSelf == true)
        {
            sidePanel2.SetActive(false);
            sidePanel.SetActive(true);
        }
    }

    public void ChristmasButton()
    {
        halloweenMusic.SetActive(false);
        spiders.SetActive(false);
        halloweenDog.SetActive(false);
        halloweenBkg.SetActive(false);

        normalMusic.SetActive(false);
        christmasMusic.SetActive(true);
        christmasBkg.SetActive(true);
        snow.SetActive(true);
        christmasDog.SetActive(true);
        collar.gameObject.SetActive(false);
    }

    public void HalloweenButton()
    {
        christmasMusic.SetActive(false);
        snow.SetActive(false);
        christmasDog.SetActive(false);
        christmasBkg.SetActive(false);

        normalMusic.SetActive(false);
        halloweenMusic.SetActive(true);
        halloweenBkg.SetActive(true);
        spiders.SetActive(true);
        halloweenDog.SetActive(true);
        collar.gameObject.SetActive(false);
    }

    IEnumerator ShowWarning()
    {
        warning.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        warning.SetActive(false);
    }

    IEnumerator Bark1()
    {
        coat.sprite = barkingDobie.sprite;
        bark.Play();
        yield return new WaitForSeconds(1f);
        coat.sprite = aCoats[1];
    }
    IEnumerator Bark2()
    {
        coat.sprite = barkingHusky.sprite;
        bark.Play();
        yield return new WaitForSeconds(1f);
        coat.sprite = aCoats[2];
    }

}
