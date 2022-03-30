using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueVersion : MonoBehaviour
{
    public Image coat;
    public Image nose;
    public Image eyes;
    public Image ears;
    public Image tails;
    public Image fluff;

    public GameObject warning;
    public GameObject screenshotButton;

    [SerializeField]
    public Sprite[] aCoatsBlue;
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

    private void Update()
    {
        if (coat.sprite == aCoatsBlue[1])
        {
            if (ears.sprite == aHuskyEars[0])
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
            screenshotButton.SetActive(true);

        }
        else if (coat.sprite == aCoatsBlue[2])
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

            if (fluff.IsActive() == true)
            {
                fluff.sprite = aFluff[1];
            }
            screenshotButton.SetActive(true);
        }
    }

    public void ChangeCoat()
    {
        if (coat.sprite == aCoatsBlue[0])
        {
            coat.sprite = aCoatsBlue[1];
        }
        else if (coat.sprite == aCoatsBlue[1])
        {
            coat.sprite = aCoatsBlue[2];
        }
        else if (coat.sprite == aCoatsBlue[2])
        {
            coat.sprite = aCoatsBlue[1];
        }
    }

    public void ChangeNoseF()
    {
        if (nose.IsActive() == false)
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

    public void ChangeEarsF()
    {
        if (coat.sprite == aCoatsBlue[0])
        {
            StartCoroutine(ShowWarning());
        }
        else if (coat.sprite == aCoatsBlue[1])
        {
            DobieEarChangeF();
        }
        else if (coat.sprite == aCoatsBlue[2])
        {
            HuskyEarChangeF();
        }
    }
    public void ChangeEarsB()
    {
        if (coat.sprite == aCoatsBlue[0])
        {
            StartCoroutine(ShowWarning());
        }
        else if (coat.sprite == aCoatsBlue[1])
        {
            DobieEarChangeB();
        }
        else if (coat.sprite == aCoatsBlue[2])
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
        if (coat.sprite == aCoatsBlue[0])
        {
            StartCoroutine(ShowWarning());
        }
        else if (coat.sprite == aCoatsBlue[1])
        {
            DobieTailChange();
        }
        else if (coat.sprite == aCoatsBlue[2])
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
            tails.sprite = aDobieTails[1];
        }
        else if (tails.sprite == aDobieTails[1])
        {
            tails.sprite = aDobieTails[0];
        }
    }

    public void AddFluff()
    {
        if (coat.sprite == aCoatsBlue[0])
        {
            StartCoroutine(ShowWarning());
        }
        else if (coat.sprite == aCoatsBlue[1])
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
        else if (coat.sprite == aCoatsBlue[2])
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

    IEnumerator ShowWarning()
    {
        warning.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        warning.SetActive(false);
    }
}
