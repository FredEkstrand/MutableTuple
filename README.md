![Project type](https://github.com/FredEkstrand/ImageFiles/raw/master/CodeIcon.png )

![Version 1.0.0](https://img.shields.io/badge/Version-1.0.0-brightgreen.svg) ![Licence MIT](https://img.shields.io/badge/Licence-MIT-blue.svg) [![codecov](https://codecov.io/gh/FredEkstrand/TemperatureValue/branch/master/graph/badge.svg)](https://codecov.io/gh/FredEkstrand/TemperatureValue)

# Overview

The mutable tuple is similar to the .Net Framework Tuple but, would allow you to change each tuple element value.

### Usage
Excerpt from [(msdn article)](https://msdn.microsoft.com/en-us/library/system.tuple.aspx#Remarks)

Tuples are commonly used in four ways:
* To represent a single set of data. For example, a tuple can represent a database record, and its components can represent individual fields of the record.
* To provide easy access to, and manipulation of, a data set.
* To return multiple values from a method without using out parameters (in C#) or ByRef parameters (in Visual Basic).
* To pass multiple values to a method through a single parameter. For example, the Thread.Start(Object) method has a single parameter that lets you supply one value to the method that the thread executes at startup time. If you supply a Tuple<T1, T2, T3> object as the method argument, you can supply the thread’s startup routine with three items of data.

## Download
The souce code and provided DLL is written in C# and targeted for the .Net Framework 2.0 and later.

You can download the DLL [here](#).

## Getting started
Once downloaded add a reference to the dll in your Visual Studio project.
Then in your code file add the following to the collection of using statement.
```csharp
using Ekstrand;
```
When you want to use the mutable tuple in your code just type MTuple and follow the intellisense. 

Example below use of MTuple\<T> for string.
```csharp
[inside some method]
MTuple<string> name = new MTuple<string>();
name.Item1 = tbxName.Text.Trim();

``` 
## API Reference

Class documentation on mutable tuple can be found [here](#).

## History
 1.0.0 Initial release into the wild.
 
## Contributing
If you'd like to contribute, please fork the repository and use a feature
branch. Pull requests are always welcome.

## Contact
Fred Ekstrand 
email: fredekstrandgithub@gmail.com
 
## Licensing
This project is licensed under the MIT License - see the LICENSE.md file for details.

## Acknowledgments
Mutable Tuple code is based on the .NET Framework reference source code for Tuple.
( Why reinvent the wheel? )

##### Note:
Starting with .Net 4.7 Microsoft has included ValueTuple which is the same ability as this code base.
