#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Container](Caliban.Nano.Container.md 'Caliban.Nano.Container')

## NanoContainer Class

A thread-safe minimal dependency injection container.

```csharp
public sealed class NanoContainer :
Caliban.Nano.Contracts.IContainer,
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; NanoContainer

Implements [IContainer](Caliban.Nano.Contracts.IContainer.md 'Caliban.Nano.Contracts.IContainer'), [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')
### Constructors

<a name='Caliban.Nano.Container.NanoContainer.NanoContainer()'></a>

## NanoContainer() Constructor

Initializes a new self registered instance of this class.

```csharp
public NanoContainer();
```
### Methods

<a name='Caliban.Nano.Container.NanoContainer.Dispose()'></a>

## NanoContainer.Dispose() Method

Clears the container storage on dispose.

```csharp
public void Dispose();
```

Implements [Dispose()](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System.IDisposable.Dispose')

<a name='Caliban.Nano.Container.NanoContainer.IsRegistered_T_()'></a>

## NanoContainer.IsRegistered<T>() Method

Returns if the type is registered.

```csharp
public bool IsRegistered<T>();
```
#### Type parameters

<a name='Caliban.Nano.Container.NanoContainer.IsRegistered_T_().T'></a>

`T`

The type.

Implements [IsRegistered&lt;T&gt;()](Caliban.Nano.Contracts.IContainer.md#Caliban.Nano.Contracts.IContainer.IsRegistered_T_() 'Caliban.Nano.Contracts.IContainer.IsRegistered<T>()')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the type is registered; otherwise false.

<a name='Caliban.Nano.Container.NanoContainer.Register_T_(object)'></a>

## NanoContainer.Register<T>(object) Method

Registers an instance for a type.

```csharp
public void Register<T>(object instance);
```
#### Type parameters

<a name='Caliban.Nano.Container.NanoContainer.Register_T_(object).T'></a>

`T`

The type.
#### Parameters

<a name='Caliban.Nano.Container.NanoContainer.Register_T_(object).instance'></a>

`instance` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The instance.

Implements [Register&lt;T&gt;(object)](Caliban.Nano.Contracts.IContainer.md#Caliban.Nano.Contracts.IContainer.Register_T_(object) 'Caliban.Nano.Contracts.IContainer.Register<T>(object)')

<a name='Caliban.Nano.Container.NanoContainer.Resolve(object)'></a>

## NanoContainer.Resolve(object) Method

Resolves a registered instance or creates a new if none is registered.

```csharp
public object Resolve(object request);
```
#### Parameters

<a name='Caliban.Nano.Container.NanoContainer.Resolve(object).request'></a>

`request` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The requested type.

Implements [Resolve(object)](Caliban.Nano.Contracts.IContainer.md#Caliban.Nano.Contracts.IContainer.Resolve(object) 'Caliban.Nano.Contracts.IContainer.Resolve(object)')

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The resolved or created instance.

#### Exceptions

[System.TypeLoadException](https://docs.microsoft.com/en-us/dotnet/api/System.TypeLoadException 'System.TypeLoadException')  
Thrown if the request could not be loaded.

<a name='Caliban.Nano.Container.NanoContainer.Resolve_T_()'></a>

## NanoContainer.Resolve<T>() Method

Resolves a registered instance or creates a new if none is registered.

```csharp
public object Resolve<T>();
```
#### Type parameters

<a name='Caliban.Nano.Container.NanoContainer.Resolve_T_().T'></a>

`T`

The type.

Implements [Resolve&lt;T&gt;()](Caliban.Nano.Contracts.IContainer.md#Caliban.Nano.Contracts.IContainer.Resolve_T_() 'Caliban.Nano.Contracts.IContainer.Resolve<T>()')

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The resolved or created instance.

#### Exceptions

[System.TypeLoadException](https://docs.microsoft.com/en-us/dotnet/api/System.TypeLoadException 'System.TypeLoadException')  
Thrown if the type could not be loaded.

<a name='Caliban.Nano.Container.NanoContainer.Unregister_T_()'></a>

## NanoContainer.Unregister<T>() Method

Unregisters all instances from a type.

```csharp
public void Unregister<T>();
```
#### Type parameters

<a name='Caliban.Nano.Container.NanoContainer.Unregister_T_().T'></a>

`T`

The type.

Implements [Unregister&lt;T&gt;()](Caliban.Nano.Contracts.IContainer.md#Caliban.Nano.Contracts.IContainer.Unregister_T_() 'Caliban.Nano.Contracts.IContainer.Unregister<T>()')
### Events

<a name='Caliban.Nano.Container.NanoContainer.Resolved'></a>

## NanoContainer.Resolved Event

Occures when an instance is resolved.

```csharp
public event Action<object>? Resolved;
```

Implements [Resolved](Caliban.Nano.Contracts.IContainer.md#Caliban.Nano.Contracts.IContainer.Resolved 'Caliban.Nano.Contracts.IContainer.Resolved')

#### Event Type
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')