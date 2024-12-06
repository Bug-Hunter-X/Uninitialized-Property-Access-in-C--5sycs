# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been assigned a value.  This can lead to unexpected behavior or exceptions, depending on the context.

## Bug Description

The `MyClass` contains a property `MyProperty` that is not initialized in the constructor.  The `MyMethod` attempts to access and print the value of `MyProperty` without first setting it. This will result in the output being 0 (the default value for an int).

## Solution

The solution involves initializing the property with a value in the constructor, ensuring that it always has a defined value before being accessed.