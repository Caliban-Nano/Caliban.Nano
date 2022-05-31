# Intro
This work is heavily inspired by the [Caliburn.Micro](https://caliburnmicro.com) framework. Which is one of the nicest frameworks, I had ever the pleasure to use. It is also named the after the character *Caliban* in Shakespeare's play *The Tempest* (hence the projects symbol). As the writer Russell Hoban put it:

> 💬 Caliban is one of the hungry ideas, he's always looking for someone to word him into being ... Caliban is a necessary idea.

Which seems very fitting.

# Features

## ✔️ Dependency Injection
Compose your app with loosely coupled objects that will inject by creation.

```cs
new Bootstrap().Register<IBattery, Battery>();
```

### Properties
```cs
public IBattery? Battery { get; init; }
```

### Constructors
```cs
public class Remote
{
    public Remote(IBattery battery)
    {
        ...
    }
}
```

## ✔️ Event Aggregating
Communicate between view models with event aggregating.

### Publisher
```cs
public class Remote
{
    public Remote(IEventAggregator events)
    {
        events.Publish(new BatteryLowEvent());
    }
}
```

### Subscriber
```cs
public class Television : IHandle<BatteryLowEvent>
{
    public Television(IEventAggregator events)
    {
        events.Subscribe<BatteryLowEvent>(this);
    }

    public void Handle(BatteryLowEvent event)
    {
        ...
    }
}
```

## ✔️ Automatic Binding
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
    set => SetValue(ref _someInput, value);
}
```

## ✔️ Conductor Composition
Decouple view models with the built in composition pattern.

```xml
<ContentControl x:Name="ActiveItem"/>
```

```cs
public class CarViewModel : ViewModel.ActiveOne
{
    public CarViewModel()
    {
        SwitchDriverAsync();
    }

    public async void SwitchDriverAsync()
    {
        await ActivateItem(new PersonViewModel());
    }
}
```

## ✔️ View and ViewModel Matching
Match your views, view models and models automatically by consistent naming alone.

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

```cs
public class MainModel
{
    ...
}
```

## ✔️ Implicit Model Properties
Write concise code by using implicit model properties.

```cs
public class SheepModel : Model
{
    public int Count
    {
        get => Get<int>();
        set => Set<int>(value);
    }
}
```

## ✔️ Service Locator
Use registered services with the supplied service locator.

### Register Service
```cs
new Bootstrap().Register<ILogger>(new Logger());
```

### Locate Service
```cs
var logger = IoC.Get<ILogger>();
```

---
**[There is also the full API documentation available!](api/index.md)**