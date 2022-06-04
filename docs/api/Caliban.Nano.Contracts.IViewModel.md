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

<a name='Caliban.Nano.Contracts.IViewModel.Model'></a>

## IViewModel.Model Property

The associated model.

```csharp
object? Model { get; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='Caliban.Nano.Contracts.IViewModel.Parent'></a>

## IViewModel.Parent Property

The optional parent view model.

```csharp
Caliban.Nano.Contracts.IViewModel? Parent { get; }
```

#### Property Value
[IViewModel](Caliban.Nano.Contracts.IViewModel.md 'Caliban.Nano.Contracts.IViewModel')

<a name='Caliban.Nano.Contracts.IViewModel.View'></a>

## IViewModel.View Property

The associated view.

```csharp
object? View { get; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')
### Methods

<a name='Caliban.Nano.Contracts.IViewModel.Close()'></a>

## IViewModel.Close() Method

(Awaitable) Closes the view model if possible.

```csharp
System.Threading.Tasks.Task<bool> Close();
```

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
True if closing was successful; otherwise false.

<a name='Caliban.Nano.Contracts.IViewModel.ModelAs_T_()'></a>

## IViewModel.ModelAs<T>() Method

Returns the model as type.

```csharp
T ModelAs<T>()
    where T : class;
```
#### Type parameters

<a name='Caliban.Nano.Contracts.IViewModel.ModelAs_T_().T'></a>

`T`

The type.

#### Returns
[T](Caliban.Nano.Contracts.IViewModel.md#Caliban.Nano.Contracts.IViewModel.ModelAs_T_().T 'Caliban.Nano.Contracts.IViewModel.ModelAs<T>().T')  
The typed model.

#### Exceptions

[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
Thrown if the model could not be cast.

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

<a name='Caliban.Nano.Contracts.IViewModel.ViewAs_T_()'></a>

## IViewModel.ViewAs<T>() Method

Returns the views as type.

```csharp
T ViewAs<T>()
    where T : class;
```
#### Type parameters

<a name='Caliban.Nano.Contracts.IViewModel.ViewAs_T_().T'></a>

`T`

The type.

#### Returns
[T](Caliban.Nano.Contracts.IViewModel.md#Caliban.Nano.Contracts.IViewModel.ViewAs_T_().T 'Caliban.Nano.Contracts.IViewModel.ViewAs<T>().T')  
The typed view.

#### Exceptions

[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
Thrown if the view could not be cast.