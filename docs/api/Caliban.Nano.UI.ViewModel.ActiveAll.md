#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.UI](Caliban.Nano.UI.md 'Caliban.Nano.UI').[ViewModel](Caliban.Nano.UI.ViewModel.md 'Caliban.Nano.UI.ViewModel')

## ViewModel.ActiveAll Class

A composition conductor for multiple active view models.

```csharp
public abstract class ViewModel.ActiveAll : Caliban.Nano.UI.ViewModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [NotifyBase](Caliban.Nano.UI.NotifyBase.md 'Caliban.Nano.UI.NotifyBase') &#129106; [ViewModel](Caliban.Nano.UI.ViewModel.md 'Caliban.Nano.UI.ViewModel') &#129106; ActiveAll
### Constructors

<a name='Caliban.Nano.UI.ViewModel.ActiveAll.ActiveAll()'></a>

## ActiveAll() Constructor

Initializes a new instance of this class with bounded event.

```csharp
public ActiveAll();
```
### Properties

<a name='Caliban.Nano.UI.ViewModel.ActiveAll.ActiveItems'></a>

## ViewModel.ActiveAll.ActiveItems Property

Active child view model items.

```csharp
public System.Collections.Generic.IEnumerable<Caliban.Nano.Contracts.IViewModel> ActiveItems { get; }
```

#### Property Value
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='Caliban.Nano.UI.ViewModel.ActiveAll.Items'></a>

## ViewModel.ActiveAll.Items Property

Collection of child view model items.

```csharp
public System.Collections.ObjectModel.ObservableCollection<Caliban.Nano.Contracts.IViewModel> Items { get; set; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')
### Methods

<a name='Caliban.Nano.UI.ViewModel.ActiveAll.ActivateItem(Caliban.Nano.Contracts.IViewModel)'></a>

## ViewModel.ActiveAll.ActivateItem(IViewModel) Method

(Awaitable) Activates the given view model item.

```csharp
public virtual System.Threading.Tasks.Task<bool> ActivateItem(Caliban.Nano.Contracts.IViewModel item);
```
#### Parameters

<a name='Caliban.Nano.UI.ViewModel.ActiveAll.ActivateItem(Caliban.Nano.Contracts.IViewModel).item'></a>

`item` [IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')

The view model item.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
True if the activation was successful; otherwise false.

<a name='Caliban.Nano.UI.ViewModel.ActiveAll.DeactivateItem(Caliban.Nano.Contracts.IViewModel,bool)'></a>

## ViewModel.ActiveAll.DeactivateItem(IViewModel, bool) Method

(Awaitable) Deactivates the given view model item.

```csharp
public virtual System.Threading.Tasks.Task<bool> DeactivateItem(Caliban.Nano.Contracts.IViewModel item, bool close=false);
```
#### Parameters

<a name='Caliban.Nano.UI.ViewModel.ActiveAll.DeactivateItem(Caliban.Nano.Contracts.IViewModel,bool).item'></a>

`item` [IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')

The view model item.

<a name='Caliban.Nano.UI.ViewModel.ActiveAll.DeactivateItem(Caliban.Nano.Contracts.IViewModel,bool).close'></a>

`close` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If the item should be removed.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
True if the deactivation was successful; otherwise false.
### Events

<a name='Caliban.Nano.UI.ViewModel.ActiveAll.ActiveChanged'></a>

## ViewModel.ActiveAll.ActiveChanged Event

Occures when the active item changed.

```csharp
public event Action<IViewModel> ActiveChanged;
```

#### Event Type
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')