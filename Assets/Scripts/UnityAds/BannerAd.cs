using UnityEngine;
using UnityEngine.Advertisements;

public class BannerAd : AdLoader
{
    [SerializeField] private BannerPosition _bannerPosition;


    private void Start()
    {
        Advertisement.Banner.SetPosition(_bannerPosition);
        LoadAd();
    }

    protected override void LoadAd()
    {
        BannerLoadOptions options = new BannerLoadOptions()
        {
            loadCallback = OnBannerLoaded,
            errorCallback = OnBannerError
        };

        Advertisement.Banner.Load(AdId, options);
    }

    private void OnBannerLoaded()
    {
        Debug.Log("Баннер загружен!");
        ShowBannerAd();
    }

    private void OnBannerError(string message)
    {
        Debug.Log("Баннер не загружен!" +  " - " + message);
    }

    private void ShowBannerAd()
    {
        BannerOptions options = new BannerOptions()
        {
            showCallback = OnBannerShow,
            clickCallback = OnBannerClicked,
            hideCallback = OnBannerHidden
        };
        Advertisement.Banner.Show(AdId);
    }

    private void OnBannerShow()
    {
        Debug.Log("Баннер показан");
    }

    private void OnBannerClicked()
    {
        Debug.Log("На баннер нажали!");
    }

    private void OnBannerHidden()
    {
        Debug.Log("Баннер скрыт!");
    }
}