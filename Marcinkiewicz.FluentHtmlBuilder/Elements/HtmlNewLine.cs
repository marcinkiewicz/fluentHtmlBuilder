using System;
using Marcinkiewicz.FluentHtmlBuilder.Abstraction;

namespace Marcinkiewicz.FluentHtmlBuilder
{
    /// <summary>
    /// Element representing HTML <br></br>
    /// </summary>
    public class HtmlNewLine : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlNewLine"/> class.
        /// </summary>
        public HtmlNewLine()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlNewLine"/> class.
        /// </summary>
        /// <param name="stylesCfg">Styles configuration</param>
        public HtmlNewLine(Action<InlineStyles> stylesCfg)
            : base(stylesCfg)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlNewLine"/> class.
        /// </summary>
        /// <param name="styles">Inline styles</param>
        public HtmlNewLine(InlineStyles styles)
            : base(styles)
        {
        }

        /// <inheritdoc />
        protected override string ElementTag => $"br";

        /// <inheritdoc />
        protected override bool IsSingleElementTag => true;
    }
}
