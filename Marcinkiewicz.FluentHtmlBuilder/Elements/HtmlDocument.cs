using System;
using Marcinkiewicz.FluentHtmlBuilder.Abstraction;

namespace Marcinkiewicz.FluentHtmlBuilder
{
    /// <summary>
    /// Element representing HTML <html></html>
    /// </summary>
    public class HtmlDocument : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlDocument"/> class.
        /// </summary>
        public HtmlDocument()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlDocument"/> class.
        /// </summary>
        /// <param name="stylesCfg">Styles configuration</param>
        public HtmlDocument(Action<InlineStyles> stylesCfg)
            : base(stylesCfg)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlDocument"/> class.
        /// </summary>
        /// <param name="styles">Inline styles</param>
        public HtmlDocument(InlineStyles styles)
            : base(styles)
        {
        }

        /// <inheritdoc />
        protected override string ElementTag => "html";

        /// <summary>
        /// Add <head></head> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="stylesCfg">Styles configuration</param>
        public void AddHead(Action<HtmlHead> elementCfg, Action<InlineStyles> stylesCfg)
            => this.AddChild<HtmlHead, InlineStyles>(elementCfg, stylesCfg);

        /// <summary>
        /// Add <head></head> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="styles">Element styles</param>
        public void AddHead(Action<HtmlHead> elementCfg, InlineStyles styles)
            => this.AddChild<HtmlHead, InlineStyles>(elementCfg, styles);

        /// <summary>
        /// Add <body></body> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="stylesCfg">Styles configuration</param>
        public void AddBody(Action<HtmlBody> elementCfg, Action<InlineStyles> stylesCfg)
            => this.AddChild<HtmlBody, InlineStyles>(elementCfg, stylesCfg);

        /// <summary>
        /// Add <body></body> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="styles">Element styles</param>
        public void AddBody(Action<HtmlBody> elementCfg, InlineStyles styles)
            => this.AddChild<HtmlBody, InlineStyles>(elementCfg, styles);
    }
}
