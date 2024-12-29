namespace WinFormsApp.Utils
{
    public static class DataUpdateEvent
    {
        public static event EventHandler CarListChanged;
        public static event EventHandler PermissionChanged;

        public static void NotifyCarListChanged()
        {
            CarListChanged?.Invoke(null, EventArgs.Empty);
        }

        public static void NotifyPermissionChanged()
        {
            PermissionChanged?.Invoke(null, EventArgs.Empty);
        }
    }
} 