#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Contracts](Caliban.Nano.Contracts.md 'Caliban.Nano.Contracts')

## IContainer Interface

An interface for a minimal dependency injection container.

```csharp
public interface IContainer :
System.IDisposable
```

Derived  
&#8627; [NanoContainer](Caliban.Nano.Container.NanoContainer.md 'Caliban.Nano.Container.NanoContainer')

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')
### Methods

<a name='Caliban.Nano.Contracts.IContainer.Bind_T_(object)'></a>

## IContainer.Bind<T>(object) Method

Binds the type to the type or instance.

```csharp
void Bind<T>(object @object)
    where T : class;
```
#### Type parameters

<a name='Caliban.Nano.Contracts.IContainer.Bind_T_(object).T'></a>

`T`

The type.
#### Parameters

<a name='Caliban.Nano.Contracts.IContainer.Bind_T_(object).object'></a>

`object` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The type or instance.

<a name='Caliban.Nano.Contracts.IContainer.Build(object)'></a>

## IContainer.Build(object) Method

Builds up an instance.

```csharp
void Build(object instance);
```
#### Parameters

<a name='Caliban.Nano.Contracts.IContainer.Build(object).instance'></a>

`instance` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The instance.

<a name='Caliban.Nano.Contracts.IContainer.CanResolve_T_()'></a>

## IContainer.CanResolve<T>() Method

Returns if the type can be resolved.

```csharp
bool CanResolve<T>()
    where T : class;
```
#### Type parameters

<a name='Caliban.Nano.Contracts.IContainer.CanResolve_T_().T'></a>

`T`

The type.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the type can be resolved; otherwise false.

<a name='Caliban.Nano.Contracts.IContainer.Create(System.Type)'></a>

## IContainer.Create(Type) Method

Returns a new type instance.

```csharp
object Create(System.Type type);
```
#### Parameters

<a name='Caliban.Nano.Contracts.IContainer.Create(System.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type.

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The created instance.

#### Exceptions

[System.TypeLoadException](https://docs.microsoft.com/en-us/dotnet/api/System.TypeLoadException 'System.TypeLoadException')  
Thrown if the type could not be created.

<a name='Caliban.Nano.Contracts.IContainer.Resolve(System.Type)'></a>

## IContainer.Resolve(Type) Method

Resolves a bound type by returning an existing instance or creating a new one.

```csharp
object Resolve(System.Type type);
```
#### Parameters

<a name='Caliban.Nano.Contracts.IContainer.Resolve(System.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type.

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The bound or created instance.

#### Exceptions

[System.TypeLoadException](https://docs.microsoft.com/en-us/dotnet/api/System.TypeLoadException 'System.TypeLoadException')  
Thrown if the type could not be created.

<a name='Caliban.Nano.Contracts.IContainer.Resolve_T_()'></a>

## IContainer.Resolve<T>() Method

Resolves a bound type by returning an existing instance or creating a new one.

```csharp
object Resolve<T>()
    where T : class;
```
#### Type parameters

<a name='Caliban.Nano.Contracts.IContainer.Resolve_T_().T'></a>

`T`

The type.

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The bound or created instance.

#### Exceptions

[System.TypeLoadException](https://docs.microsoft.com/en-us/dotnet/api/System.TypeLoadException 'System.TypeLoadException')  
Thrown if the type could not be created.

<a name='Caliban.Nano.Contracts.IContainer.Unbind_T_()'></a>

## IContainer.Unbind<T>() Method

Unbinds the type.

```csharp
void Unbind<T>()
    where T : class;
```
#### Type parameters

<a name='Caliban.Nano.Contracts.IContainer.Unbind_T_().T'></a>

`T`

The type.
### Events

<a name='Caliban.Nano.Contracts.IContainer.Resolved'></a>

## IContainer.Resolved Event

Occures when an object is resolved.

```csharp
event Action<object>? Resolved;
```

#### Event Type
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')