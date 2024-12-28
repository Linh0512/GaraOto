namespace WinFormsApp.Utils
{
    public static class DataUpdateEvent
    {
        public static event EventHandler CarListChanged;

        public static void NotifyCarListChanged()
        {
            CarListChanged?.Invoke(null, EventArgs.Empty);
        }
    }
} 