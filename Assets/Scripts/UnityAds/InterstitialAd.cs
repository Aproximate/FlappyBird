using UnityEngine;
using UnityEngine.Advertisements;

public class InterstitialAd : AdLoader, IUnityAdsLoadListener, IUnityAdsShowListener
{
    #region Interafases
    public void OnUnityAdsAdLoaded(string placementId) 
    {
        Debug.Log("������� ���������!");
    }
    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message) { }
    public void OnUnityAdsShowStart(string placementId) { }
    public void OnUnityAdsShowClick(string placementId) { }
    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message) { }
    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState) 
    {
        LoadAd();
    }
    #endregion

    protected override void LoadAd()
    {
        Debug.Log($"������� �����������! ��� ������� - {AdId}");
        Advertisement.Load(AdId, this);
    }

    public void ShowAd()
    {
        Debug.Log($"������� ������������! ��� ������� - {AdId}");
        Advertisement.Show(AdId, this);
    }
}