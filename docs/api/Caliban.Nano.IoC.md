#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano](Caliban.Nano.md 'Caliban.Nano')

## IoC Class

An implementation of the service locator pattern.

```csharp
public static class IoC
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IoC
### Methods

<a name='Caliban.Nano.IoC.Get_T_()'></a>

## IoC.Get<T>() Method

Locates a service for the requested type.

```csharp
public static T Get<T>();
```
#### Type parameters

<a name='Caliban.Nano.IoC.Get_T_().T'></a>

`T`

The requested type.

#### Returns
[T](Caliban.Nano.IoC.md#Caliban.Nano.IoC.Get_T_().T 'Caliban.Nano.IoC.Get<T>().T')  
The located service.