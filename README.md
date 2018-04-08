# Fluent HTML builder

FlientHtmlBuilder is a simple library to build HTML documents with C# code using fluent syntax.


## Sample usage

You can find example usage in the Marcinkiewicz.FluentHtmlBuilder.Examples folder.

1. Defining and mergin styles

```csharp
// Define header style
InlineStyles h1Style = new InlineStyles();
h1Style.AddStyle("color", "red");
h1Style.AddStyle("text-decoration", "underline");

// Create merged style
InlineStyles h2Style = new InlineStyles();
h2Style.AddStyle("font-size", "5px");
h2Style.MergeWith(h1Style, false);
    
```

2. Sample usage


```csharp
HtmlDocument document = new HtmlDocument();

document.AddBody(body =>
{
    body.AddHeader(header =>
    {
         header.AddContent("Hello world");
    }, h1Style);

	for(int i = 0; i < 2; i++)
	{
	    body.AddDiv(div =>
	    {
	         div.AddContent("Hello world");
	    },
	    styles => 
	    {
	        styles.AddStyle("color", "red");
	    });
    }
}
, (InlineStyles)null);  

return document.ToString();

```

In result we will get following text:

```html
<html>

<body>
    <h1 style="color: red; text-decoration: underline; ">Hello world</h1>
    <div style="color: red; ">Hello world</div>
    <div style="color: red; ">Hello world</div>
</body>

</html>
```


## Creating new tag
Currently there is only a small subset of HTML tags supported. Nevertheless extensibility of the library provides easy way to create own tags.

As example we will create <mat-icon></mat-icon> tag with custom property color.


```csharp
class NewElement : HtmlContainerElement
{
    public NewElement(InlineStyles styles)
        : base(styles)
    {
    }

    public int Color
    {
        set
        {
            this.CustomElementProperties.Add("color",value.ToString());
        }
    }

    override string ElementTag => "newElement";
}
    
```