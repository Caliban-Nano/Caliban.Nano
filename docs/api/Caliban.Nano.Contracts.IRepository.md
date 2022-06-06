#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Contracts](Caliban.Nano.Contracts.md 'Caliban.Nano.Contracts')

## IRepository Interface

A basic interface for all repositories.

```csharp
public interface IRepository
```

Derived  
&#8627; [Repository](Caliban.Nano.Data.Model.Repository.md 'Caliban.Nano.Data.Model.Repository')
### Methods

<a name='Caliban.Nano.Contracts.IRepository.Persist(object)'></a>

## IRepository.Persist(object) Method

(Awaitable) Saves the model and resets changed state.

```csharp
System.Threading.Tasks.Task Persist(object? key=null);
```
#### Parameters

<a name='Caliban.Nano.Contracts.IRepository.Persist(object).key'></a>

`key` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The models key.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
An asynchronous task.

<a name='Caliban.Nano.Contracts.IRepository.Request(object)'></a>

## IRepository.Request(object) Method

(Awaitable) Loads the model and resets changed state.

```csharp
System.Threading.Tasks.Task Request(object? key=null);
```
#### Parameters

<a name='Caliban.Nano.Contracts.IRepository.Request(object).key'></a>

`key` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The models key.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
An asynchronous task.
### Events

<a name='Caliban.Nano.Contracts.IRepository.Persisted'></a>

## IRepository.Persisted Event

If the repository was persisted.

```csharp
event Action<IModel> Persisted;
```

#### Event Type
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[IModel](Caliban.Nano.Contracts.IModel.md 'Caliban.Nano.Contracts.IModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

<a name='Caliban.Nano.Contracts.IRepository.Requested'></a>

## IRepository.Requested Event

If the repository was requested.

```csharp
event Action<IModel> Requested;
```

#### Event Type
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[IModel](Caliban.Nano.Contracts.IModel.md 'Caliban.Nano.Contracts.IModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')