using IronPython.Hosting;
using Microsoft.Scripting.Hosting;


string codePython = "print('Hello world')";
string filePython = "hello.py";

ScriptEngine engine = Python.CreateEngine();
//engine.Execute(codePython);

//int x = 20;
//ScriptScope scope = engine.CreateScope();
//scope.SetVariable("b", x);
//engine.ExecuteFile(filePython, scope);
//dynamic y = scope.GetVariable("a");
//Console.WriteLine($"a = {y}");

ScriptScope scope = engine.CreateScope();
engine.ExecuteFile(filePython, scope);

//dynamic power = scope.GetVariable("power");
//dynamic printStars = scope.GetVariable("printStars");

//dynamic result = power(5, 4);
//Console.WriteLine(result);
//printStars(10);

dynamic math = scope.GetVariable("math");
Console.WriteLine(math.sin(5));