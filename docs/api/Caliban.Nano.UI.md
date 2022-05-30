#### [Caliban.Nano](index.md 'index')

## Caliban.Nano.UI Namespace

| Classes | |
| :--- | :--- |
| [Command&lt;T&gt;](Caliban.Nano.UI.Command_T_.md 'Caliban.Nano.UI.Command<T>') | A functional relay command. |
| [NotifyBase](Caliban.Nano.UI.NotifyBase.md 'Caliban.Nano.UI.NotifyBase') | Chainable implementation of the INotifyPropertyChanged interface. |
| [TypeFinder](Caliban.Nano.UI.TypeFinder.md 'Caliban.Nano.UI.TypeFinder') | A very optimistic type finder. |
| [ViewBinder](Caliban.Nano.UI.ViewBinder.md 'Caliban.Nano.UI.ViewBinder') | A recursive view to view model binder. |
| [ViewModel](Caliban.Nano.UI.ViewModel.md 'Caliban.Nano.UI.ViewModel') | A base view model. |
| [ViewModel.ActiveAll](Caliban.Nano.UI.ViewModel.ActiveAll.md 'Caliban.Nano.UI.ViewModel.ActiveAll') | A composition conductor for multiple active view models. |
| [ViewModel.ActiveOne](Caliban.Nano.UI.ViewModel.ActiveOne.md 'Caliban.Nano.UI.ViewModel.ActiveOne') | A composition conductor for single active view models. |
| [WindowManager](Caliban.Nano.UI.WindowManager.md 'Caliban.Nano.UI.WindowManager') | A window manager for single window applications. |
### Delegates

<a name='Caliban.Nano.UI.ViewBinder.Resolver(System.Windows.FrameworkElement,Caliban.Nano.Contracts.IViewModel)'></a>

## ViewBinder.Resolver(FrameworkElement, IViewModel) Delegate

Resolver method signature.

```csharp
public delegate bool ViewBinder.Resolver(System.Windows.FrameworkElement target, Caliban.Nano.Contracts.IViewModel source);
```
#### Parameters

<a name='Caliban.Nano.UI.ViewBinder.Resolver(System.Windows.FrameworkElement,Caliban.Nano.Contracts.IViewModel).target'></a>

`target` [System.Windows.FrameworkElement](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.FrameworkElement 'System.Windows.FrameworkElement')

The target element.

<a name='Caliban.Nano.UI.ViewBinder.Resolver(System.Windows.FrameworkElement,Caliban.Nano.Contracts.IViewModel).source'></a>

`source` [IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')

The source object.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if resolving should continue; otherwise false.