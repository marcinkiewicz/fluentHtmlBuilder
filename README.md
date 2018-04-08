# Fluent HTML builder

FlientHtmlBuilder is a simple library to build HTML documents with C# code using fluent syntax.


## Sample usage

You can find more comprehensive example here:
https://github.com/marcinkiewicz/fluentHtmlBuilder/blob/master/Marcinkiewicz.FluentHtmlBuilder.Examples/BasicHtml.cs

#### Simple scenarios

1. Defining and merging styles

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


## Custom tags
Currently there is only a small subset of HTML tags supported. Nevertheless extensibility of the library provides easy way to create own tags.

#### Creating custom tag
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

#### Using custom tag
Custom tag can be attached to any element that derives from *HtmlElement*.
  
```csharp
HtmlDocument document = new HtmlDocument();
document.AddChild(new NewElement(styles));
    
```