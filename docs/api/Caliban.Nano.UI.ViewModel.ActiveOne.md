#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.UI](Caliban.Nano.UI.md 'Caliban.Nano.UI').[ViewModel](Caliban.Nano.UI.ViewModel.md 'Caliban.Nano.UI.ViewModel')

## ViewModel.ActiveOne Class

A composition conductor for single active view models.

```csharp
public abstract class ViewModel.ActiveOne : Caliban.Nano.UI.ViewModel,
Caliban.Nano.Contracts.IParent
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [NotifyBase](Caliban.Nano.UI.NotifyBase.md 'Caliban.Nano.UI.NotifyBase') &#129106; [ViewModel](Caliban.Nano.UI.ViewModel.md 'Caliban.Nano.UI.ViewModel') &#129106; ActiveOne

Implements [IParent](Caliban.Nano.Contracts.IParent.md 'Caliban.Nano.Contracts.IParent')
### Constructors

<a name='Caliban.Nano.UI.ViewModel.ActiveOne.ActiveOne(Caliban.Nano.Contracts.IViewModel)'></a>

## ActiveOne(IViewModel) Constructor

Initializes a new instance of this class with bounded event.

```csharp
public ActiveOne(Caliban.Nano.Contracts.IViewModel? parent=null);
```
#### Parameters

<a name='Caliban.Nano.UI.ViewModel.ActiveOne.ActiveOne(Caliban.Nano.Contracts.IViewModel).parent'></a>

`parent` [IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')

The optional parent view model.
### Properties

<a name='Caliban.Nano.UI.ViewModel.ActiveOne.ActiveItem'></a>

## ViewModel.ActiveOne.ActiveItem Property

Active child view model item.

```csharp
public Caliban.Nano.Contracts.IViewModel? ActiveItem { get; }
```

#### Property Value
[IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')

<a name='Caliban.Nano.UI.ViewModel.ActiveOne.Items'></a>

## ViewModel.ActiveOne.Items Property

Collection of child view model items.

```csharp
public System.Collections.ObjectModel.ObservableCollection<Caliban.Nano.Contracts.IViewModel> Items { get; set; }
```

Implements [Items](Caliban.Nano.Contracts.IParent.md#Caliban.Nano.Contracts.IParent.Items 'Caliban.Nano.Contracts.IParent.Items')

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')
### Methods

<a name='Caliban.Nano.UI.ViewModel.ActiveOne.ActivateItem(Caliban.Nano.Contracts.IViewModel)'></a>

## ViewModel.ActiveOne.ActivateItem(IViewModel) Method

(Awaitable) Activates the given view model item.

```csharp
public virtual System.Threading.Tasks.Task<bool> ActivateItem(Caliban.Nano.Contracts.IViewModel item);
```
#### Parameters

<a name='Caliban.Nano.UI.ViewModel.ActiveOne.ActivateItem(Caliban.Nano.Contracts.IViewModel).item'></a>

`item` [IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')

The view model item.

Implements [ActivateItem(IViewModel)](Caliban.Nano.Contracts.IParent.md#Caliban.Nano.Contracts.IParent.ActivateItem(Caliban.Nano.Contracts.IViewModel) 'Caliban.Nano.Contracts.IParent.ActivateItem(Caliban.Nano.Contracts.IViewModel)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
True if the activation was successful; otherwise false.

<a name='Caliban.Nano.UI.ViewModel.ActiveOne.DeactivateItem(Caliban.Nano.Contracts.IViewModel,bool)'></a>

## ViewModel.ActiveOne.DeactivateItem(IViewModel, bool) Method

(Awaitable) Deactivates the given view model item.

```csharp
public virtual System.Threading.Tasks.Task<bool> DeactivateItem(Caliban.Nano.Contracts.IViewModel item, bool close=false);
```
#### Parameters

<a name='Caliban.Nano.UI.ViewModel.ActiveOne.DeactivateItem(Caliban.Nano.Contracts.IViewModel,bool).item'></a>

`item` [IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')

The view model item.

<a name='Caliban.Nano.UI.ViewModel.ActiveOne.DeactivateItem(Caliban.Nano.Contracts.IViewModel,bool).close'></a>

`close` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If the item should be removed.

Implements [DeactivateItem(IViewModel, bool)](Caliban.Nano.Contracts.IParent.md#Caliban.Nano.Contracts.IParent.DeactivateItem(Caliban.Nano.Contracts.IViewModel,bool) 'Caliban.Nano.Contracts.IParent.DeactivateItem(Caliban.Nano.Contracts.IViewModel, bool)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
True if the deactivation was successful; otherwise false.
### Events

<a name='Caliban.Nano.UI.ViewModel.ActiveOne.ActiveChanged'></a>

## ViewModel.ActiveOne.ActiveChanged Event

Occures when the active item changed.

```csharp
public event Action<IViewModel> ActiveChanged;
```

Implements [ActiveChanged](Caliban.Nano.Contracts.IParent.md#Caliban.Nano.Contracts.IParent.ActiveChanged 'Caliban.Nano.Contracts.IParent.ActiveChanged')

#### Event Type
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')