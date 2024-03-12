### Example of the why we can`t use ICloneable for the Prototype Design Pattern

This example of the ICloneable usage was develop using C# language.

The Prototype Design Pattern is used when its easier to make copies of fully or partially built objects than making new ones. In this example, we learn why we can`t use the ICloneable interface to make this work. Basically, the ICloneable inteface has little to no documentation on how it makes the cloning, and the little it has makes clear that it is doing shallow cloning, not deep recursive cloning as is required for the Prototype to work.

If you're interested in the [udemy course](https://www.udemy.com/course/design-patterns-csharp-dotnet) by [Dmitri Nesteruk](https://www.udemy.com/user/dmitrinesteruk/).
