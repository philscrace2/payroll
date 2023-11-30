namespace PayrollGuiWinformsImpl.util
{
    public class EventQueueAsyncEventBus
    {
        private SynchronizationContext _context;

        public EventQueueAsyncEventBus()
        {
            // Capture the synchronization context of the UI thread (assuming this constructor is called on the UI thread)
            _context = SynchronizationContext.Current;
        }

        public void Post(Action eventAction)
        {
            PostWithEventQueue(eventAction);
        }

        private void PostWithEventQueue(Action eventAction)
        {
            _context.Post(_ => eventAction(), null);
        }
    }

}
