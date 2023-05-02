using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInitialize : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField] private string _androidGameId = "5265435";
    [SerializeField] private string _iosGameId = "5265434";

    [SerializeField] private bool _isTestMode;

    private string _gameId;


    private void Awake()
    {
        InitializeAds();
    }

    private void InitializeAds()
    {
        _gameId = Application.platform == RuntimePlatform.Android ? _androidGameId : _iosGameId;
        Advertisement.Initialize(_gameId, _isTestMode, this);
    }

    public void OnInitializationComplete()
    {
        Debug.Log("Реклама инициализирована!");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.LogError($"Реклама не инициализирована! Ошибка - {error}, потому что - {message}");
    }
}
