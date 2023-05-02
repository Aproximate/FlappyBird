using UnityEngine;

public abstract class AdLoader : MonoBehaviour
{
    [SerializeField] private string _iosAdId;
    [SerializeField] private string _androidAdId;

    public string AdId { get; private set; }


    private void Awake()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            AdId = _androidAdId;
        }
        else
        {
            AdId = _iosAdId;
        }

        LoadAd();
    }

    protected abstract void LoadAd();
}