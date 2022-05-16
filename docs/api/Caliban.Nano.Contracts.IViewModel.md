#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Contracts](Caliban.Nano.Contracts.md 'Caliban.Nano.Contracts')

## IViewModel Interface

A basic interface for all view models.

```csharp
public interface IViewModel
```

Derived  
&#8627; [ViewModel](Caliban.Nano.UI.ViewModel.md 'Caliban.Nano.UI.ViewModel')
### Properties

<a name='Caliban.Nano.Contracts.IViewModel.CanClose'></a>

## IViewModel.CanClose Property

If this view model can be closed.

```csharp
bool CanClose { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='Caliban.Nano.Contracts.IViewModel.IsActive'></a>

## IViewModel.IsActive Property

If this view model is active.

```csharp
bool IsActive { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='Caliban.Nano.Contracts.IViewModel.View'></a>

## IViewModel.View Property

The associated view.

```csharp
object View { get; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')
### Methods

<a name='Caliban.Nano.Contracts.IViewModel.OnActivate()'></a>

## IViewModel.OnActivate() Method

(Awaitable) Executed on activation.

```csharp
System.Threading.Tasks.Task<bool> OnActivate();
```

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
True if activation was successful; otherwise false.

<a name='Caliban.Nano.Contracts.IViewModel.OnDeactivate()'></a>

## IViewModel.OnDeactivate() Method

(Awaitable) Executed on deactivation.

```csharp
System.Threading.Tasks.Task<bool> OnDeactivate();
```

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
True if deactivation was successful; otherwise false.