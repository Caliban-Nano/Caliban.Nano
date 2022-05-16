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

<a name='Caliban.Nano.Contracts.IContainer.IsRegistered_T_()'></a>

## IContainer.IsRegistered<T>() Method

Returns if the type is registered.

```csharp
bool IsRegistered<T>();
```
#### Type parameters

<a name='Caliban.Nano.Contracts.IContainer.IsRegistered_T_().T'></a>

`T`

The type.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the type is registered; otherwise false.

<a name='Caliban.Nano.Contracts.IContainer.Register_T_(object)'></a>

## IContainer.Register<T>(object) Method

Registers an instance for a type.

```csharp
void Register<T>(object instance);
```
#### Type parameters

<a name='Caliban.Nano.Contracts.IContainer.Register_T_(object).T'></a>

`T`

The type.
#### Parameters

<a name='Caliban.Nano.Contracts.IContainer.Register_T_(object).instance'></a>

`instance` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The instance.

<a name='Caliban.Nano.Contracts.IContainer.Resolve(object)'></a>

## IContainer.Resolve(object) Method

Resolves a registered instance or creates a new if none is registered.

```csharp
object Resolve(object request);
```
#### Parameters

<a name='Caliban.Nano.Contracts.IContainer.Resolve(object).request'></a>

`request` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The requested type.

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The resolved or created instance.

#### Exceptions

[System.TypeLoadException](https://docs.microsoft.com/en-us/dotnet/api/System.TypeLoadException 'System.TypeLoadException')  
Thrown if the request could not be loaded.

<a name='Caliban.Nano.Contracts.IContainer.Resolve_T_()'></a>

## IContainer.Resolve<T>() Method

Resolves a registered instance or creates a new if none is registered.

```csharp
object Resolve<T>();
```
#### Type parameters

<a name='Caliban.Nano.Contracts.IContainer.Resolve_T_().T'></a>

`T`

The type.

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The resolved or created instance.

#### Exceptions

[System.TypeLoadException](https://docs.microsoft.com/en-us/dotnet/api/System.TypeLoadException 'System.TypeLoadException')  
Thrown if the type could not be loaded.

<a name='Caliban.Nano.Contracts.IContainer.Unregister_T_()'></a>

## IContainer.Unregister<T>() Method

Unregisters all instances from a type.

```csharp
void Unregister<T>();
```
#### Type parameters

<a name='Caliban.Nano.Contracts.IContainer.Unregister_T_().T'></a>

`T`

The type.
### Events

<a name='Caliban.Nano.Contracts.IContainer.Resolved'></a>

## IContainer.Resolved Event

Occures when an instance is resolved.

```csharp
event Action<object>? Resolved;
```

#### Event Type
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')