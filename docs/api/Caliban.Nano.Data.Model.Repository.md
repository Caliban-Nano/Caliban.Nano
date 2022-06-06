#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Data](Caliban.Nano.Data.md 'Caliban.Nano.Data').[Model](Caliban.Nano.Data.Model.md 'Caliban.Nano.Data.Model')

## Model.Repository Class

A base model repository.

```csharp
public abstract class Model.Repository : Caliban.Nano.Data.Model,
Caliban.Nano.Contracts.IRepository
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Model](Caliban.Nano.Data.Model.md 'Caliban.Nano.Data.Model') &#129106; Repository

Implements [IRepository](Caliban.Nano.Contracts.IRepository.md 'Caliban.Nano.Contracts.IRepository')
### Constructors

<a name='Caliban.Nano.Data.Model.Repository.Repository()'></a>

## Repository() Constructor

Initializes a new instance of this class.

```csharp
public Repository();
```
### Methods

<a name='Caliban.Nano.Data.Model.Repository.Persist(object)'></a>

## Model.Repository.Persist(object) Method

(Awaitable) Saves the model and resets changed state.

```csharp
public virtual System.Threading.Tasks.Task Persist(object? key=null);
```
#### Parameters

<a name='Caliban.Nano.Data.Model.Repository.Persist(object).key'></a>

`key` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The models key.

Implements [Persist(object)](Caliban.Nano.Contracts.IRepository.md#Caliban.Nano.Contracts.IRepository.Persist(object) 'Caliban.Nano.Contracts.IRepository.Persist(object)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
An asynchronous task.

<a name='Caliban.Nano.Data.Model.Repository.Request(object)'></a>

## Model.Repository.Request(object) Method

(Awaitable) Loads the model and resets changed state.

```csharp
public virtual System.Threading.Tasks.Task Request(object? key=null);
```
#### Parameters

<a name='Caliban.Nano.Data.Model.Repository.Request(object).key'></a>

`key` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The models key.

Implements [Request(object)](Caliban.Nano.Contracts.IRepository.md#Caliban.Nano.Contracts.IRepository.Request(object) 'Caliban.Nano.Contracts.IRepository.Request(object)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
An asynchronous task.
### Events

<a name='Caliban.Nano.Data.Model.Repository.Persisted'></a>

## Model.Repository.Persisted Event

If the repository was persisted.

```csharp
public event Action<IModel> Persisted;
```

Implements [Persisted](Caliban.Nano.Contracts.IRepository.md#Caliban.Nano.Contracts.IRepository.Persisted 'Caliban.Nano.Contracts.IRepository.Persisted')

#### Event Type
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[IModel](Caliban.Nano.Contracts.IModel.md 'Caliban.Nano.Contracts.IModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

<a name='Caliban.Nano.Data.Model.Repository.Requested'></a>

## Model.Repository.Requested Event

If the repository was requested.

```csharp
public event Action<IModel> Requested;
```

Implements [Requested](Caliban.Nano.Contracts.IRepository.md#Caliban.Nano.Contracts.IRepository.Requested 'Caliban.Nano.Contracts.IRepository.Requested')

#### Event Type
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[IModel](Caliban.Nano.Contracts.IModel.md 'Caliban.Nano.Contracts.IModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')