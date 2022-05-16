#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.UI](Caliban.Nano.UI.md 'Caliban.Nano.UI')

## ViewModel Class

A base base view model.

```csharp
public abstract class ViewModel : Caliban.Nano.UI.NotifyBase,
Caliban.Nano.Contracts.IViewModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [NotifyBase](Caliban.Nano.UI.NotifyBase.md 'Caliban.Nano.UI.NotifyBase') &#129106; ViewModel

Derived  
&#8627; [ActiveAll](Caliban.Nano.UI.ViewModel.ActiveAll.md 'Caliban.Nano.UI.ViewModel.ActiveAll')  
&#8627; [ActiveOne](Caliban.Nano.UI.ViewModel.ActiveOne.md 'Caliban.Nano.UI.ViewModel.ActiveOne')

Implements [IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')
### Constructors

<a name='Caliban.Nano.UI.ViewModel.ViewModel()'></a>

## ViewModel() Constructor

Initializes a new instance of this class with dependency injection and binding.

```csharp
public ViewModel();
```
### Properties

<a name='Caliban.Nano.UI.ViewModel.CanClose'></a>

## ViewModel.CanClose Property

If this view model can be closed.

```csharp
public bool CanClose { get; set; }
```

Implements [CanClose](Caliban.Nano.Contracts.IViewModel.md#Caliban.Nano.Contracts.IViewModel.CanClose 'Caliban.Nano.Contracts.IViewModel.CanClose')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='Caliban.Nano.UI.ViewModel.IsActive'></a>

## ViewModel.IsActive Property

If this view model is active.

```csharp
public bool IsActive { get; set; }
```

Implements [IsActive](Caliban.Nano.Contracts.IViewModel.md#Caliban.Nano.Contracts.IViewModel.IsActive 'Caliban.Nano.Contracts.IViewModel.IsActive')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='Caliban.Nano.UI.ViewModel.View'></a>

## ViewModel.View Property

The associated view.

```csharp
public object View { get; set; }
```

Implements [View](Caliban.Nano.Contracts.IViewModel.md#Caliban.Nano.Contracts.IViewModel.View 'Caliban.Nano.Contracts.IViewModel.View')

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')
### Methods

<a name='Caliban.Nano.UI.ViewModel.OnActivate()'></a>

## ViewModel.OnActivate() Method

(Awaitable) Executed on activation.

```csharp
public virtual System.Threading.Tasks.Task<bool> OnActivate();
```

Implements [OnActivate()](Caliban.Nano.Contracts.IViewModel.md#Caliban.Nano.Contracts.IViewModel.OnActivate() 'Caliban.Nano.Contracts.IViewModel.OnActivate()')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
True if activation was successful; otherwise false.

<a name='Caliban.Nano.UI.ViewModel.OnDeactivate()'></a>

## ViewModel.OnDeactivate() Method

(Awaitable) Executed on deactivation.

```csharp
public virtual System.Threading.Tasks.Task<bool> OnDeactivate();
```

Implements [OnDeactivate()](Caliban.Nano.Contracts.IViewModel.md#Caliban.Nano.Contracts.IViewModel.OnDeactivate() 'Caliban.Nano.Contracts.IViewModel.OnDeactivate()')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
True if deactivation was successful; otherwise false.