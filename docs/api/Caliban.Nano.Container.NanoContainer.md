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

Initializes a new self bound instance of this class.

```csharp
public NanoContainer();
```
### Methods

<a name='Caliban.Nano.Container.NanoContainer.Bind_T_(object)'></a>

## NanoContainer.Bind<T>(object) Method

Binds the type to the type or instance.

```csharp
public void Bind<T>(object @object)
    where T : class;
```
#### Type parameters

<a name='Caliban.Nano.Container.NanoContainer.Bind_T_(object).T'></a>

`T`

The type.
#### Parameters

<a name='Caliban.Nano.Container.NanoContainer.Bind_T_(object).object'></a>

`object` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The type or instance.

Implements [Bind&lt;T&gt;(object)](Caliban.Nano.Contracts.IContainer.md#Caliban.Nano.Contracts.IContainer.Bind_T_(object) 'Caliban.Nano.Contracts.IContainer.Bind<T>(object)')

<a name='Caliban.Nano.Container.NanoContainer.Build(object)'></a>

## NanoContainer.Build(object) Method

Builds up an instance.

```csharp
public void Build(object instance);
```
#### Parameters

<a name='Caliban.Nano.Container.NanoContainer.Build(object).instance'></a>

`instance` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The instance.

Implements [Build(object)](Caliban.Nano.Contracts.IContainer.md#Caliban.Nano.Contracts.IContainer.Build(object) 'Caliban.Nano.Contracts.IContainer.Build(object)')

<a name='Caliban.Nano.Container.NanoContainer.CanResolve_T_()'></a>

## NanoContainer.CanResolve<T>() Method

Returns if the type can be resolved.

```csharp
public bool CanResolve<T>()
    where T : class;
```
#### Type parameters

<a name='Caliban.Nano.Container.NanoContainer.CanResolve_T_().T'></a>

`T`

The type.

Implements [CanResolve&lt;T&gt;()](Caliban.Nano.Contracts.IContainer.md#Caliban.Nano.Contracts.IContainer.CanResolve_T_() 'Caliban.Nano.Contracts.IContainer.CanResolve<T>()')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the type can be resolved; otherwise false.

<a name='Caliban.Nano.Container.NanoContainer.Create(System.Type)'></a>

## NanoContainer.Create(Type) Method

Returns a new type instance.

```csharp
public object Create(System.Type type);
```
#### Parameters

<a name='Caliban.Nano.Container.NanoContainer.Create(System.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type.

Implements [Create(Type)](Caliban.Nano.Contracts.IContainer.md#Caliban.Nano.Contracts.IContainer.Create(System.Type) 'Caliban.Nano.Contracts.IContainer.Create(System.Type)')

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The created instance.

#### Exceptions

[System.TypeLoadException](https://docs.microsoft.com/en-us/dotnet/api/System.TypeLoadException 'System.TypeLoadException')  
Thrown if the type could not be created.

<a name='Caliban.Nano.Container.NanoContainer.Dispose()'></a>

## NanoContainer.Dispose() Method

Clears the container bindings on dispose.

```csharp
public void Dispose();
```

Implements [Dispose()](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System.IDisposable.Dispose')

<a name='Caliban.Nano.Container.NanoContainer.Resolve(System.Type)'></a>

## NanoContainer.Resolve(Type) Method

Resolves a bound type by returning an existing instance or creating a new one.

```csharp
public object Resolve(System.Type type);
```
#### Parameters

<a name='Caliban.Nano.Container.NanoContainer.Resolve(System.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type.

Implements [Resolve(Type)](Caliban.Nano.Contracts.IContainer.md#Caliban.Nano.Contracts.IContainer.Resolve(System.Type) 'Caliban.Nano.Contracts.IContainer.Resolve(System.Type)')

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The bound or created instance.

#### Exceptions

[System.TypeLoadException](https://docs.microsoft.com/en-us/dotnet/api/System.TypeLoadException 'System.TypeLoadException')  
Thrown if the type could not be created.

<a name='Caliban.Nano.Container.NanoContainer.Resolve_T_()'></a>

## NanoContainer.Resolve<T>() Method

Resolves a bound type by returning an existing instance or creating a new one.

```csharp
public object Resolve<T>()
    where T : class;
```
#### Type parameters

<a name='Caliban.Nano.Container.NanoContainer.Resolve_T_().T'></a>

`T`

The type.

Implements [Resolve&lt;T&gt;()](Caliban.Nano.Contracts.IContainer.md#Caliban.Nano.Contracts.IContainer.Resolve_T_() 'Caliban.Nano.Contracts.IContainer.Resolve<T>()')

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The bound or created instance.

#### Exceptions

[System.TypeLoadException](https://docs.microsoft.com/en-us/dotnet/api/System.TypeLoadException 'System.TypeLoadException')  
Thrown if the type could not be created.

<a name='Caliban.Nano.Container.NanoContainer.Unbind_T_()'></a>

## NanoContainer.Unbind<T>() Method

Unbinds the type.

```csharp
public void Unbind<T>()
    where T : class;
```
#### Type parameters

<a name='Caliban.Nano.Container.NanoContainer.Unbind_T_().T'></a>

`T`

The type.

Implements [Unbind&lt;T&gt;()](Caliban.Nano.Contracts.IContainer.md#Caliban.Nano.Contracts.IContainer.Unbind_T_() 'Caliban.Nano.Contracts.IContainer.Unbind<T>()')
### Events

<a name='Caliban.Nano.Container.NanoContainer.Resolved'></a>

## NanoContainer.Resolved Event

Occures when an object is resolved.

```csharp
public event Action<object>? Resolved;
```

Implements [Resolved](Caliban.Nano.Contracts.IContainer.md#Caliban.Nano.Contracts.IContainer.Resolved 'Caliban.Nano.Contracts.IContainer.Resolved')

#### Event Type
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')