#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.UI](Caliban.Nano.UI.md 'Caliban.Nano.UI')

## Command<T> Class

A functional relay command.

```csharp
public class Command<T> :
System.Windows.Input.ICommand
```
#### Type parameters

<a name='Caliban.Nano.UI.Command_T_.T'></a>

`T`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Command<T>

Implements [System.Windows.Input.ICommand](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Input.ICommand 'System.Windows.Input.ICommand')
### Constructors

<a name='Caliban.Nano.UI.Command_T_.Command(System.Action_T_,System.Func_T,bool_)'></a>

## Command(Action<T>, Func<T,bool>) Constructor

Initializes a new instance of this class.

```csharp
public Command(System.Action<T?> action, System.Func<T?,bool> guard);
```
#### Parameters

<a name='Caliban.Nano.UI.Command_T_.Command(System.Action_T_,System.Func_T,bool_).action'></a>

`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Caliban.Nano.UI.Command_T_.md#Caliban.Nano.UI.Command_T_.T 'Caliban.Nano.UI.Command<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The execute action.

<a name='Caliban.Nano.UI.Command_T_.Command(System.Action_T_,System.Func_T,bool_).guard'></a>

`guard` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Caliban.Nano.UI.Command_T_.md#Caliban.Nano.UI.Command_T_.T 'Caliban.Nano.UI.Command<T>.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The guard function.

<a name='Caliban.Nano.UI.Command_T_.Command(System.Action_T_)'></a>

## Command(Action<T>) Constructor

Initializes a new instance of this class.

```csharp
public Command(System.Action<T?> action);
```
#### Parameters

<a name='Caliban.Nano.UI.Command_T_.Command(System.Action_T_).action'></a>

`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Caliban.Nano.UI.Command_T_.md#Caliban.Nano.UI.Command_T_.T 'Caliban.Nano.UI.Command<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The execute action.
### Methods

<a name='Caliban.Nano.UI.Command_T_.RaiseCanExecuteChanged()'></a>

## Command<T>.RaiseCanExecuteChanged() Method

Raises the CanExecuteChanged event.

```csharp
public virtual void RaiseCanExecuteChanged();
```