namespace WoWCollectionTracker.BlazorWASM.Services
{
    public class StateService
    {
        public event Action OnStateChanged;

        public void NotifyStateChanged() => OnStateChanged?.Invoke();
    }
}
