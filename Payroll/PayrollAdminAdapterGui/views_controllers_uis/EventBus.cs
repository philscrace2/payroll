namespace PayrollAdminAdapterGui.views_controllers_uis
{
    public class EventBus
    {
        private readonly Dictionary<Type, List<Delegate>> eventHandlers = new Dictionary<Type, List<Delegate>>();

        public void Register(object listener)
        {
            var listenerType = listener.GetType();
            foreach (var method in listenerType.GetMethods())
            {
                var parameters = method.GetParameters();
                if (parameters.Length == 1)
                {
                    var eventType = parameters[0].ParameterType;
                    if (!eventHandlers.ContainsKey(eventType))
                    {
                        eventHandlers[eventType] = new List<Delegate>();
                    }
                    eventHandlers[eventType].Add(Delegate.CreateDelegate(typeof(Action<>).MakeGenericType(eventType), listener, method));
                }
            }
        }

        public void Unregister(object listener)
        {
            var listenerType = listener.GetType();
            foreach (var method in listenerType.GetMethods())
            {
                var parameters = method.GetParameters();
                if (parameters.Length == 1)
                {
                    var eventType = parameters[0].ParameterType;
                    if (eventHandlers.ContainsKey(eventType))
                    {
                        eventHandlers[eventType].RemoveAll(d => d.Target == listener && d.Method == method);
                    }
                }
            }
        }

        public void Post<TEvent>(TEvent eventToPost)
        {
            if (eventHandlers.TryGetValue(typeof(TEvent), out var handlers))
            {
                foreach (var handler in handlers)
                {
                    ((Action<TEvent>)handler)(eventToPost);
                }
            }
        }
    }

}
