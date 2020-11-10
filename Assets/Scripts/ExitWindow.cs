using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitWindow : MonoBehaviour
{
    public Button exitWindowButton;
    public Image window;
    [SerializeField]
    private GameObject tip1Art, tip2Art, tip3Art, tip4Art, tip1ArtOpen, tip2ArtOpen, tip3ArtOpen, tip4ArtOpen, tipImage;

    void Start()
    {
        exitWindowButton.onClick.AddListener(ExitThisWindow);
    }

    void ExitThisWindow()
    {
        tipImage.SetActive(false);
        tip1Art.SetActive(true);
        tip2Art.SetActive(true);
        tip3Art.SetActive(true);
        tip4Art.SetActive(true);
        tip1ArtOpen.SetActive(false);
        tip2ArtOpen.SetActive(false);
        tip3ArtOpen.SetActive(false);
        tip4ArtOpen.SetActive(false);
        window.gameObject.SetActive(false);
    }
}
