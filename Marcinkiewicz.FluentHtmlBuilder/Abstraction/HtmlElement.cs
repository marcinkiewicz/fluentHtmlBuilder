using System;
using System.Collections.Generic;
using System.Text;

namespace Marcinkiewicz.FluentHtmlBuilder.Abstraction
{
    /// <summary>
    /// Html element
    /// </summary>
    public abstract class HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlElement"/> class.
        /// </summary>
        public HtmlElement()
        {
            this.Children = new List<HtmlElement>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlElement"/> class.
        /// </summary>
        /// <param name="stylesCfg">Styles configuration</param>
        public HtmlElement(Action<InlineStyles> stylesCfg)
        {
            this.Children = new List<HtmlElement>();
            this.Styles = new InlineStyles();
            stylesCfg(this.Styles);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlElement"/> class.
        /// </summary>
        /// <param name="styles">Inline styles</param>
        public HtmlElement(InlineStyles styles)
        {
            this.Children = new List<HtmlElement>();
            this.Styles = styles;
        }

        /// <summary>
        /// Gets element styles
        /// </summary>
        protected InlineStyles Styles { get; private set; }

        /// <summary>
        /// Gets a value indicating whether element should not contain closing tag.
        /// </summary>
        protected virtual bool IsSingleElementTag { get; } = false;

        /// <summary>
        /// Gets list of child elements
        /// </summary>
        protected IList<HtmlElement> Children { get; }

        /// <summary>
        /// Gets element tag
        /// </summary>
        protected abstract string ElementTag { get; }

        /// <summary>
        /// Gets custom element properties.
        /// </summary>
        /// <remarks>This can be used to add properties like collspan for table row.</remarks>
        protected virtual Dictionary<string, string> CustomElementProperties { get; } = new Dictionary<string, string>();

        /// <summary>
        /// Add text content to the element
        /// </summary>
        /// <param name="value">Text value</param>
        public void AddContent(string value)
        {
            this.Children.Add(new HtmlValue()
            {
                Content = value,
            });
        }

        /// <summary>
        /// Return HTML representation of the element including children.
        /// </summary>
        /// <returns>Text containing HTML representation of element.</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            // Initial tag
            stringBuilder.Append($"<{this.ElementTag}");

            // Append inline styles if exist
            if (this.Styles != null)
            {
                stringBuilder.Append($" {this.Styles.ToString()} ");
            }

            // Add custom properties
            foreach (var property in this.CustomElementProperties)
            {
                stringBuilder.Append($" {property.Key} = \"{property.Value}\"");
            }

            // Close immediately if element has no closing tag
            if (this.IsSingleElementTag)
            {
                stringBuilder.Append(" />");
            }
            else
            {
                stringBuilder.Append(">");

                // Add children
                foreach (var child in this.Children)
                {
                    stringBuilder.Append(child.ToString());
                }

                // Close
                stringBuilder.Append($"</{this.ElementTag}>");
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Add child element to the list of children
        /// </summary>
        /// <typeparam name="TElement">Element type</typeparam>
        /// <param name="element">Child element</param>
        public void AddChild<TElement>(TElement element)
             where TElement : HtmlElement, new()
        {
            this.Children.Add(element);
        }

        /// <summary>
        /// Add child element to the list of children
        /// </summary>
        /// <typeparam name="TElement">Element type</typeparam>
        /// <typeparam name="TStyles">Styles type</typeparam>
        /// <param name="elementCfg">Element configuration. This parameter is required.</param>
        /// <param name="stylesCfg">Styles configuration</param>
        public void AddChild<TElement, TStyles>(Action<TElement> elementCfg, Action<TStyles> stylesCfg)
             where TElement : HtmlElement, new()
             where TStyles : InlineStyles, new()
        {
            // Create and configure element
            TElement element = new TElement();
            elementCfg?.Invoke(element);

            if (stylesCfg != null)
            {
                // Create, configure and assign styles to the element
                TStyles styles = new TStyles();
                stylesCfg.Invoke(styles);
                element.Styles = styles;
            }

            this.Children.Add(element);
        }

        /// <summary>
        /// Add child element to the list of children
        /// </summary>
        /// <typeparam name="TElement">Element type</typeparam>
        /// <typeparam name="TStyles">Styles type</typeparam>
        /// <param name="elementCfg">Element configuration. This parameter is required.</param>
        /// <param name="styles">Styles</param>
        public void AddChild<TElement, TStyles>(Action<TElement> elementCfg, TStyles styles)
             where TElement : HtmlElement, new()
             where TStyles : InlineStyles, new()
        {
            // Create and configure element
            TElement element = new TElement();
            elementCfg?.Invoke(element);

            if (styles != null)
            {
                // Add styles
                element.Styles = styles;
            }

            this.Children.Add(element);
        }
    }
}
