#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.UI](Caliban.Nano.UI.md 'Caliban.Nano.UI')

## ViewModel Class

A base view model.

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

<a name='Caliban.Nano.UI.ViewModel.Model'></a>

## ViewModel.Model Property

The associated model.

```csharp
public object? Model { get; set; }
```

Implements [Model](Caliban.Nano.Contracts.IViewModel.md#Caliban.Nano.Contracts.IViewModel.Model 'Caliban.Nano.Contracts.IViewModel.Model')

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='Caliban.Nano.UI.ViewModel.View'></a>

## ViewModel.View Property

The associated view.

```csharp
public object? View { get; set; }
```

Implements [View](Caliban.Nano.Contracts.IViewModel.md#Caliban.Nano.Contracts.IViewModel.View 'Caliban.Nano.Contracts.IViewModel.View')

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')
### Methods

<a name='Caliban.Nano.UI.ViewModel.BindToModel()'></a>

## ViewModel.BindToModel() Method

Binds the view model to the model.

```csharp
protected virtual void BindToModel();
```

<a name='Caliban.Nano.UI.ViewModel.BindToView()'></a>

## ViewModel.BindToView() Method

Binds the view model to the view.

```csharp
protected virtual void BindToView();
```

<a name='Caliban.Nano.UI.ViewModel.ModelAs_T_()'></a>

## ViewModel.ModelAs<T>() Method

Returns the model as type.

```csharp
public T ModelAs<T>()
    where T : class;
```
#### Type parameters

<a name='Caliban.Nano.UI.ViewModel.ModelAs_T_().T'></a>

`T`

The type.

Implements [ModelAs&lt;T&gt;()](Caliban.Nano.Contracts.IViewModel.md#Caliban.Nano.Contracts.IViewModel.ModelAs_T_() 'Caliban.Nano.Contracts.IViewModel.ModelAs<T>()')

#### Returns
[T](Caliban.Nano.UI.ViewModel.md#Caliban.Nano.UI.ViewModel.ModelAs_T_().T 'Caliban.Nano.UI.ViewModel.ModelAs<T>().T')  
The typed model.

#### Exceptions

[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
Thrown if the model could not be cast.

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

<a name='Caliban.Nano.UI.ViewModel.ViewAs_T_()'></a>

## ViewModel.ViewAs<T>() Method

Returns the views as type.

```csharp
public T ViewAs<T>()
    where T : class;
```
#### Type parameters

<a name='Caliban.Nano.UI.ViewModel.ViewAs_T_().T'></a>

`T`

The type.

Implements [ViewAs&lt;T&gt;()](Caliban.Nano.Contracts.IViewModel.md#Caliban.Nano.Contracts.IViewModel.ViewAs_T_() 'Caliban.Nano.Contracts.IViewModel.ViewAs<T>()')

#### Returns
[T](Caliban.Nano.UI.ViewModel.md#Caliban.Nano.UI.ViewModel.ViewAs_T_().T 'Caliban.Nano.UI.ViewModel.ViewAs<T>().T')  
The typed view.

#### Exceptions

[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
Thrown if the view could not be cast.