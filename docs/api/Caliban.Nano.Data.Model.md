#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Data](Caliban.Nano.Data.md 'Caliban.Nano.Data')

## Model Class

A base model.

```csharp
public abstract class Model : Caliban.Nano.Data.NotifyBase,
Caliban.Nano.Contracts.IModel,
System.ComponentModel.INotifyPropertyChanged
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [NotifyBase](Caliban.Nano.Data.NotifyBase.md 'Caliban.Nano.Data.NotifyBase') &#129106; Model

Derived  
&#8627; [Repository](Caliban.Nano.Data.Model.Repository.md 'Caliban.Nano.Data.Model.Repository')

Implements [IModel](Caliban.Nano.Contracts.IModel.md 'Caliban.Nano.Contracts.IModel'), [System.ComponentModel.INotifyPropertyChanged](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.INotifyPropertyChanged 'System.ComponentModel.INotifyPropertyChanged')
### Constructors

<a name='Caliban.Nano.Data.Model.Model()'></a>

## Model() Constructor

Initializes a new instance of this class.

```csharp
public Model();
```
### Fields

<a name='Caliban.Nano.Data.Model._values'></a>

## Model._values Field

The internal value storage.

```csharp
protected Dictionary<string,object?> _values;
```

#### Field Value
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')
### Properties

<a name='Caliban.Nano.Data.Model.HasChanged'></a>

## Model.HasChanged Property

If the model has changed.

```csharp
public bool HasChanged { get; set; }
```

Implements [HasChanged](Caliban.Nano.Contracts.IModel.md#Caliban.Nano.Contracts.IModel.HasChanged 'Caliban.Nano.Contracts.IModel.HasChanged')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Methods

<a name='Caliban.Nano.Data.Model.Get_T_(string)'></a>

## Model.Get<T>(string) Method

Gets a model value.

```csharp
protected virtual T? Get<T>(string? name=null);
```
#### Type parameters

<a name='Caliban.Nano.Data.Model.Get_T_(string).T'></a>

`T`

The value type.
#### Parameters

<a name='Caliban.Nano.Data.Model.Get_T_(string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value key.

#### Returns
[T](Caliban.Nano.Data.Model.md#Caliban.Nano.Data.Model.Get_T_(string).T 'Caliban.Nano.Data.Model.Get<T>(string).T')  
The model value.

<a name='Caliban.Nano.Data.Model.Set_T_(T,string,string[])'></a>

## Model.Set<T>(T, string, string[]) Method

Sets a model value.

```csharp
protected virtual void Set<T>(T value, string? name=null, params string[] others);
```
#### Type parameters

<a name='Caliban.Nano.Data.Model.Set_T_(T,string,string[]).T'></a>

`T`

The value type.
#### Parameters

<a name='Caliban.Nano.Data.Model.Set_T_(T,string,string[]).value'></a>

`value` [T](Caliban.Nano.Data.Model.md#Caliban.Nano.Data.Model.Set_T_(T,string,string[]).T 'Caliban.Nano.Data.Model.Set<T>(T, string, string[]).T')

The model value.

<a name='Caliban.Nano.Data.Model.Set_T_(T,string,string[]).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value key.

<a name='Caliban.Nano.Data.Model.Set_T_(T,string,string[]).others'></a>

`others` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

Other names to notify about.