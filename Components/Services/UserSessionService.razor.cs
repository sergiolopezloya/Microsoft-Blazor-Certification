using System;

namespace EventEase.Services
{
    public class UserSessionService
    {
        public event Action? OnChange;
        private bool _isAuthenticated;
        private string _currentUserId = string.Empty;
        private string _userName = string.Empty;

        public bool IsAuthenticated 
        { 
            get => _isAuthenticated;
            private set
            {
                _isAuthenticated = value;
                NotifyStateChanged();
            }
        }

        public string CurrentUserId
        {
            get => _currentUserId;
            private set
            {
                _currentUserId = value;
                NotifyStateChanged();
            }
        }

        public string UserName
        {
            get => _userName;
            private set
            {
                _userName = value;
                NotifyStateChanged();
            }
        }

        public void SetUserSession(string userId, string userName)
        {
            CurrentUserId = userId;
            UserName = userName;
            IsAuthenticated = true;
        }

        public void ClearSession()
        {
            CurrentUserId = string.Empty;
            UserName = string.Empty;
            IsAuthenticated = false;
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}