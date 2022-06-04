#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Contracts](Caliban.Nano.Contracts.md 'Caliban.Nano.Contracts')

## IModel Interface

A basic interface for all models.

```csharp
public interface IModel :
System.ComponentModel.INotifyPropertyChanged
```

Derived  
&#8627; [Model](Caliban.Nano.Data.Model.md 'Caliban.Nano.Data.Model')

Implements [System.ComponentModel.INotifyPropertyChanged](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.INotifyPropertyChanged 'System.ComponentModel.INotifyPropertyChanged')
### Properties

<a name='Caliban.Nano.Contracts.IModel.HasChanged'></a>

## IModel.HasChanged Property

If the model has changed.

```csharp
bool HasChanged { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Methods

<a name='Caliban.Nano.Contracts.IModel.Load()'></a>

## IModel.Load() Method

Loads the model and resets changed state.

```csharp
void Load();
```

<a name='Caliban.Nano.Contracts.IModel.Save()'></a>

## IModel.Save() Method

Saves the model and resets changed state.

```csharp
void Save();
```