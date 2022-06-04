#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.UI](Caliban.Nano.UI.md 'Caliban.Nano.UI')

## WindowManager Class

A primitive window manager for single window applications.

```csharp
public static class WindowManager
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; WindowManager
### Methods

<a name='Caliban.Nano.UI.WindowManager.CloseAsync()'></a>

## WindowManager.CloseAsync() Method

(Awaitable) Forces closing of the main window.

```csharp
public static System.Threading.Tasks.Task CloseAsync();
```

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
An asynchronous task.

<a name='Caliban.Nano.UI.WindowManager.CloseWindowAsync(System.Windows.Window,bool)'></a>

## WindowManager.CloseWindowAsync(Window, bool) Method

(Awaitable) Closes the given window.

```csharp
public static System.Threading.Tasks.Task CloseWindowAsync(System.Windows.Window window, bool force=false);
```
#### Parameters

<a name='Caliban.Nano.UI.WindowManager.CloseWindowAsync(System.Windows.Window,bool).window'></a>

`window` [System.Windows.Window](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Window 'System.Windows.Window')

The window.

<a name='Caliban.Nano.UI.WindowManager.CloseWindowAsync(System.Windows.Window,bool).force'></a>

`force` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Forces the window to close.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
An asynchronous task.

<a name='Caliban.Nano.UI.WindowManager.CreateWindow_T_()'></a>

## WindowManager.CreateWindow<T>() Method

Returns a new window.

```csharp
public static System.Windows.Window CreateWindow<T>()
    where T : Caliban.Nano.Contracts.IViewModel;
```
#### Type parameters

<a name='Caliban.Nano.UI.WindowManager.CreateWindow_T_().T'></a>

`T`

The view model type.

#### Returns
[System.Windows.Window](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Window 'System.Windows.Window')  
The created window.

<a name='Caliban.Nano.UI.WindowManager.ShowAsync_T_(System.Collections.Generic.Dictionary_string,object_)'></a>

## WindowManager.ShowAsync<T>(Dictionary<string,object>) Method

(Awaitable) Creates and shows the specified view model as the main window.

```csharp
public static System.Threading.Tasks.Task ShowAsync<T>(System.Collections.Generic.Dictionary<string,object>? settings=null)
    where T : Caliban.Nano.Contracts.IViewModel;
```
#### Type parameters

<a name='Caliban.Nano.UI.WindowManager.ShowAsync_T_(System.Collections.Generic.Dictionary_string,object_).T'></a>

`T`

The view model type.
#### Parameters

<a name='Caliban.Nano.UI.WindowManager.ShowAsync_T_(System.Collections.Generic.Dictionary_string,object_).settings'></a>

`settings` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The window settings.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
An asynchronous task.

<a name='Caliban.Nano.UI.WindowManager.ShowWindowAsync(System.Windows.Window)'></a>

## WindowManager.ShowWindowAsync(Window) Method

(Awaitable) Shows the specified window.

```csharp
public static System.Threading.Tasks.Task ShowWindowAsync(System.Windows.Window window);
```
#### Parameters

<a name='Caliban.Nano.UI.WindowManager.ShowWindowAsync(System.Windows.Window).window'></a>

`window` [System.Windows.Window](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Window 'System.Windows.Window')

The window.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
An asynchronous task.