#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano](Caliban.Nano.md 'Caliban.Nano')

## Bootstrap Class

A framework bootstrapper and livecycle manager with fluent interface.

```csharp
public sealed class Bootstrap :
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Bootstrap

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')
### Constructors

<a name='Caliban.Nano.Bootstrap.Bootstrap(Caliban.Nano.Contracts.IContainer)'></a>

## Bootstrap(IContainer) Constructor

Initializes a new instance of this class with a specified container.

```csharp
public Bootstrap(Caliban.Nano.Contracts.IContainer? container=null);
```
#### Parameters

<a name='Caliban.Nano.Bootstrap.Bootstrap(Caliban.Nano.Contracts.IContainer).container'></a>

`container` [IContainer](Caliban.Nano.Contracts.IContainer.md 'Caliban.Nano.Contracts.IContainer')

The used container.
### Properties

<a name='Caliban.Nano.Bootstrap.Container'></a>

## Bootstrap.Container Property

Used dependency injection container.

```csharp
public Caliban.Nano.Contracts.IContainer Container { get; set; }
```

#### Property Value
[IContainer](Caliban.Nano.Contracts.IContainer.md 'Caliban.Nano.Contracts.IContainer')
### Methods

<a name='Caliban.Nano.Bootstrap.AddSource(System.Reflection.Assembly)'></a>

## Bootstrap.AddSource(Assembly) Method

Adds an assembly to the type finder.

```csharp
public Caliban.Nano.Bootstrap AddSource(System.Reflection.Assembly assembly);
```
#### Parameters

<a name='Caliban.Nano.Bootstrap.AddSource(System.Reflection.Assembly).assembly'></a>

`assembly` [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')

The new assembly.

#### Returns
[Bootstrap](Caliban.Nano.Bootstrap.md 'Caliban.Nano.Bootstrap')  
The bootstrap instance.

<a name='Caliban.Nano.Bootstrap.Dispose()'></a>

## Bootstrap.Dispose() Method

Closes the main window via the window manager.

```csharp
public void Dispose();
```

Implements [Dispose()](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System.IDisposable.Dispose')

<a name='Caliban.Nano.Bootstrap.Register_T_(object)'></a>

## Bootstrap.Register<T>(object) Method

Registers a type or an instance at the used container.

```csharp
public Caliban.Nano.Bootstrap Register<T>(object @object)
    where T : class;
```
#### Type parameters

<a name='Caliban.Nano.Bootstrap.Register_T_(object).T'></a>

`T`

The type.
#### Parameters

<a name='Caliban.Nano.Bootstrap.Register_T_(object).object'></a>

`object` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The type or instance.

#### Returns
[Bootstrap](Caliban.Nano.Bootstrap.md 'Caliban.Nano.Bootstrap')  
The bootstrap instance.

<a name='Caliban.Nano.Bootstrap.Show_T_(System.Collections.Generic.Dictionary_string,object_)'></a>

## Bootstrap.Show<T>(Dictionary<string,object>) Method

Shows the view model as main window via the window manager.

```csharp
public void Show<T>(System.Collections.Generic.Dictionary<string,object>? settings=null)
    where T : Caliban.Nano.Contracts.IViewModel;
```
#### Type parameters

<a name='Caliban.Nano.Bootstrap.Show_T_(System.Collections.Generic.Dictionary_string,object_).T'></a>

`T`

The view model type.
#### Parameters

<a name='Caliban.Nano.Bootstrap.Show_T_(System.Collections.Generic.Dictionary_string,object_).settings'></a>

`settings` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The window settings.