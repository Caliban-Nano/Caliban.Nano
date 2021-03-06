#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Data](Caliban.Nano.Data.md 'Caliban.Nano.Data')

## NotifyBase Class

Chainable implementation of the INotifyPropertyChanged interface.

```csharp
public abstract class NotifyBase :
System.ComponentModel.INotifyPropertyChanged
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; NotifyBase

Derived  
&#8627; [Model](Caliban.Nano.Data.Model.md 'Caliban.Nano.Data.Model')  
&#8627; [ViewModel](Caliban.Nano.UI.ViewModel.md 'Caliban.Nano.UI.ViewModel')

Implements [System.ComponentModel.INotifyPropertyChanged](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.INotifyPropertyChanged 'System.ComponentModel.INotifyPropertyChanged')
### Methods

<a name='Caliban.Nano.Data.NotifyBase.NotifyPropertyChanged(object,System.ComponentModel.PropertyChangedEventArgs)'></a>

## NotifyBase.NotifyPropertyChanged(object, PropertyChangedEventArgs) Method

Notifies clients that a property value has changed.

```csharp
protected virtual void NotifyPropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e);
```
#### Parameters

<a name='Caliban.Nano.Data.NotifyBase.NotifyPropertyChanged(object,System.ComponentModel.PropertyChangedEventArgs).sender'></a>

`sender` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The event sender.

<a name='Caliban.Nano.Data.NotifyBase.NotifyPropertyChanged(object,System.ComponentModel.PropertyChangedEventArgs).e'></a>

`e` [System.ComponentModel.PropertyChangedEventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.PropertyChangedEventArgs 'System.ComponentModel.PropertyChangedEventArgs')

The event arguments.

<a name='Caliban.Nano.Data.NotifyBase.NotifyPropertyChanged(string)'></a>

## NotifyBase.NotifyPropertyChanged(string) Method

Notifies clients that a property value has changed.

```csharp
protected virtual void NotifyPropertyChanged(string? name=null);
```
#### Parameters

<a name='Caliban.Nano.Data.NotifyBase.NotifyPropertyChanged(string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The property name.

<a name='Caliban.Nano.Data.NotifyBase.NotifyPropertyChanged_T_(System.Linq.Expressions.Expression_System.Func_T__)'></a>

## NotifyBase.NotifyPropertyChanged<T>(Expression<Func<T>>) Method

Notifies clients that a property value has changed.

```csharp
protected virtual void NotifyPropertyChanged<T>(System.Linq.Expressions.Expression<System.Func<T>> property);
```
#### Type parameters

<a name='Caliban.Nano.Data.NotifyBase.NotifyPropertyChanged_T_(System.Linq.Expressions.Expression_System.Func_T__).T'></a>

`T`

The property type.
#### Parameters

<a name='Caliban.Nano.Data.NotifyBase.NotifyPropertyChanged_T_(System.Linq.Expressions.Expression_System.Func_T__).property'></a>

`property` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](Caliban.Nano.Data.NotifyBase.md#Caliban.Nano.Data.NotifyBase.NotifyPropertyChanged_T_(System.Linq.Expressions.Expression_System.Func_T__).T 'Caliban.Nano.Data.NotifyBase.NotifyPropertyChanged<T>(System.Linq.Expressions.Expression<System.Func<T>>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The property name.

<a name='Caliban.Nano.Data.NotifyBase.SetProperty_T_(T,T,string,string[])'></a>

## NotifyBase.SetProperty<T>(T, T, string, string[]) Method

Sets the value of a property and notifies.

```csharp
protected virtual bool SetProperty<T>(ref T field, T value, string? name=null, params string[] others);
```
#### Type parameters

<a name='Caliban.Nano.Data.NotifyBase.SetProperty_T_(T,T,string,string[]).T'></a>

`T`

The property type.
#### Parameters

<a name='Caliban.Nano.Data.NotifyBase.SetProperty_T_(T,T,string,string[]).field'></a>

`field` [T](Caliban.Nano.Data.NotifyBase.md#Caliban.Nano.Data.NotifyBase.SetProperty_T_(T,T,string,string[]).T 'Caliban.Nano.Data.NotifyBase.SetProperty<T>(T, T, string, string[]).T')

The inner field.

<a name='Caliban.Nano.Data.NotifyBase.SetProperty_T_(T,T,string,string[]).value'></a>

`value` [T](Caliban.Nano.Data.NotifyBase.md#Caliban.Nano.Data.NotifyBase.SetProperty_T_(T,T,string,string[]).T 'Caliban.Nano.Data.NotifyBase.SetProperty<T>(T, T, string, string[]).T')

The property value.

<a name='Caliban.Nano.Data.NotifyBase.SetProperty_T_(T,T,string,string[]).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The property name.

<a name='Caliban.Nano.Data.NotifyBase.SetProperty_T_(T,T,string,string[]).others'></a>

`others` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

Other names to notify about.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the value could be set; otherwise false.