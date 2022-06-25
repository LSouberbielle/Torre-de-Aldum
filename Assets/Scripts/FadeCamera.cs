using UnityEngine;
using UnityEngine.UI;

public class FadeCamera : MonoBehaviour
{
    [SerializeField] private Image fadeImage;
    [SerializeField] private GameObject image;

    private void Update()
    {
        if (GameManager.Instance.playerSat)
        {
            FadeLight();
        }
    }

    private void FadeLight()
    {
        {
            image.SetActive(true);
            var fadeImageColor = fadeImage.color;
            fadeImageColor.a += 1f;
            GameManager.Instance.lightFaded = true;
        }
    }
}