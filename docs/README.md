# Intro

This work is heavily inspired by the [Caliburn.Micro](https://caliburnmicro.com) framework. Which is one of the nicest frameworks, I had ever the pleasure to use. It is also named the after the character *Caliban* in Shakespeare's play *The Tempest* (hence the projects symbol). As the writer Russell Hoban put it:

> Caliban is one of the hungry ideas, he's always looking for someone to word him into being ... Caliban is a necessary idea.

Which seems very fitting.

# Features

## Dependency Injection
Compose your app with loosely coupled objects that will inject by creation.

### Constructors
```cs
public IBattery Battery { get; init; }

public Remote(IBattery battery)
{
    Battery = battery;
}
```

### Properties
```cs
public IBattery? Battery { get; set; }
```

## Event Aggregating
Communicate between view models with event aggregating.

```cs
public class Remote
{
    public Remote(IEventAggregator events)
    {
        events.Publish(new BatteryLowEvent());
    }
}
```

```cs
public class Display : IHandle<BatteryLowEvent>
{
    public Display(IEventAggregator events)
    {
        events.Subscribe<BatteryLowEvent>(this);
    }

    public void Handle(BatteryLowEvent event)
    {
        ...
    }
}
```

## Automatic Binding
Apply methods and properties between your view and view model automatically and guard them.

### Methods
```xml
<Button x:Name="DoSomething"/>
```

```cs
public bool CanDoSomething => true;

public void DoSomething()
{
    ...
}
```

### Properties
```xml
<TextBox x:Name="SomeInput"/>
```

```cs
private string _someInput = "";

public string SomeInput
{
    get => _someInput;
    set
    {
        _someInput = value;

        NotifyPropertyChanged();
    }
}
```

## Conductor Composition
Decouple view models with the built in composition pattern.

```xml
<ContentControl x:Name="ActiveItem"/>
```

```cs
public CompanyViewModel() : ViewModel
{
    LoadUserAsync();
}

public async void LoadUserAsync()
{
    await Activate(new UserViewModel());
}
```

## View + ViewModel Matching
Match your views and view models automatically by consistent naming alone.

```cs
public class MainView
{
    ...
}
```

```cs
public class MainViewModel
{
    ...
}
```

## Service Locator
Use registered services with the supplied service locator.

```cs
new Bootstrap().Register<ILogger>(new Logger());
```

```cs
var log = IoC.Get<ILogger>();
```
