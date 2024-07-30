using ClassLibrary1;
using NGuava;

Thing();
void Thing()
{
    IEventBus bus = new EventBus();
    Controller controller = new Controller(bus);

    bus.Post(new SomeEvent());

}
