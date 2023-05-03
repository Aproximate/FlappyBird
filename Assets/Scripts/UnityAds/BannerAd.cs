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
        Debug.Log("������ ��������!");
        ShowBannerAd();
    }

    private void OnBannerError(string message)
    {
        Debug.Log("������ �� ��������!" +  " - " + message);
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
        Debug.Log("������ �������");
    }

    private void OnBannerClicked()
    {
        Debug.Log("�� ������ ������!");
    }

    private void OnBannerHidden()
    {
        Debug.Log("������ �����!");
    }
}