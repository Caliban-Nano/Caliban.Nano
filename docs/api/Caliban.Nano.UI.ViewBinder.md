#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.UI](Caliban.Nano.UI.md 'Caliban.Nano.UI')

## ViewBinder Class

A recursive view to view model binder.

```csharp
public static class ViewBinder
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ViewBinder
### Fields

<a name='Caliban.Nano.UI.ViewBinder.Scope'></a>

## ViewBinder.Scope Field

Scope of all used resolvers.

```csharp
public static readonly List<(Type,Resolver)> Scope;
```

#### Field Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[Resolver(FrameworkElement, object)](Caliban.Nano.UI.ViewBinder.md#Caliban.Nano.UI.ViewBinder.Resolver(System.Windows.FrameworkElement,object) 'Caliban.Nano.UI.ViewBinder.Resolver(System.Windows.FrameworkElement, object)')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')
### Methods

<a name='Caliban.Nano.UI.ViewBinder.AddResolver_T_(Caliban.Nano.UI.ViewBinder.Resolver)'></a>

## ViewBinder.AddResolver<T>(Resolver) Method

Adds a resolver to the scope.

```csharp
public static void AddResolver<T>(Caliban.Nano.UI.ViewBinder.Resolver resolver)
    where T : System.Windows.FrameworkElement;
```
#### Type parameters

<a name='Caliban.Nano.UI.ViewBinder.AddResolver_T_(Caliban.Nano.UI.ViewBinder.Resolver).T'></a>

`T`

The control type.
#### Parameters

<a name='Caliban.Nano.UI.ViewBinder.AddResolver_T_(Caliban.Nano.UI.ViewBinder.Resolver).resolver'></a>

`resolver` [Resolver(FrameworkElement, object)](Caliban.Nano.UI.ViewBinder.md#Caliban.Nano.UI.ViewBinder.Resolver(System.Windows.FrameworkElement,object) 'Caliban.Nano.UI.ViewBinder.Resolver(System.Windows.FrameworkElement, object)')

The resolver method.

<a name='Caliban.Nano.UI.ViewBinder.Bind(object,object)'></a>

## ViewBinder.Bind(object, object) Method

Recursive binds a view to a view model.

```csharp
public static void Bind(object view, object viewModel);
```
#### Parameters

<a name='Caliban.Nano.UI.ViewBinder.Bind(object,object).view'></a>

`view` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The view to bind.

<a name='Caliban.Nano.UI.ViewBinder.Bind(object,object).viewModel'></a>

`viewModel` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The view model to bind.