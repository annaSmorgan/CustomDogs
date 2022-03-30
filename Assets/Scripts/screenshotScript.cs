using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class screenshotScript : MonoBehaviour
{
    private int fileNumber = 0;
    private int counter = 0;
    private string folderPath = "PuppyPics/";
    private string path;

    public GameObject sidePanel;
    public GameObject sidePanel2;
    public GameObject ssButton;
    public GameObject pageButton;

    public GameObject background;
    public GameObject background2;
    public GameObject screenshotText;

    public AudioSource camera;

    private void Awake()
    {
        path = Application.dataPath;
        path += "/../"; 
        folderPath = path + folderPath;
    }
    private void Update()
    {
        if (File.Exists(Path.Combine(folderPath, "PuppyPic" + fileNumber + ".png")));
        {
            fileNumber++;
        }
        
    }
    public void TakeScreenshot()
    {
        camera.Play();

        if (counter % 2 == 0)
        {
            StartCoroutine(HidePanel());
        }
        else if (counter % 2 != 0)
        {
            StartCoroutine(HidePanel2());
        }

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        if (!File.Exists("PuppyPic" + fileNumber + ".png"))
        {
            ScreenCapture.CaptureScreenshot(Path.Combine(folderPath, "PuppyPic" + fileNumber + ".png"));
        }
    }

    private IEnumerator HidePanel()
    {
        sidePanel.SetActive(false);
        sidePanel2.SetActive(false);
        ssButton.SetActive(false);
        pageButton.SetActive(false);
        background.SetActive(true);
        yield return new WaitForSeconds(3f);
        background.SetActive(false);
        sidePanel.SetActive(true);
        sidePanel2.SetActive(true);
        ssButton.SetActive(true);
        pageButton.SetActive(true);
        StartCoroutine(ShowText());
    }
    private IEnumerator HidePanel2()
    {
        sidePanel.SetActive(false);
        sidePanel2.SetActive(false);
        ssButton.SetActive(false);
        pageButton.SetActive(false);
        background2.SetActive(true);
        yield return new WaitForSeconds(3f);
        background2.SetActive(false);
        sidePanel.SetActive(true);
        sidePanel2.SetActive(true);
        ssButton.SetActive(true);
        pageButton.SetActive(true);
        StartCoroutine(ShowText());
    }

    private IEnumerator ShowText()
    {
        screenshotText.SetActive(true);
        yield return new WaitForSeconds(1f);
        screenshotText.SetActive(false);
        counter++;
    }

}
