using Android.Content;

namespace Task2
{
    [BroadcastReceiver]
    class Alarm : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            if (intent.Action == "MY_ALARM_RECEIVED")
            {
                if (ForegroundService.mySocketConnected == false)
                {
                    ForegroundService._globalService.cancelAlarm(context);
                    ForegroundService._globalService.Baglanti_Kur();
                }
            }
        }
    }
}