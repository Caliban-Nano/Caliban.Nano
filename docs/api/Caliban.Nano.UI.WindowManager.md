#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.UI](Caliban.Nano.UI.md 'Caliban.Nano.UI')

## WindowManager Class

A window manager for single window applications.

```csharp
public static class WindowManager
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; WindowManager
### Methods

<a name='Caliban.Nano.UI.WindowManager.CloseWindowAsync(bool)'></a>

## WindowManager.CloseWindowAsync(bool) Method

(Awaitable) Tries to close the main window.

```csharp
public static System.Threading.Tasks.Task CloseWindowAsync(bool force=true);
```
#### Parameters

<a name='Caliban.Nano.UI.WindowManager.CloseWindowAsync(bool).force'></a>

`force` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Forces the window to close.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
An asynchronous task.

<a name='Caliban.Nano.UI.WindowManager.ShowWindowAsync_T_(System.Collections.Generic.Dictionary_string,object_)'></a>

## WindowManager.ShowWindowAsync<T>(Dictionary<string,object>) Method

(Awaitable) Creates and shows the specified view model as the main window.

```csharp
public static System.Threading.Tasks.Task ShowWindowAsync<T>(System.Collections.Generic.Dictionary<string,object>? settings=null)
    where T : Caliban.Nano.Contracts.IViewModel;
```
#### Type parameters

<a name='Caliban.Nano.UI.WindowManager.ShowWindowAsync_T_(System.Collections.Generic.Dictionary_string,object_).T'></a>

`T`

The view model type.
#### Parameters

<a name='Caliban.Nano.UI.WindowManager.ShowWindowAsync_T_(System.Collections.Generic.Dictionary_string,object_).settings'></a>

`settings` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The window settings.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
An asynchronous task.