namespace EventEase
{
    public class UserSessionService
    {
        // Tracks the user's name
        public string CurrentUserName { get; private set; } = string.Empty;
        
        // Quick check to see if someone is "logged in"
        public bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUserName);
        
        // Tracks the IDs of events the user has registered for
        public List<int> RegisteredEventIds { get; private set; } = new();

        // This event tells Blazor components to refresh when data changes
        public event Action? OnChange;

        public void SetUser(string userName)
        {
            CurrentUserName = userName;
            NotifyStateChanged();
        }

        public void RegisterForEvent(int eventId)
        {
            if (!RegisteredEventIds.Contains(eventId))
            {
                RegisteredEventIds.Add(eventId);
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}