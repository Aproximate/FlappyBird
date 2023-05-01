using UnityEngine;
using Unity.Notifications.Android;

public class NotificationsPusher : MonoBehaviour
{
    private void Awake()
    {
        var mainChannel = new AndroidNotificationChannel()
        {
            Name = "Main | Основные",
            Description = "Основные уведомления",
            Id = "main",
            Importance = Importance.Default
        };

        AndroidNotificationCenter.RegisterNotificationChannel(mainChannel);
        AndroidNotificationCenter.CancelAllNotifications();

        Push();
    }

    private void Push()
    {
        var notification = new AndroidNotification()
        {
            Title = "Flappy Bird",
            Text = "Вы давно не заходили! Пора покорять новые рекорды!",
            SmallIcon = "small_icon",
            LargeIcon = "large_icon",
            Style = NotificationStyle.BigTextStyle,
            FireTime = System.DateTime.Now.AddHours(1),
            RepeatInterval = System.TimeSpan.FromHours(2)
        };

        AndroidNotificationCenter.SendNotification(notification, "main");
    }
}