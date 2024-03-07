using Elements;
using Elements.Geometry;
using System.Collections.Generic;

namespace WidgetMarkdown
{
    public static class WidgetMarkdown
    {
        /// <summary>
        /// The WidgetMarkdown function.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A WidgetMarkdownOutputs instance containing computed results and the model with any new elements.</returns>
        public static WidgetMarkdownOutputs Execute(Dictionary<string, Model> inputModels, WidgetMarkdownInputs input)
        {
            // Your code here.
            var output = new WidgetMarkdownOutputs();

            var md = $@"### Welcome to the C# (ChatGPT Example Markdown)Fun Zone! 🎉
## Let's Code with [Hypar](https://hypar.io)!

```csharp
class Program
{{
    static void Main(string[] {input.Plug})
    {{
        Console.WriteLine('Welcome to the C# Fun Zone!');
        Console.WriteLine('Let\'s code with style! 🚀');
    }}
}}
```

## Embrace the Power of C#

- Need loops? We got 'em! 🔄
- Want to do some math? C# has your back! ➕➖✖️➗
- Feeling object-oriented? Classes and objects galore! 🧱

## Don't Forget Your Friends!

```csharp
using System;

class Program
{{
    static void Main(string[] {input.Plug})
    {{
        Console.WriteLine('Don\'t forget your friends!');
        Console.WriteLine('using statements are your best pals! 👯‍♂️');
    }}
}}
```

## Conclusion

With C#, your code will be as vibrant as a disco party 🕺💃. So let's get coding and make some magic happen! ✨";

            var note = new Note("Markdown Title", md, false, new Color(), "a");

            output.Model.AddElement(note);
            return output;
        }
    }
}