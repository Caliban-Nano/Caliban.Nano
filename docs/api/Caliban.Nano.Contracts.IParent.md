#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Contracts](Caliban.Nano.Contracts.md 'Caliban.Nano.Contracts')

## IParent Interface

An interface for all parent view models.

```csharp
public interface IParent
```

Derived  
&#8627; [ActiveAll](Caliban.Nano.UI.ViewModel.ActiveAll.md 'Caliban.Nano.UI.ViewModel.ActiveAll')  
&#8627; [ActiveOne](Caliban.Nano.UI.ViewModel.ActiveOne.md 'Caliban.Nano.UI.ViewModel.ActiveOne')
### Properties

<a name='Caliban.Nano.Contracts.IParent.Items'></a>

## IParent.Items Property

Collection of child view model items.

```csharp
System.Collections.ObjectModel.ObservableCollection<Caliban.Nano.Contracts.IViewModel> Items { get; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')
### Methods

<a name='Caliban.Nano.Contracts.IParent.ActivateItem(Caliban.Nano.Contracts.IViewModel)'></a>

## IParent.ActivateItem(IViewModel) Method

(Awaitable) Activates the given view model item.

```csharp
System.Threading.Tasks.Task<bool> ActivateItem(Caliban.Nano.Contracts.IViewModel item);
```
#### Parameters

<a name='Caliban.Nano.Contracts.IParent.ActivateItem(Caliban.Nano.Contracts.IViewModel).item'></a>

`item` [IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')

The view model item.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
True if the activation was successful; otherwise false.

<a name='Caliban.Nano.Contracts.IParent.DeactivateItem(Caliban.Nano.Contracts.IViewModel,bool)'></a>

## IParent.DeactivateItem(IViewModel, bool) Method

(Awaitable) Deactivates the given view model item.

```csharp
System.Threading.Tasks.Task<bool> DeactivateItem(Caliban.Nano.Contracts.IViewModel item, bool close=false);
```
#### Parameters

<a name='Caliban.Nano.Contracts.IParent.DeactivateItem(Caliban.Nano.Contracts.IViewModel,bool).item'></a>

`item` [IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')

The view model item.

<a name='Caliban.Nano.Contracts.IParent.DeactivateItem(Caliban.Nano.Contracts.IViewModel,bool).close'></a>

`close` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If the item should be removed.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
True if the deactivation was successful; otherwise false.
### Events

<a name='Caliban.Nano.Contracts.IParent.ActiveChanged'></a>

## IParent.ActiveChanged Event

Occures when the active item changed.

```csharp
event Action<IViewModel> ActiveChanged;
```

#### Event Type
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')