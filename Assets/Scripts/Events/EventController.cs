using System;

public class EventController
{
    public Action baseAction;

    public void addListener(Action listener) => baseAction += listener;
    public void removeListener(Action listener) => baseAction -= listener;
    public void invokeEvent() => baseAction.Invoke();
}
